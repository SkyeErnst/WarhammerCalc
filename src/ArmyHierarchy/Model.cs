using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHammer.src.ArmyHierarchy
{
    internal class Model
    {
        internal readonly string ModelName;
        internal readonly ModelStats modelStats;
        internal readonly WeaponStats weaponsStats;

        internal Model
        (
            string modelName,
            int movement,
            int weaponScore,
            int balisticScore,
            int modelStrength,
            int toughness,
            int wounds,
            int attacks,
            int leadership,
            int save,
            int invulSave,
            int range,
            WeaponType type,
            int shotDiceFirst,
            int shotDiceSecond,
            int weaponStrength,
            int aP,
            int damageDiceFirst,
            int damageDiceSecond
        )
        {
            ModelName = modelName;
            modelStats = new ModelStats
            (
                movement,
                weaponScore,
                balisticScore,
                modelStrength,
                toughness,
                wounds,
                attacks,
                leadership,
                save,
                invulSave
            );
            weaponsStats = new WeaponStats
            (
                range,
                type,
                shotDiceFirst,
                shotDiceSecond,
                weaponStrength,
                aP,
                damageDiceFirst,
                damageDiceSecond
            );
        }
    }

    internal struct ModelStats
    {
        internal readonly int Movement;
        internal readonly int WeaponScore;
        internal readonly int BalisticScore;
        internal readonly int Strength;
        internal readonly int Toughness;
        internal int Wounds;
        internal readonly int Attacks;
        internal readonly int Leadership;
        internal readonly int Save;
        internal readonly int InvulnerabilitySave;

        internal ModelStats
        (
            int movement,
            int weaponScore,
            int balisticScore,
            int modelStrength,
            int toughness,
            int wounds,
            int attacks,
            int leadership,
            int save,
            int invulSave)
        {
            Movement = movement;
            WeaponScore = weaponScore;
            BalisticScore = balisticScore;
            Strength = modelStrength;
            Toughness = toughness;
            Wounds = wounds;
            Attacks = attacks;
            Leadership = leadership;
            Save = save;
            InvulnerabilitySave = invulSave;
        }
    }

    internal struct WeaponStats
    {
        internal readonly int Range;
        internal readonly WeaponType Type;
        internal readonly int ShotDiceFirstNumber;
        internal readonly int ShotDiceSecondNumber;
        internal readonly int Strength;
        internal readonly int Ap;
        internal readonly int DamageDiceFirstNumber;
        internal readonly int DamageDiceSecondNumber;

        internal WeaponStats
        (
            int range,
            WeaponType type,
            int shotDiceFirst,
            int shotDiceSecond,
            int weaponStrength,
            int aP,
            int damageDiceFirst,
            int damageDiceSecond)
        {
            Range = range;
            Type = type;
            ShotDiceFirstNumber = shotDiceFirst;
            ShotDiceSecondNumber = shotDiceSecond;
            Strength = weaponStrength;
            Ap = aP;
            DamageDiceFirstNumber = damageDiceFirst;
            DamageDiceSecondNumber = damageDiceSecond;
        }
    }
}