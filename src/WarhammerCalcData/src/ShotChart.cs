using RandomNumberUtility;

namespace WarhammerCalcData
{
    public struct ShotChart
    {
        public int[] ShotsTaken;
        public int[] InitialShotsHit;
        public int[] ShotsMissed;
        public int[] SuccessfulWounds;
        public int[] FailedSaves;
        public int[] Damage;
        public int[] RerolledShots;
        public int[] FinalHitList;
        public int[] RerolledHits;
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
        public readonly int ShotsToTake;
        public readonly int FlatDamage;
        public readonly int WoundXValue;
        public readonly int WoundMortalXValue;
        public readonly int MortalWoundDamageValue;
        public readonly int ModifiedApWoundRollMinimum;
        public readonly int ModifiedApValue;
        public readonly int ModifiedDamageWoundRollMinimum;
        public readonly int ModifiedDamageValue;

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
                ShotsToTake = 0;

                for (int i = 0; i < ShotDiceNum; i++)
                {
                    ShotsToTake += Generator.GetRandomNumber(1, ShotDiceType);
                }
            }
            else
            {
                ShotsToTake = flatShots;
            }

            ShotsMissed = new int[ShotsToTake];
            InitialShotsHit = new int[ShotsToTake];
            ShotsTaken = new int[ShotsToTake];
            SuccessfulWounds = new int[ShotsToTake];
            FailedSaves = new int[ShotsToTake];
            Damage = new int[ShotsToTake];
            RerolledShots = new int[ShotsToTake];
            FinalHitList = new int[ShotsToTake];
            RerolledHits = new int[ShotsToTake];
            RollStats = new RollLineSimple[ShotsToTake];

        }

        private static void PopulateArray<T>(T[] arrToPop, T value)
        {
            int len = arrToPop.Length;

            for (int i = 0; i < len; i++)
            {
                arrToPop[i] = value;
            }
        }
    }
}