using System.Collections.Generic;

namespace WarhammerCalcData
{
    public partial struct RollLineSimple
    {
        private KeyVal<State, int, ShotOutcome> _hitRoll;
        private KeyVal<State, int, ShotOutcome> _hitReroll;
        private KeyVal<State, int, ShotOutcome> _woundRoll;
        private KeyVal<State, int, ShotOutcome> _woundReroll;
        private KeyVal<State, int, ShotOutcome> _armorRoll;
        private KeyVal<State, int, ShotOutcome> _damageRoll;

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
            (KeyVal<State, int, ShotOutcome> hitRoll,
            KeyVal<State, int, ShotOutcome> hitReroll,
            KeyVal<State, int, ShotOutcome> woundRoll,
            KeyVal<State, int, ShotOutcome> woundReroll,
            KeyVal<State, int, ShotOutcome> armorRoll,
            KeyVal<State, int, ShotOutcome> damageRoll)
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

        #region Hitting
        public int HitRoll
        {
            get => _hitRoll.Value;
            set => _hitReroll.Value = value;
        }
        public State HitRollState
        {
            get => _hitReroll.Key;
            set => _hitReroll.Key = value;
        }
        public ShotOutcome ShotOutcome
        {
            get => _hitRoll.Outcome;
            set => _hitRoll.Outcome = value;
        }

        public int HitReroll
        {
            get => _hitReroll.Value;
            set => _hitReroll.Value = value;
        }
        public State HitRerollState
        {
            get => _hitReroll.Key;
            set => _hitReroll.Key = value;
        }

        #endregion

        #region Wounding
        public int WoundRoll
        {
            get => _woundRoll.Value;
            set => _woundRoll.Value = value;
        }
        public State WoundRollState
        {
            get => _woundRoll.Key;
            set => _woundRoll.Key = value;
        }
        public ShotOutcome WoundOutcome
        {
            get => _woundRoll.Outcome;
            set => _woundRoll.Outcome = value;
        }

        public int WoundReroll
        {
            get => _woundReroll.Value;
            set => _woundReroll.Value = value;
        }
        public State WoundRerollState
        {
            get => _woundReroll.Key;
            set => _woundReroll.Key = value;
        }
        public ShotOutcome WoundRerollOutcome
        {
            get => _woundReroll.Outcome;
            set => _woundReroll.Outcome = value;
        }

        #endregion

        #region Armor
        public int ArmorRoll 
        {
            get => _armorRoll.Value;
            set => _armorRoll.Value = value;
        }
        public State ArmorRollState
        {
            get => _armorRoll.Key;
            set => _armorRoll.Key = value;
        }
        public ShotOutcome ArmorOutcome
        {
            get => _armorRoll.Outcome;
            set => _armorRoll.Outcome = value;
        }

        #endregion

        #region Damage

        public int DamageRoll
        {
            get => _damageRoll.Value;
            set => _damageRoll.Value = value;
        }
        public State DamageRollState
        {
            get => _damageRoll.Key;
            set => _damageRoll.Key = value;
        }
        #endregion  

        #endregion
    }
}
