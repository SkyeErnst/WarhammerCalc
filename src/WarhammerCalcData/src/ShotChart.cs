using RandomNumberUtility;
using System.Collections.Generic;

namespace WarhammerCalcData
{
    public struct ShotChart
    {
        /// <summary>
        /// The values of each roll type, their state, and outcome.
        /// </summary>
        public List<RollLine> RollStats;

        /// <summary>
        /// Represents the ballistic score or weapons score
        /// of the attacking unit
        /// </summary>
        public readonly int WsBs;

        /// <summary>
        /// The non-variable number of shots to fire.
        /// Can potentially be zero if variable shots is used instead.
        /// </summary>
        public readonly int FlatShots;

        /// <summary>
        /// The strength of the firing weapon.
        /// </summary>
        public readonly int Strength;

        /// <summary>
        /// The armor penetration value of the firing weapons
        /// </summary>
        public readonly int Ap;

        /// <summary>
        /// The number of damage dice to roll.
        /// I.E. the 2 in 2d6
        /// </summary>
        public readonly int DamageDiceNum;

        /// <summary>
        /// The number of sides on the damage dice.
        /// I.E. the 6 in 2d6
        /// </summary>
        public readonly int DamageDiceType;

        /// <summary>
        /// Toughness of the defending unit.
        /// </summary>
        public readonly int Tough;

        /// <summary>
        /// Armor save value for the defending unit.
        /// </summary>
        public readonly int Save;

        /// <summary>
        /// Represents the invulnerability save of the defending unit.
        /// If unit has no such save, value is set to zero.
        /// </summary>
        public readonly int InvulSave;

        /// <summary>
        /// The number of dice to roll for the shot.
        /// I.E. the 2 in 2d6
        /// </summary>
        public readonly int ShotDiceNum;

        /// <summary>
        /// The number of sides on the dice to roll
        /// I.E. the 6 in 2d6
        /// </summary>
        public readonly int ShotDiceType;

        /// <summary>
        /// The total number of shots to fire.
        /// This can either equal to FlatShots if variable shots is not used,
        /// otherwise this value is calculated upon instantiation based on
        /// the values for variable shot number.
        /// </summary>
        public readonly int NumberOfShotsToMake;

        /// <summary>
        /// The damage each shot will do, assuming the weapon cannot have variable damage.
        /// </summary>
        public readonly int FlatDamage;

        /// <summary>
        /// Used in conjunction with ShouldWoundOnX, this value will override the wound target.
        /// </summary>
        public readonly int WoundXValue;

        /// <summary>
        /// Used in conjunction with ShouldMortalWoundOnX, wounds of this value or higher
        /// will also cause a mortal wound.
        /// </summary>
        public readonly int WoundMortalXValue;

        /// <summary>
        /// The damage that a mortal wound should cause.
        /// Default value is one.
        /// </summary>
        /// <remarks>T
        /// This will likely never change, unless GW decides to change
        /// how much damage mortal wounds do, which is fairly unlikely.
        /// </remarks>
        public readonly int MortalWoundDamageValue;
        /// <summary>
        /// The minimum value that a wound roll must meet or exceed to cause an AP override.
        /// </summary>
        public readonly int ModifiedApWoundRollMinimum;
        /// <summary>
        /// Value to override the unit's normal AP with.
        /// </summary>
        public readonly int ModifiedApValue;
        /// <summary>
        /// The minimum value that a wound roll must meet or exceed to cause a damage override.
        /// </summary>
        public readonly int ModifiedDamageWoundRollMinimum;
        /// <summary>
        /// The damage to override with when ModifiedDamageWoundRollMinimum has been met.
        /// </summary>
        public readonly int ModifiedDamageValue;
        /// <summary>
        /// The number of extra hits that weapons with the Tesla special rule cause.
        /// </summary>
        public readonly int TeslaShotAddition;

        /// <summary>
        /// Tells the rolling method if we are re rolling at all or not
        /// </summary>
        public readonly bool DontReroll;
        /// <summary>
        /// Tells the rolling method if hit rolls of 1 (one) should be rerolled.
        /// </summary>
        public readonly bool ShouldRerollHitsOfOne;
        /// <summary>
        /// Tells the rolling method if all failed hit rolls should be rerolled.
        /// </summary>
        public readonly bool ShouldRerollMisses;
        /// <summary>
        /// Tells the rolling method if all 
        /// </summary>
        public readonly bool ShouldRerollFailedWounds;
        /// <summary>
        /// Tells the rolling method if wound rolls of 1 (one) should be rerolled.
        /// </summary>
        public readonly bool ShouldRerollWoundsOfOne;
        /// <summary>
        /// Tells the rolling method if it should ignore rolling for hits, and instead
        /// auto count each shot as a hit.
        /// </summary>
        public readonly bool ShouldAutohit;
        /// <summary>
        /// Override for wound target. Set this to true and WoundXValue to the desired
        /// value to complete override setup.
        /// </summary>
        public readonly bool ShouldWoundOnX;
        /// <summary>
        /// Same as ShouldWoundOnX, except that a wound value of X or higher will cause a mortal
        /// wound in addition to the normal damage.
        /// </summary>
        public readonly bool ShouldMortalWoundOnX;
        /// <summary>
        /// Flag for if the firing weapon as the tesla special rule.
        /// </summary>
        public readonly bool IsTeslaWeapon;
        /// <summary>
        /// Whether we are using a static (flat) number of shots, or if the number of shots
        /// can vary.
        /// </summary>
        public readonly bool HasVariableShots;
        /// <summary>
        /// Whether we are using static (flat) damage, or variable damage.
        /// </summary>
        public readonly bool HasVariableDamage;
        /// <summary>
        /// Flag for if the given AP value should be overwritten with the value provided in
        /// ModifiedApValue
        /// </summary>
        public readonly bool ResolveWithModifiedAp;
        /// <summary>
        /// Flag for if the damage of the weapon should be overridden with ModifiedDamageValue
        /// </summary>
        public readonly bool ResolveWithModifiedDamage;
        /// <summary>
        /// Default flag for how to resolve shots. I.E. not to override any default values.
        /// </summary>
        public readonly bool ResolveNormally;

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

            DontReroll = rerollNone;
            ShouldRerollHitsOfOne = rerollOnes;
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

            RollStats = new List<RollLine>();
        }
    }
}