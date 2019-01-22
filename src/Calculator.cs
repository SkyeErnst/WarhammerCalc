using System;
using System.Collections.Generic;
using System.Drawing;

namespace MathHammer
{
    public class Calculator
    {
        private readonly Random _rand;

        public Calculator()
        {
            _rand = new Random();
        }

        public Chart Roll(ref Chart chart)
        {
            for (int i = 0; i < chart.Shots; i++)
            {
                if(true == RollHit(ref chart, i))
                {
                    if (true == RollWound(ref chart, i))
                    {
                        if (false == RollSave(ref chart, i))
                        {
                            RollDamage(ref chart, i);
                        }
                    }
                } 
            }

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
                int currShot = 0;
                chart.RollStats.Add(new RollLine());

                chart.ShotsTaken.Add((currShot = _rand.Next(1, 7)));
                chart.RollStats[i]._hitValue.Text = currShot.ToString();

                if (currShot >= chart.WsBs)
                {
                    chart.InitialShotsHit.Add((currShot));
                    chart.RollStats[i]._hitValue.ForeColor = chart.SuccsessColor;
                    chart.RollStats[i]._rerollValue.Text = chart.NAText;
                    return true;
                }
                else
                {
                    if (chart.DontReroll == true)
                    {
                        chart.ShotsMissed.Add(currShot);
                        chart.RollStats[i]._hitValue.ForeColor = chart.FailColor;
                        chart.RollStats[i]._rerollValue.Text = chart.NAText;
                        return false;
                    }
                    if (chart.ShouldRerollOnes == true && currShot == 1)
                    {
                        chart.RerolledShots.Add(currShot = _rand.Next(1, 7));
                    }
                    else if (chart.ShouldRerollMisses == true)
                    {
                        chart.RerolledShots.Add(currShot = _rand.Next(1, 7));
                    }

                    if (currShot >= chart.WsBs)
                    {
                        chart.RerolledHits.Add((currShot));
                        chart.RollStats[i]._hitValue.ForeColor = chart.SuccsessColor;
                        return true;
                    }
                    else
                    {
                        chart.RollStats[i]._hitValue.ForeColor = chart.FailColor;
                        return false;
                    }
                }
        }

        private bool RollWound(ref Chart chart, int i)
        {
            int target = 0;

            // Set the target for the to wound roll.
            if ((chart.Strength == (chart.Tough * 2)) || chart.Strength >= (chart.Tough * 2)) // strength equal to or double tough, 2+
            {
                target = 2;
            }
            else if (chart.Strength > chart.Tough) // strength greater than toughness, 3+
            {
                target = 3;
            }
            else if (chart.Strength == chart.Tough) // both equal, 4+
            {
                target = 4;
            }
            else if (chart.Strength < chart.Tough) // str lower than tough, 5+
            {
                target = 5;
            }
            else if ((chart.Tough == (chart.Strength / 2)) || (chart.Tough >= (chart.Strength / 2))
            ) // str is 1/2 or less than tough
            {
                target = 6;
            }

            // Rolls for wounds
            int currWoundRoll = 0;

            currWoundRoll = _rand.Next(1, 7);

            chart.RollStats[i]._woundValue.Text = currWoundRoll.ToString();


            if (currWoundRoll >= target)
            {
                chart.SuccessfulWounds.Add(currWoundRoll);
                chart.RollStats[i]._woundValue.ForeColor = chart.SuccsessColor;
                return true;
            }
            else
            {
                chart.RollStats[i]._woundValue.ForeColor = chart.FailColor;
                return false;
            }
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
                saveToUse = chart.Save + chart.Ap;
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
            for (int j = 0; j < chart.DiceNum; j++)
            {
                int roll = _rand.Next(1, chart.DiceType + 1);
                innerTotal += roll;
            }

            chart.Damage.Add(innerTotal);
            chart.RollStats[i]._damageValue.Text = innerTotal.ToString();
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
        internal readonly int Shots;
        internal readonly int Strength;
        internal readonly int Ap;
        internal readonly int DiceNum;
        internal readonly int DiceType;
        internal readonly int Tough;
        internal readonly int Save;
        internal readonly int InvulSave;

        internal readonly Color SuccsessColor;
        internal readonly Color FailColor;
        internal readonly Color DefaultColor;

        internal readonly bool DontReroll;
        internal readonly bool ShouldRerollOnes;
        internal readonly bool ShouldRerollMisses;
        internal readonly bool ShouldRerollWounds;

        internal readonly string NAText;

        public Chart(int stats,
            int shots,
            int strength,
            int ap,
            int diceNum,
            int diceType,
            int tough,
            int save,
            int invulSave,
            bool rNone,
            bool rOnes,
            bool rMisses,
            bool rWounds)
        {
            WsBs = stats;
            Shots = shots;
            Strength = strength;
            Ap = ap;
            DiceNum = diceNum;
            DiceType = diceType;
            Tough = tough;
            Save = save;
            InvulSave = invulSave;

            SuccsessColor = Color.DarkGreen;
            FailColor = Color.DarkRed;
            DefaultColor = Color.Black;

            NAText = "N/A";

            DontReroll = rNone;
            ShouldRerollOnes = rOnes;
            ShouldRerollMisses = rMisses;
            ShouldRerollWounds = rWounds;

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