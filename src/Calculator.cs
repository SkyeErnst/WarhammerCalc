using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Security.AccessControl;

namespace MathHammer.src
{
    public class Calculator
    {
        private Random _rand;

        public Calculator()
        {
            _rand = new Random();
        }

        public Chart Roll(int wSbS, int shots, int atkStr, int atkAp, int atkDiceNum, int atkDType, int defTough, int defSave, int defInvulSave)
        {
            Chart chart = new Chart();

            RollHit(wSbS, shots, out chart.ShotsTaken, out chart.ShotsHit, out chart.ShotsMissed);
            RollWound(chart.ShotsHit, atkStr, defTough, out chart.SuccessfulWounds, out chart.WoundAttempts, out chart.FailedWounds);
            RollSave(chart.SuccessfulWounds, defSave, defInvulSave, atkAp, out chart.SaveAttempts, out chart.FailedSaves, out chart.SuccessfulSaves);
            RollDamage(chart.FailedSaves, atkDiceNum, atkDType, out chart.Damage);

            chart.Damage.Sort();
            chart.FailedSaves.Sort();
            chart.SaveAttempts.Sort();
            chart.ShotsHit.Sort();
            chart.ShotsTaken.Sort();
            chart.SuccessfulWounds.Sort();
            chart.WoundAttempts.Sort();
            chart.FailedWounds.Sort();
            chart.SuccessfulSaves.Sort();
            chart.ShotsMissed.Sort();

            chart.WsBs = wSbS;
            chart.Shots = shots;
            chart.Strength = atkStr;
            chart.Ap = atkAp;
            chart.DiceNum = atkDiceNum;
            chart.DiceType = atkDType;
            chart.Tough = defTough;
            chart.Save = defSave;

            return chart;
        }

        private void RollHit(int minHitVal, int shots, out List<int> taken, out List<int> hit, out List<int> missed)
        {
            taken = new List<int>();
            hit = new List<int>();
            missed = new List<int>();

            for (int i = 0; i < shots; i++)
            {
                int currShot = 0;

                taken.Add((currShot = _rand.Next(1, 7)));

                if (currShot >= minHitVal)
                {
                    hit.Add((currShot));
                }
                else
                {
                    missed.Add((currShot));
                }
            }
        }

        private void RollWound(List<int> hits, int str, int tough, out List<int> succWounds, out List<int> attemptWound, out List<int> failedWounds)
        {
            int target = 0;
            succWounds = new List<int>();
            attemptWound = new List<int>();
            failedWounds = new List<int>();

            // Set the target for the to wound roll.
            if ((str == (tough * 2)) || str >= (tough * 2)) // strength equal to or double tough, 2+
            {
                target = 2;
            }
            else if (str > tough) // strength greater than toughness, 3+
            {
                target = 3;
            }
            else if (str == tough) // both equal, 4+
            {
                target = 4;
            }
            else if (str < tough) // str lower than tough, 5+
            {
                target = 5;
            }
            else if ((tough == (str / 2)) || (tough >= (str / 2))) // str is 1/2 or less than tough
            {
                target = 6;
            }

            // Rolls for wounds
            for (int i = 0; i < hits.Count; i++)
            {
                int currWoundRoll = 0;
                attemptWound.Add(currWoundRoll = _rand.Next(1, 7));

                if (currWoundRoll >= target)
                {
                    succWounds.Add(currWoundRoll);
                }
                else
                {
                    failedWounds.Add(currWoundRoll);
                }
            }
        }

        private void RollSave(List<int> wounds, int save, int invulSave, int aP, out List<int> saveAttempts, out List<int> failedSaves, out List<int> succSaves)
        {
            saveAttempts = new List<int>();
            failedSaves = new List<int>();
            succSaves = new List<int>();

            int saveToUse;

            if (invulSave != 0)
            {
                if (invulSave < (save + aP))
                {
                    saveToUse = invulSave;
                }
                else
                {
                    saveToUse = save + aP;
                }
            }
            else
            {
                saveToUse = save + aP;
            }

            for (int i = 0; i < wounds.Count; i++)
            {
                int currSaveRoll = _rand.Next(1, 7);

                saveAttempts.Add(currSaveRoll);

                if (currSaveRoll < saveToUse)
                {
                    failedSaves.Add(currSaveRoll);
                }
                else
                {
                    succSaves.Add(currSaveRoll);
                }
            }
        }

        private void RollDamage(List<int> wounds, int diceNum, int diceType, out List<int> damage)
        {
            damage = new List<int>();

            for (int i = 0; i < wounds.Count; i++)
            {
                int innerTotal = 0;
                for (int j = 0; j < diceNum; j++)
                {
                    int roll = _rand.Next(1, diceType + 1);
                    innerTotal += roll;
                }
                damage.Add(innerTotal);
            }
        }
    }

    public struct Chart
    {
        internal List<int> ShotsTaken;
        internal List<int> ShotsHit;
        internal List<int> ShotsMissed;
        internal List<int> WoundAttempts;
        internal List<int> FailedWounds;
        internal List<int> SuccessfulWounds;
        internal List<int> SaveAttempts;
        internal List<int> FailedSaves;
        internal List<int> SuccessfulSaves;
        internal List<int> Damage;

        internal int WsBs;
        internal int Shots;
        internal int Strength;
        internal int Ap;
        internal int DiceNum;
        internal int DiceType;
        internal int Tough;
        internal int Save;
    }
}