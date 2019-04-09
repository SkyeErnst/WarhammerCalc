using System.Collections.Generic;
using System.Drawing;

namespace WarhammerCalcData
{
    public struct ShotChart
    {
        public List<int> ShotsTaken;
        public List<int> InitialShotsHit;
        public List<int> ShotsMissed;
        public List<int> SuccessfulWounds;
        public List<int> FailedSaves;
        public List<int> Damage;
        public List<int> RerolledShots;
        public List<int> FinalHitList;
        public List<int> RerolledHits;
        public List<RollLine> RollStats;

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
        public readonly int FlatDamage;
        public readonly int WoundXValue;
        public readonly int WoundMortalXValue;
        public readonly int MortalWoundDamageValue;
        public readonly int ModifiedApWoundRollMinimum;
        public readonly int ModifiedApValue;
        public readonly int ModifiedDamageWoundRollMinimum;
        public readonly int ModifiedDamageValue;

        public readonly Color SuccessColor;
        public readonly Color FailColor;
        public readonly Color SpecialEventColor;
        public readonly Color DefaultColor;

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
            FlatDamage = flatDamage;
            WoundXValue = woundXValue;
            WoundMortalXValue = woundMortalXValue;
            MortalWoundDamageValue = 1;

            SuccessColor = Color.DarkGreen;
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
