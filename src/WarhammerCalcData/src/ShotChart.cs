using RandomNumberUtility;
using System.Collections.Generic;

namespace WarhammerCalcData
{
    public struct ShotChart
    {
        ///// <summary>
        ///// A container for every shot that has been taken
        ///// </summary>
        ////public int[] ShotsTaken;
        ///// <summary>
        ///// Contains only the shots that have hit
        ///// </summary>
        //public int[] ShotsHit;
        ///// <summary>
        ///// Contains only the shots that have missed.
        ///// </summary>
        //public int[] ShotsMissed;
        ///// <summary>
        ///// Container for the successful wound rolls
        ///// </summary>
        //public int[] SuccessfulWounds;
        //public int[] FailedSaves;
        //public int[] Damage;
        //public int[] RerolledShots;
        ////public int[] FinalHitList;
        //public int[] RerolledHits;
        public RollLineSimple[] RollStats;

        public readonly int WsBs;
        public readonly int FlatShots;
        public readonly int Strength;
        public readonly int Ap;
        public readonly int DamageDiceNum;
        public readonly int DamageDiceType;
        public readonly int Tough;
        public readonly int Save;
        public readonly int InvulSave;
        public readonly int ShotDiceNum;
        public readonly int ShotDiceType;
        public readonly int NumberOfShotsToMake;
        public readonly int FlatDamage;
        public readonly int WoundXValue;
        public readonly int WoundMortalXValue;
        public readonly int MortalWoundDamageValue;
        public readonly int ModifiedApWoundRollMinimum;
        public readonly int ModifiedApValue;
        public readonly int ModifiedDamageWoundRollMinimum;
        public readonly int ModifiedDamageValue;
        public readonly int TeslaShotAddition;

        public readonly bool DontReroll;
        public readonly bool ShouldRerollOnesHit;
        public readonly bool ShouldRerollMisses;
        public readonly bool ShouldRerollFailedWounds;
        public readonly bool ShouldRerollWoundsOfOne;
        public readonly bool ShouldAutohit;
        public readonly bool ShouldWoundOnX;
        public readonly bool ShouldMortalWoundOnX;
        public readonly bool IsTeslaWeapon;
        public readonly bool HasVariableShots;
        public readonly bool HasVariableDamage;
        public readonly bool ResolveWithModifiedAp;
        public readonly bool ResolveWithModifiedDamage;
        public readonly bool ResolveNormally;

        public readonly string NaText;
        public readonly string TeslaText;
        public readonly string AutohitText;
        public readonly string MortalWoundText;

        public ShotChart(
            int scoreWsBs,
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
            int flatDamage,
            int woundXValue,
            int woundMortalXValue,
            int modifiedApWoundRollMinimum,
            int modifiedApValue,
            int modifiedDamageWoundRollMinimum,
            int modifiedDamageValue,
            bool rerollNone,
            bool rerollOnes,
            bool rerollMisses,
            bool rerollWounds,
            bool shouldRerollWoundsOfOne,
            bool shouldAutohit,
            bool shouldWoundOnX,
            bool shouldMortalWoundOnX,
            bool isTeslaWeapon,
            bool hasVariableShots,
            bool hasVariableDamage,
            bool resolveNormally,
            bool resolveWithModifiedAp,
            bool resolveWithModifiedDamage
            )
        {
            WsBs = scoreWsBs;
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
            FlatDamage = flatDamage;
            WoundXValue = woundXValue;
            WoundMortalXValue = woundMortalXValue;
            MortalWoundDamageValue = 1;
            TeslaShotAddition = 2;

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
            ShouldWoundOnX = shouldWoundOnX;
            ShouldMortalWoundOnX = shouldMortalWoundOnX;
            IsTeslaWeapon = isTeslaWeapon;
            HasVariableShots = hasVariableShots;
            HasVariableDamage = hasVariableDamage;
            ResolveWithModifiedAp = resolveWithModifiedAp;
            ResolveWithModifiedDamage = resolveWithModifiedDamage;
            ResolveNormally = resolveNormally;
            ModifiedApWoundRollMinimum = modifiedApWoundRollMinimum;
            ModifiedApValue = modifiedApValue;
            ModifiedDamageWoundRollMinimum = modifiedDamageWoundRollMinimum;
            ModifiedDamageValue = modifiedDamageValue;

            // Sets the number of shots to be taken, depending on if the shot number is 
            // variable or flat.
            if (true == hasVariableDamage)
            {
                NumberOfShotsToMake = 0;

                for (int i = 0; i < ShotDiceNum; i++)
                {
                    NumberOfShotsToMake += Generator.GetRandomNumber(1, ShotDiceType);
                }
            }
            else
            {
                NumberOfShotsToMake = flatShots;
            }


            //ShotsMissed = new int[NumberOfShotsToMake];
            //ShotsHit = new int[NumberOfShotsToMake];
            ////ShotsTaken = new int[NumberOfShotsToMake];
            //SuccessfulWounds = new int[NumberOfShotsToMake];
            //FailedSaves = new int[NumberOfShotsToMake];
            //Damage = new int[NumberOfShotsToMake];
            //RerolledShots = new int[NumberOfShotsToMake];
            ////FinalHitList = new int[NumberOfShotsToMake];
            //RerolledHits = new int[NumberOfShotsToMake];
            RollStats = new RollLineSimple[NumberOfShotsToMake];


            // Initializes arrays to value of -1, for ease
            // of debugging in case of error.

            //List<object> arrLs = new List<object>
            //{
            //    //ShotsMissed,
            //    //ShotsHit,
            //    //ShotsTaken,
            //    //SuccessfulWounds,
            //    //FailedSaves,
            //    //Damage,
            //    //RerolledShots,
            //    //FinalHitList,
            //    //RerolledHits,
            //    RollStats
            //};

            //foreach (object obj in arrLs)
            //{
            //    if (obj is RollLineSimple)
            //    {
            //        PopulateArray(RollStats, new RollLineSimple());
            //    }
            //    else
            //    {
            //        PopulateArray((int[])obj, -1);
            //    }
            //}

            PopulateArray(RollStats, new RollLineSimple());
        }

        private static void PopulateArray<T>(IList<T> arrToPop, T value)
        {
            int len = arrToPop.Count;

            for (int i = 0; i < len; i++)
            {
                arrToPop[i] = value;
            }
        }
    }
}