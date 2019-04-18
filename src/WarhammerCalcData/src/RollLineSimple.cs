using System.Collections.Generic;

namespace WarhammerCalcData
{
    public struct RollLineSimple
    {
        private KeyVal<ModState, int> _hitRoll;
        private KeyVal<ModState, int> _hitReroll;
        private KeyVal<ModState, int> _woundRoll;
        private KeyVal<ModState, int> _woundReroll;
        private KeyVal<ModState, int> _armorRoll;
        private KeyVal<ModState, int> _damageRoll;

        /// <summary>
        /// A simplified version of the RollLine class that
        /// uses base types rather than objects of type FormControl.
        /// </summary>
        /// <param name="hitRoll"></param>
        /// <param name="hitReroll"></param>
        /// <param name="woundRoll"></param>
        /// <param name="woundReroll"></param>
        /// <param name="armorRoll"></param>
        /// <param name="damageRoll"></param>
        public RollLineSimple
            (KeyVal<ModState, int> hitRoll,
            KeyVal<ModState, int> hitReroll,
            KeyVal<ModState, int> woundRoll,
            KeyVal<ModState, int> woundReroll,
            KeyVal<ModState, int> armorRoll,
            KeyVal<ModState, int> damageRoll)
        {
            _hitRoll = hitRoll;
            _hitReroll = hitReroll;
            _woundRoll = woundRoll;
            _woundReroll = woundReroll;
            _armorRoll = armorRoll;
            _damageRoll = damageRoll;
        }

        #region Properties

        // The below properties function the same way as the ones that use
        // the {get;} syntax, but the syntax for these is much simpler.

        public int HitRoll
        {
            get => _hitRoll.Value;
            set => _hitReroll.Value = value;
        }

        
        public ModState HitRollState => _hitRoll.Key;

        public int HitReroll => _hitReroll.Value;
        public ModState HitRerollState => _hitReroll.Key;

        public int WoundRoll => _woundRoll.Value;
        public ModState WoundRollState => _woundRoll.Key;

        public int WoundReroll => _woundReroll.Value;
        public ModState WoundRerollState => _woundReroll.Key;

        public int ArmorRoll => _armorRoll.Value;
        public ModState ArmorRollState => _armorRoll.Key;

        public int DamageRoll => _damageRoll.Value;
        public ModState DamageRollState => _damageRoll.Key;

        #endregion

        /// <summary>
        /// Handles special cases for weapons such as Tesla weapons,
        /// mortal wounds, auto hitting weapons like flamers, etc.
        /// </summary>
        public enum ModState
        {
            NormalState = 0,
            Tesla,
            Autohit,
            Na,
            MortalWound
        }
    }
}
