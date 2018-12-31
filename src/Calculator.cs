using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Security.AccessControl;

namespace MathHammer.src
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

            RollHit(ref chart);
            RollWound(ref chart);
            RollSave(ref chart);
            RollDamage(ref chart);

            chart.Damage.Sort();
            chart.FailedSaves.Sort();
            chart.SaveAttempts.Sort();
            chart.InitialShotsHit.Sort();
            chart.ShotsTaken.Sort();
            chart.SuccessfulWounds.Sort();
            chart.WoundAttempts.Sort();
            chart.FailedWounds.Sort();
            chart.SuccessfulSaves.Sort();
            chart.ShotsMissed.Sort();
            chart.RerolledHits.Sort();
            chart.FinalHitList.Sort();
            chart.MissedRerolledHits.Sort();
            chart.SuccessfulRerolledHits.Sort();

            return chart;
        }

        private void RollHit(ref Chart chart)
        {

            for (int i = 0; i < chart.Shots; i++)
            {
                int currShot = 0;

                chart.ShotsTaken.Add((currShot = _rand.Next(1,7)));

                if (currShot >= chart.WsBs)
                {
                    chart.InitialShotsHit.Add((currShot));
                }
                else
                {
                    if (chart.ShouldRerollOnes == true && currShot == 1)
                    {
                        chart.RerolledHits.Add(currShot = _rand.Next(1, 7));
                    }
                    else if (chart.ShouldRerollMisses == true)
                    {
                        chart.RerolledHits.Add(currShot = _rand.Next(1, 7));
                    }

                    if (currShot >= chart.WsBs)
                    {
                        chart.SuccessfulRerolledHits.Add((currShot));
                    }
                    else
                    {
                        chart.MissedRerolledHits.Add((currShot));
                    }
                }
            }
            chart.FinalHitList.AddRange(chart.InitialShotsHit);
            chart.FinalHitList.AddRange(chart.SuccessfulRerolledHits);
        }

        private void RollWound(ref Chart chart)
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
            else if ((chart.Tough == (chart.Strength / 2)) || (chart.Tough >= (chart.Strength / 2))) // str is 1/2 or less than tough
            {
                target = 6;
            }

            // Rolls for wounds
            for (int i = 0; i < chart.InitialShotsHit.Count; i++)
            {
                int currWoundRoll = 0;
                chart.WoundAttempts.Add(currWoundRoll = _rand.Next(1, 7));

                if (currWoundRoll >= target)
                {
                    chart.SuccessfulWounds.Add(currWoundRoll);
                }
                else
                {
                    chart.FailedWounds.Add(currWoundRoll);
                }
            }
        }

        private void RollSave(ref Chart chart)
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

            for (int i = 0; i < chart.SuccessfulWounds.Count; i++)
            {
                int currSaveRoll = _rand.Next(1, 7);

                chart.SaveAttempts.Add(currSaveRoll);

                if (currSaveRoll < saveToUse)
                {
                    chart.FailedSaves.Add(currSaveRoll);
                }
                else
                {
                    chart.SuccessfulSaves.Add(currSaveRoll);
                }
            }
        }

        private void RollDamage(ref Chart chart)
        {
            for (int i = 0; i < chart.FailedSaves.Count; i++)
            {
                int innerTotal = 0;
                for (int j = 0; j < chart.DiceNum; j++)
                {
                    int roll = _rand.Next(1, chart.DiceType + 1);
                    innerTotal += roll;
                }
                chart.Damage.Add(innerTotal);
            }
        }
    }

    public struct Chart
    {
        internal List<int> ShotsTaken;
        internal List<int> InitialShotsHit;
        internal List<int> ShotsMissed;
        internal List<int> WoundAttempts;
        internal List<int> FailedWounds;
        internal List<int> SuccessfulWounds;
        internal List<int> SaveAttempts;
        internal List<int> FailedSaves;
        internal List<int> SuccessfulSaves;
        internal List<int> Damage;
        internal List<int> RerolledHits;
        internal List<int> FinalHitList;
        internal List<int> MissedRerolledHits;
        internal List<int> SuccessfulRerolledHits;

        internal readonly int WsBs;
        internal readonly int Shots;
        internal readonly int Strength;
        internal readonly int Ap;
        internal readonly int DiceNum;
        internal readonly int DiceType;
        internal readonly int Tough;
        internal readonly int Save;
        internal readonly int InvulSave;

        internal readonly bool ShouldReroll;
        internal readonly bool ShouldRerollOnes;
        internal readonly bool ShouldRerollMisses;
        internal readonly bool ShouldRerollWounds;

        public Chart(int score, int shots, int strength, int ap, int diceNum, int diceType, int tough, int save, int invulSave, bool rNone, bool rOnes, bool rMisses, bool rWounds)
        {
            WsBs = score;
            Shots = shots;
            Strength = strength;
            Ap = ap;
            DiceNum = diceNum;
            DiceType = diceType;
            Tough = tough;
            Save = save;
            InvulSave = invulSave;

            ShouldReroll = rNone;
            ShouldRerollOnes = rOnes;
            ShouldRerollMisses = rMisses;
            ShouldRerollWounds = rWounds;

            ShotsMissed = new List<int>();
            InitialShotsHit = new List<int>();
            ShotsTaken = new List<int>();
            FailedWounds = new List<int>();
            SuccessfulWounds = new List<int>();
            WoundAttempts = new List<int>();
            FailedSaves = new List<int>();
            SuccessfulSaves = new List<int>();
            SaveAttempts = new List<int>();
            Damage = new List<int>();
            RerolledHits = new List<int>();
            FinalHitList = new List<int>();
            MissedRerolledHits = new List<int>();
            SuccessfulRerolledHits = new List<int>();
        }
    }
}