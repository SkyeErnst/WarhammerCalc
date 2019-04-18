using System;
using System.Collections.Generic;
using System.Drawing;
using WarhammerCalcData;
using RandomNumberUtility;


namespace WarhammerCalcDice
{
    public class DiceRoller
    {

        private bool _calcTesla = false;
        private bool _calcMortalWound = false;
        private bool _apOverride = false;
        private bool _damageOverride = false;
        private int _teslaShots = 0;
        private int _mortalWoundCount = 0;

        public ShotChart Roll(ref ShotChart chart)
        {
            _calcTesla = false;
            _calcMortalWound = false;
            _teslaShots = 0;
            _mortalWoundCount = 0;

            // As long as each previous hit / wound, etc is successful, continue rolling.
            // Otherwise, go to next roll line.
            for (int i = 0; i < chart.ShotsToTake; i++)
            {
                if (true == RollHit(ref chart, i))
                {
                    if (true == RollWound(ref chart, i))
                    {
                        if (false == RollSave(ref chart, i))
                        {
                            RollDamage(ref chart, i);
                        }
                        //else
                        //{
                        //    chart.RollStats[i]._damageValue.Text = chart.NaText;
                        //}
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
            //if (chart.InitialShotsHit.length > 0)
            //{
            //    chart.FinalHitList.AddRange(chart.InitialShotsHit);
            //}
            //if (chart.RerolledHits.Count > 0)
            //{
            //    chart.FinalHitList.AddRange(chart.RerolledHits);
            //}

            return chart;
        }

        private bool RollHit(ref ShotChart chart, int i)
        {
            // Variable for holding the current randomly generated dice roll
            int currShot = 0;

            //chart.RollStats.Add(new RollLine());

            if (true == chart.ShouldAutohit)
            {
                chart.InitialShotsHit[i] = 0;
                chart.RollStats[i].HitRoll = 0;
                chart.RollStats[i]._hitValue.Text = chart.AutohitText;
                //chart.RollStats[i]._hitValue.ForeColor = chart.SpecialEventColor;
                return true;
            }
            else
            {
                // Randomly generates a dice roll and sets the text property to the roll
                chart.ShotsTaken.Add((currShot = Rand.Next(1, 7)));
                chart.RollStats[i]._hitValue.Text = currShot.ToString();

                // If initial shot is a hit...
                if (currShot >= chart.WsBs)
                {
                    chart.InitialShotsHit.Add((currShot));
                    chart.RollStats[i]._hitValue.ForeColor = chart.SuccessColor;
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
                        chart.RerolledShots.Add(currShot = Rand.Next(1, 7));
                        chart.RollStats[i]._hitRerollValue.Text = currShot.ToString();

                        // If the newly generated roll is a hit
                        if (currShot >= chart.WsBs)
                        {
                            chart.RerolledHits.Add((currShot));
                            chart.RollStats[i]._hitRerollValue.ForeColor = chart.SuccessColor;
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
                    _teslaShots += 2;
                }
            }
            return true;
        }

        private bool RollWound(ref ShotChart chart, int i)
        {
            int woundTarget = 0;

            if (true == chart.ShouldWoundOnX)
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

            currWoundRoll = Rand.Next(1, 7);

            chart.RollStats[i]._woundValue.Text = currWoundRoll.ToString();

            if (currWoundRoll >= woundTarget)
            {
                chart.SuccessfulWounds.Add(currWoundRoll);
                chart.RollStats[i]._woundValue.ForeColor = chart.SuccessColor;

            }
            else if ((true == chart.ShouldRerollWoundsOfOne && 1 == currWoundRoll) || true == chart.ShouldRerollFailedWounds)
            {
                currWoundRoll = Rand.Next(1, 7);

                chart.RollStats[i]._woundRerollValue.Text = currWoundRoll.ToString();
                chart.RollStats[i]._woundValue.ForeColor = chart.FailColor;

                if (currWoundRoll >= woundTarget)
                {
                    chart.SuccessfulWounds.Add(currWoundRoll);
                    chart.RollStats[i]._woundRerollValue.ForeColor = chart.SuccessColor;
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

            if (true == chart.ResolveWithModifiedDamage && currWoundRoll >= chart.ModifiedDamageWoundRollMinimum)
            {
                _damageOverride = true;
            }

            return true;
        }

        private bool RollSave(ref ShotChart chart, int i)
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

            int currSaveRoll = Generator.GetRandomNumber(1, 6);

            chart.RollStats[i]._armorRoll.Text = currSaveRoll.ToString();

            if (currSaveRoll < saveToUse)
            {
                chart.FailedSaves.Add(currSaveRoll);
                chart.RollStats[i]._armorRoll.ForeColor = chart.FailColor;
                return false;
            }
            else
            {
                chart.RollStats[i]._armorRoll.ForeColor = chart.SuccessColor;
                return true;
            }
        }

        private void RollDamage(ref ShotChart chart, int i)
        {
            int innerTotal = 0;

            if (true == chart.HasVariableDamage)
            {
                for (int j = 0; j < chart.DamageDiceNum; j++)
                {
                    int roll = Rand.Next(1, chart.DamageDiceType + 1);
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
                innerTotal = chart.FlatDamage;
            }

            chart.Damage.Add(innerTotal);
            chart.RollStats[i]._damageValue.Text = innerTotal.ToString();
        }

        private void HandleTesla(ref ShotChart chart)
        {
            chart.RollStats.Add(new RollLine());
            chart.RollStats[chart.RollStats.Count - 1]._hitValue.Text = chart.TeslaText;
            chart.RollStats[chart.RollStats.Count - 1]._hitValue.ForeColor = chart.SpecialEventColor;

            if (true == RollWound(ref chart, chart.RollStats.Count - 1))
            {
                if (false == RollSave(ref chart, chart.RollStats.Count - 1))
                {
                    RollDamage(ref chart, chart.RollStats.Count - 1);
                }
            }
        }

        private void HandleMortalWounds(ref ShotChart chart)
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
}
