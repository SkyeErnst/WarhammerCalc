using RandomNumberUtility;
using WarhammerCalcData;

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
            for (int i = 0; i < chart.NumberOfShotsToMake; i++)
            {
                chart.RollStats.Add(new RollLine());

                if (true == RollHit(ref chart, i))
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

            return chart;
        }

        private bool RollHit(ref ShotChart chart, int i)
        {
            // Variable for holding the current randomly generated dice roll
            int currShot = 0;
            var currLine = chart.RollStats[i];

            if (true == chart.ShouldAutohit)
            {
                currLine.HitRoll = 0;
                currLine.HitState = State.Autohit;
                currLine.HitOutcome = RollOutcome.Na;
                return true;
            }
            else
            {
                // Make initial shot
                currShot = Generator.GetRandomNumber(1, 6);
                currLine.HitRoll = currShot;

                // If initial shot is a hit...
                if (currShot >= chart.WsBs)
                {
                    currLine.HitOutcome = RollOutcome.Success;

                    currLine.HitRerollState = State.Na;
                }
                // if initial shot is a miss...
                else
                {
                    // if we're NOT rerolling
                    if (chart.DontReroll == true)
                    {
                        currLine.HitOutcome = RollOutcome.Fail;
                        return false;
                    }
                    // if we ARE rerolling
                    else if ((chart.ShouldRerollHitsOfOne == true && currShot == 1)
                         ||
                         chart.ShouldRerollMisses == true)
                    {
                        chart.RollStats[i].HitOutcome = RollOutcome.Fail;

                        // Generates the reroll
                        currLine.HitReroll = (currShot = Generator.GetRandomNumber(1, 6));

                        // If the newly generated roll is a hit
                        if (currShot >= chart.WsBs)
                        {
                            currLine.HitReroll = currShot;
                            currLine.HitRerollState = State.NormalState;
                            currLine.HitRerollOutcome = RollOutcome.Success;
                        }
                        // If the newly generated roll is not a hit
                        else
                        {
                            currLine.HitRerollOutcome = RollOutcome.Fail;
                            return false;
                        }
                    }
                    // If we are ONLY rerolling ones, and the shot is not a 1
                    else if (true == chart.ShouldRerollHitsOfOne && 1 != currShot)
                    {
                        chart.RollStats[i].HitOutcome = RollOutcome.Fail;
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
            int currWoundRoll = 0;
            var currLine = chart.RollStats[i];

            if (true == chart.ShouldWoundOnX)
            {
                woundTarget = chart.WoundXValue;
            }
            else
            {
                // Set the target for the to wound roll.

                // strength equal to or double tough, 2+
                if ((chart.Strength == (chart.Tough * 2)) || chart.Strength >= (chart.Tough * 2)) 
                {
                    woundTarget = 2;
                }
                // strength greater than toughness, 3+
                else if (chart.Strength > chart.Tough) 
                {
                    woundTarget = 3;
                }
                // both equal, 4+
                else if (chart.Strength == chart.Tough) 
                {
                    woundTarget = 4;
                }
                // str lower than tough, 5+
                else if (chart.Strength < chart.Tough) 
                {
                    woundTarget = 5;
                }
                // str is 1/2 or less than tough, 6+
                else if (chart.Tough <= (chart.Strength / 2))
                {
                    woundTarget = 6;
                }
            }

            currWoundRoll = Generator.GetRandomNumber(1, 6);
            currLine.Wound = currWoundRoll;

            // if the wound is successful 
            if (currWoundRoll >= woundTarget)
            {
                currLine.WoundOutcome = RollOutcome.Success;
            }
            // if the wound is not successful but we are rerolling
            else if ((true == chart.ShouldRerollWoundsOfOne && 1 == currWoundRoll) || true == chart.ShouldRerollFailedWounds)
            {
                currLine.WoundOutcome = RollOutcome.Fail;

                currLine.WoundReroll = (currWoundRoll = Generator.GetRandomNumber(1,6));

                // If the reroll is a success
                if (currWoundRoll >= woundTarget)
                {
                    currLine.WoundRerollOutcome = RollOutcome.Success;
                }
                // if the reroll fails
                else
                {
                    currLine.WoundRerollOutcome = RollOutcome.Fail;
                    return false;
                }
            }
            // if the wound is not successful and we are not rerolling
            else
            {
                currLine.WoundOutcome = RollOutcome.Fail;
                return false;
            }

            // Handles the special rules for when weapons cause
            // mortal wounds on roll of X or more.
            if (true == chart.ShouldMortalWoundOnX && currWoundRoll >= chart.WoundMortalXValue)
            {
                _mortalWoundCount++;
                _calcMortalWound = true;
                currLine.HitState = State.MortalWound;
            }

            // Handles the special rules for when weapons resolve at a higher AP
            // on a wound roll of X
            if (true == chart.ResolveWithModifiedAp && currWoundRoll >= chart.ModifiedApWoundRollMinimum)
            {
                _apOverride = true;
            }

            // Handles the special rules for weapons that resolve with higher damage on 
            // a wound roll of X.
            if (true == chart.ResolveWithModifiedDamage && currWoundRoll >= chart.ModifiedDamageWoundRollMinimum)
            {
                _damageOverride = true;
            }

            return true;
        }

        private bool RollSave(ref ShotChart chart, int i)
        {
            int saveToUse;
            int currSaveRoll = 0;
            RollLine currLine = chart.RollStats[i];

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

            currLine.ArmorRoll = (currSaveRoll = Generator.GetRandomNumber(1, 6));

            // If the save is failed
            if (currSaveRoll < saveToUse)
            {
                currLine.ArmorRollOutcome = RollOutcome.Fail;
                return false;
            }
            // If the save succeeds
            else
            {
                currLine.ArmorRollOutcome = RollOutcome.Success;
                return true;
            }
        }

        private void RollDamage(ref ShotChart chart, int i)
        {
            int innerTotal = 0;
            var currLine = chart.RollStats[i];

            if (true == chart.HasVariableDamage)
            {
                int roll = 0;

                for (int j = 0; j < chart.DamageDiceNum; j++)
                {
                    roll = Generator.GetRandomNumber(1, 6);

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

            currLine.DamageRoll = innerTotal;
        }

        private void HandleTesla(ref ShotChart chart)
        {
            RollLine currLine = new RollLine();
            chart.RollStats.Add(currLine);
            

            currLine.HitState = State.Tesla;
            currLine.HitRerollState = State.Tesla;
            currLine.HitOutcome = RollOutcome.Na;
            currLine.HitRerollOutcome = RollOutcome.Na;

            // The tesla shots autohit, so we only need to roll for
            // the wound and armor.
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
            RollLine currLine = chart.RollStats[chart.RollStats.Count - 1];

            currLine.HitState = State.MortalWound;
            currLine.HitRoll = 0;
            currLine.HitOutcome = RollOutcome.Na;

            currLine.HitRerollState = State.MortalWound;
            currLine.HitReroll = 0;
            currLine.HitRerollOutcome = RollOutcome.Na;

            currLine.WoundState = State.MortalWound;
            currLine.Wound = 0;
            currLine.WoundOutcome = RollOutcome.Na;

            currLine.WoundRerollState = State.MortalWound;
            currLine.WoundReroll = 0;
            currLine.WoundRerollOutcome = RollOutcome.Na;

            currLine.WoundRerollState = State.MortalWound;
            currLine.WoundReroll = 0;
            currLine.WoundRerollOutcome = RollOutcome.Na;

            currLine.ArmorRollState = State.MortalWound;
            currLine.ArmorRoll = 0;
            currLine.ArmorRollOutcome = RollOutcome.Na;

            currLine.DamageRollState = State.MortalWound;
            currLine.DamageRoll = chart.MortalWoundDamageValue;
            currLine.DamageOutcome = RollOutcome.Na;
        }
    }
}