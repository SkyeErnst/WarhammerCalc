using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MathHammer
{
    public class Calculator
    {
        private readonly Random _rand;

        private bool _calcTesla = false;
        private bool _calcMortalWound = false;
        private bool _apOverride = false;
        private bool _damageOverride = false;
        private int _teslaShots = 0;
        private int _mortalWoundCount = 0;

        public Calculator()
        {
            _rand = new Random();
        }

        public Chart Roll(ref Chart chart)
        {
            _calcTesla = false;
            _calcMortalWound = false;
            _teslaShots = 0;
            _mortalWoundCount = 0;

            int itter = 0;

            // Sets up number of times to run loop depending on if the number of shots is variable or 
            // an explicit number.
            if (false == chart.HasVariableShots)
            {
                itter = chart.FlatShots;
            }
            else
            {
                for (int i = 0; i < chart.ShotDiceNum; i++)
                {
                    itter += _rand.Next(1, chart.ShotDiceType + 1);
                }
            }

            // As long as each previous hit / wound, etc is successful, continue rolling.
            // Otherwise, go to next roll line.
            for (int i = 0; i < itter; i++)
            {
                if (true == RollHit(ref chart, i))
                {
                    if (true == RollWound(ref chart, i))
                    {
                        if (false == RollSave(ref chart, i))
                        {
                            RollDamage(ref chart, i);
                        }
                        else
                        {
                            chart.RollStats[i]._damageValue.Text = chart.NaText;
                        }
                    }
                }
            }

            // Handles the case of a tesla weapon being fired.
            if (true == _calcTesla)
            {
                for (int i = 0; i < _teslaShots; i++)
                {
                    HandleTesla(ref chart);
                }
            }

            if (true == _calcMortalWound)
            {
                for (int i = 0; i < _mortalWoundCount; i++)
                {
                    HandleMortalWounds(ref chart);
                }
            }

            // Puts together the initial hits list and the rerolled hits list.
            if (chart.InitialShotsHit.Count > 0)
            {
                chart.FinalHitList.AddRange(chart.InitialShotsHit);
            }
            if (chart.RerolledHits.Count > 0)
            {
                chart.FinalHitList.AddRange(chart.RerolledHits);
            }

            return chart;
        }

        private bool RollHit(ref Chart chart, int i)
        {
            // Variable for holding the current randomly generated dice roll
            int currShot = 0;

            chart.RollStats.Add(new RollLine());

            if (true == chart.ShouldAutohit)
            {
                chart.InitialShotsHit.Add(0);
                chart.RollStats[i]._hitValue.Text = chart.AutohitText;
                chart.RollStats[i]._hitValue.ForeColor = chart.SpecialEventColor;
                return true;
            }
            else
            {
                // Randomly generates a dice roll and sets the text property to the roll
                chart.ShotsTaken.Add((currShot = _rand.Next(1, 7)));
                chart.RollStats[i]._hitValue.Text = currShot.ToString();

                // If initial shot is a hit...
                if (currShot >= chart.WsBs)
                {
                    chart.InitialShotsHit.Add((currShot));
                    chart.RollStats[i]._hitValue.ForeColor = chart.SuccsessColor;
                    chart.RollStats[i]._hitRerollValue.Text = chart.NaText;
                }
                // if initial shot is a miss.
                else
                {
                    if (chart.DontReroll == true)
                    {
                        chart.ShotsMissed.Add(currShot);
                        chart.RollStats[i]._hitValue.ForeColor = chart.FailColor;
                        //chart.RollStats[i]._hitRerollValue.Text = chart.NaText;
                        return false;
                    }
                    if ((chart.ShouldRerollOnesHit == true && currShot == 1
                         ||
                         chart.ShouldRerollMisses == true))
                    {

                        // Only way to get here is if initial shot fails,
                        // So set the hit value text color to fail
                        chart.RollStats[i]._hitValue.ForeColor = chart.FailColor;

                        // Generates a new dice roll and fills in the re-roll value label with the dice roll
                        chart.RerolledShots.Add(currShot = _rand.Next(1, 7));
                        chart.RollStats[i]._hitRerollValue.Text = currShot.ToString();

                        // If the newly generated roll is a hit
                        if (currShot >= chart.WsBs)
                        {
                            chart.RerolledHits.Add((currShot));
                            chart.RollStats[i]._hitRerollValue.ForeColor = chart.SuccsessColor;
                        }
                        // If the newly generated roll is not a hit
                        else
                        {
                            chart.RollStats[i]._hitRerollValue.ForeColor = chart.FailColor;
                            return false;
                        }
                    }
                    // Handles case of dice roll being greater than 1, but re-roll one's is true
                    else if (true == chart.ShouldRerollOnesHit && 1 != currShot)
                    {
                        //chart.RollStats[i]._hitRerollValue.Text = chart.NaText;
                        chart.RollStats[i]._hitRerollValue.ForeColor = chart.DefaultColor;
                        chart.RollStats[i]._hitValue.ForeColor = chart.FailColor;
                        return false;
                    }
                }

                // Handles case of the weapon having the tesla rule
                if (true == chart.IsTeslaWeapon && 6 == currShot)
                {
                    _calcTesla = true;
                    _teslaShots += 3;
                }
            }
            return true;
        }

        private bool RollWound(ref Chart chart, int i)
        {
            int woundTarget = 0;

            if (true == chart.ShoundWoundOnX)
            {
                woundTarget = chart.WoundXValue;
            }
            else
            {
                // Set the target for the to wound roll.
                if ((chart.Strength == (chart.Tough * 2)) || chart.Strength >= (chart.Tough * 2)) // strength equal to or double tough, 2+
                {
                    woundTarget = 2;
                }
                else if (chart.Strength > chart.Tough) // strength greater than toughness, 3+
                {
                    woundTarget = 3;
                }
                else if (chart.Strength == chart.Tough) // both equal, 4+
                {
                    woundTarget = 4;
                }
                else if (chart.Strength < chart.Tough) // str lower than tough, 5+
                {
                    woundTarget = 5;
                }
                else if ((chart.Tough == (chart.Strength / 2)) || (chart.Tough >= (chart.Strength / 2))
                ) // str is 1/2 or less than tough
                {
                    woundTarget = 6;
                }
            }

            // Rolls for wounds
            int currWoundRoll = 0;

            currWoundRoll = _rand.Next(1, 7);

            chart.RollStats[i]._woundValue.Text = currWoundRoll.ToString();

            if (currWoundRoll >= woundTarget)
            {
                chart.SuccessfulWounds.Add(currWoundRoll);
                chart.RollStats[i]._woundValue.ForeColor = chart.SuccsessColor;

            }
            else if ((true == chart.ShouldRerollWoundsOfOne && 1 == currWoundRoll) || true == chart.ShouldRerollFailedWounds)
            {
                currWoundRoll = _rand.Next(1, 7);

                chart.RollStats[i]._woundRerollValue.Text = currWoundRoll.ToString();
                chart.RollStats[i]._woundValue.ForeColor = chart.FailColor;

                if (currWoundRoll >= woundTarget)
                {
                    chart.SuccessfulWounds.Add(currWoundRoll);
                    chart.RollStats[i]._woundRerollValue.ForeColor = chart.SuccsessColor;
                }
                else
                {
                    chart.RollStats[i]._woundRerollValue.ForeColor = chart.FailColor;
                    return false;
                }
            }
            else
            {
                chart.RollStats[i]._woundValue.ForeColor = chart.FailColor;
                return false;
            }

            if (true == chart.ShouldMortalWoundOnX && currWoundRoll >= chart.WoundMortalXValue)
            {
                _mortalWoundCount++;
                _calcMortalWound = true;
            }
            if (true == chart.ResolveWithModifiedAp && currWoundRoll >= chart.ModifiedApWoundRollMinimum)
            {
                _apOverride = true;
            }

            if (true == chart.ResolveWithModifiedDamage && currWoundRoll >= chart.ModifiedDamageWoundRolllMinimum)
            {
                _damageOverride = true;
            }

            return true;
        }

        private bool RollSave(ref Chart chart, int i)
        {
            int saveToUse;

            if (chart.InvulSave != 0)
            {
                if (chart.InvulSave < (chart.Save + chart.Ap))
                {
                    saveToUse = chart.InvulSave;
                }
                else
                {
                    saveToUse = chart.Save + chart.Ap;
                }
            }
            else
            {
                if (true == _apOverride)
                {
                    _apOverride = false;
                    saveToUse = chart.Save + chart.ModifiedApValue;
                }
                else
                {
                    saveToUse = chart.Save + chart.Ap;
                }
            }
            int currSaveRoll = _rand.Next(1, 7);

            chart.RollStats[i]._armorRoll.Text = currSaveRoll.ToString();

            if (currSaveRoll < saveToUse)
            {
                chart.FailedSaves.Add(currSaveRoll);
                chart.RollStats[i]._armorRoll.ForeColor = chart.FailColor;
                return false;
            }
            else
            {
                chart.RollStats[i]._armorRoll.ForeColor = chart.SuccsessColor;
                return true;
            }
        }

        private void RollDamage(ref Chart chart, int i)
        {
            int innerTotal = 0;

            if (true == chart.HasVariableDamage)
            {
                for (int j = 0; j < chart.DamageDiceNum; j++)
                {
                    int roll = _rand.Next(1, chart.DamageDiceType + 1);
                    innerTotal += roll;
                }
            }
            else if (true == _damageOverride)
            {
                _damageOverride = false;
                innerTotal = chart.ModifiedDamageValue;
            }
            else
            {
                innerTotal = chart.FlatDamge;
            }

            chart.Damage.Add(innerTotal);
            chart.RollStats[i]._damageValue.Text = innerTotal.ToString();
        }

        private void HandleTesla(ref Chart chart)
        {
            chart.RollStats.Add(new RollLine());
            chart.RollStats[chart.RollStats.Count - 1]._hitValue.Text = chart.TeslaText;
            chart.RollStats[chart.RollStats.Count - 1]._hitValue.ForeColor = chart.SpecialEventColor;

            if(true == RollWound(ref chart, chart.RollStats.Count - 1))
            {
                if (false == RollSave(ref chart, chart.RollStats.Count - 1))
                {
                    RollDamage(ref chart, chart.RollStats.Count - 1);
                }
            } 
        }

        private void HandleMortalWounds(ref Chart chart)
        {
            chart.RollStats.Add(new RollLine());
            chart.SuccessfulWounds.Add(0);

            chart.RollStats[chart.RollStats.Count - 1]._hitValue.Text = chart.MortalWoundText;
            chart.RollStats[chart.RollStats.Count - 1]._hitValue.ForeColor = chart.SpecialEventColor;

            chart.RollStats[chart.RollStats.Count - 1]._woundValue.Text = chart.MortalWoundText;
            chart.RollStats[chart.RollStats.Count - 1]._woundValue.ForeColor = chart.SpecialEventColor;

            chart.RollStats[chart.RollStats.Count - 1]._damageValue.Text = chart.MortalWoundDamageValue.ToString();

            chart.Damage.Add(1);
        }
    }
    
    public struct Chart
    {
        internal List<int> ShotsTaken;
        internal List<int> InitialShotsHit;
        internal List<int> ShotsMissed;
        internal List<int> SuccessfulWounds;
        internal List<int> FailedSaves;
        internal List<int> Damage;
        internal List<int> RerolledShots;
        internal List<int> FinalHitList;
        internal List<int> RerolledHits;
        internal List<RollLine> RollStats;

        internal readonly int WsBs;
        internal readonly int FlatShots;
        internal readonly int Strength;
        internal readonly int Ap;
        internal readonly int DamageDiceNum;
        internal readonly int DamageDiceType;
        internal readonly int Tough;
        internal readonly int Save;
        internal readonly int InvulSave;
        internal readonly int ShotDiceNum;
        internal readonly int ShotDiceType;
        internal readonly int FlatDamge;
        internal readonly int WoundXValue;
        internal readonly int WoundMortalXValue;
        internal readonly int MortalWoundDamageValue;
        internal readonly int ModifiedApWoundRollMinimum;
        internal readonly int ModifiedApValue;
        internal readonly int ModifiedDamageWoundRolllMinimum;
        internal readonly int ModifiedDamageValue;

        internal readonly Color SuccsessColor;
        internal readonly Color FailColor;
        internal readonly Color SpecialEventColor;
        internal readonly Color DefaultColor;

        internal readonly bool DontReroll;
        internal readonly bool ShouldRerollOnesHit;
        internal readonly bool ShouldRerollMisses;
        internal readonly bool ShouldRerollFailedWounds;
        internal readonly bool ShouldRerollWoundsOfOne;
        internal readonly bool ShouldAutohit;
        internal readonly bool ShoundWoundOnX;
        internal readonly bool ShouldMortalWoundOnX;
        internal readonly bool IsTeslaWeapon;
        internal readonly bool HasVariableShots;
        internal readonly bool HasVariableDamage;
        internal readonly bool ResolveWithModifiedAp;
        internal readonly bool ResolveWithModifiedDamage;
        internal readonly bool ResolveNormally;

        internal readonly string NaText;
        internal readonly string TeslaText;
        internal readonly string AutohitText;
        internal readonly string MortalWoundText;

        public Chart(
            int stats,
            int flatShots,
            int strength,
            int ap,
            int damageDiceNum,
            int damageDiceType,
            int tough,
            int save,
            int invulSave,
            int shotDiceNum, 
            int shotDiceType,
            int flatDamge,
            int woundXValue, 
            int woundMortalXValue,
            int modifiedApWoundRollMinimum, 
            int modifiedApValue, 
            int modifiedDamageWoundRolllMinimum, 
            int modifiedDamageValue,
            bool rerollNone,
            bool rerollOnes,
            bool rerollMisses,
            bool rerollWounds, 
            bool shouldRerollWoundsOfOne, 
            bool shouldAutohit, 
            bool shoundWoundOnX, 
            bool shouldMortalWoundOnX, 
            bool isTeslaWeapon, 
            bool hasVariableShots, 
            bool hasVariableDamage,
            bool resolveNormally,
            bool resolveWithModifiedAp, 
            bool resolveWithModifiedDamage
            )
        {
            WsBs = stats;
            FlatShots = flatShots;
            Strength = strength;
            Ap = ap;
            DamageDiceNum = damageDiceNum;
            DamageDiceType = damageDiceType;
            Tough = tough;
            Save = save;
            InvulSave = invulSave;
            ShotDiceNum = shotDiceNum;
            ShotDiceType = shotDiceType;
            FlatDamge = flatDamge;
            WoundXValue = woundXValue;
            WoundMortalXValue = woundMortalXValue;
            MortalWoundDamageValue = 1;

            SuccsessColor = Color.DarkGreen;
            FailColor = Color.DarkRed;
            SpecialEventColor = Color.Aquamarine;
            DefaultColor = Color.Black;
            

            NaText = "N/A";
            TeslaText = "TESLA";
            AutohitText = "AUTO";
            MortalWoundText = "MORTAL";

            DontReroll = rerollNone;
            ShouldRerollOnesHit = rerollOnes;
            ShouldRerollMisses = rerollMisses;
            ShouldRerollFailedWounds = rerollWounds;
            ShouldRerollWoundsOfOne = shouldRerollWoundsOfOne;
            ShouldAutohit = shouldAutohit;
            ShoundWoundOnX = shoundWoundOnX;
            ShouldMortalWoundOnX = shouldMortalWoundOnX;
            IsTeslaWeapon = isTeslaWeapon;
            HasVariableShots = hasVariableShots;
            HasVariableDamage = hasVariableDamage;
            ResolveWithModifiedAp = resolveWithModifiedAp;
            ResolveWithModifiedDamage = resolveWithModifiedDamage;
            ResolveNormally = resolveNormally;
            ModifiedApWoundRollMinimum = modifiedApWoundRollMinimum;
            ModifiedApValue = modifiedApValue;
            ModifiedDamageWoundRolllMinimum = modifiedDamageWoundRolllMinimum;
            ModifiedDamageValue = modifiedDamageValue;


            ShotsMissed = new List<int>();
            InitialShotsHit = new List<int>();
            ShotsTaken = new List<int>();
            SuccessfulWounds = new List<int>();
            FailedSaves = new List<int>();
            Damage = new List<int>();
            RerolledShots = new List<int>();
            FinalHitList = new List<int>();
            RerolledHits = new List<int>();
            RollStats = new List<RollLine>();
        }
    }
}