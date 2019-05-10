using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace WarhammerCalcData
{
    /// <summary>
    /// A simplified version of the RollLineDisplay class that
    /// uses custom types rather than objects of type FormControl.
    /// </summary>
    [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Local")]
    public class RollLine
    {
        private TripleKeyVal<State, int, RollOutcome> _hitRoll;
        private TripleKeyVal<State, int, RollOutcome> _hitReroll;
        private TripleKeyVal<State, int, RollOutcome> _woundRoll;
        private TripleKeyVal<State, int, RollOutcome> _woundReroll;
        private TripleKeyVal<State, int, RollOutcome> _armorRoll;
        private TripleKeyVal<State, int, RollOutcome> _armorReRoll;
        private TripleKeyVal<State, int, RollOutcome> _damageRoll;


        /// <summary>
        /// The initial value to assign to the TripleKeyVal objects.
        /// </summary>
        private const int InitialValue = 0;

        public RollLine()
        {
            _hitRoll = new TripleKeyVal<State, int, RollOutcome>(State.DefaultState, InitialValue, RollOutcome.DefaultOutcome);
            _hitReroll = new TripleKeyVal<State, int, RollOutcome>(State.DefaultState, InitialValue, RollOutcome.DefaultOutcome);

            _woundRoll = new TripleKeyVal<State, int, RollOutcome>(State.DefaultState, InitialValue, RollOutcome.DefaultOutcome);
            _woundReroll = new TripleKeyVal<State, int, RollOutcome>(State.DefaultState, InitialValue, RollOutcome.DefaultOutcome);

            _armorRoll = new TripleKeyVal<State, int, RollOutcome>(State.DefaultState, InitialValue, RollOutcome.DefaultOutcome);
            _armorReRoll = new TripleKeyVal<State, int, RollOutcome>(State.DefaultState, InitialValue, RollOutcome.DefaultOutcome);

            _damageRoll = new TripleKeyVal<State, int, RollOutcome>(State.DefaultState, InitialValue, RollOutcome.DefaultOutcome);
        }

        #region Properties

        // The below properties function the same way as the ones that use
        // the {get; set;} syntax, but the syntax for these is much simpler.

        #region Hitting
        public int HitRoll
        {
            get => _hitRoll.Value;
            set => _hitRoll.Value = value;
        }
        public State HitState
        {
            get => _hitRoll.State;
            set => _hitRoll.State = value;
        }
        public RollOutcome HitOutcome
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
            get => _hitReroll.State;
            set => _hitReroll.State = value;
        }
        public RollOutcome HitRerollOutcome
        {
            get => _hitReroll.Outcome;
            set => _hitReroll.Outcome = value;
        }

        #endregion

        #region Wounding
        public int Wound
        {
            get => _woundRoll.Value;
            set => _woundRoll.Value = value;
        }
        public State WoundState
        {
            get => _woundRoll.State;
            set => _woundRoll.State = value;
        }
        public RollOutcome WoundOutcome
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
            get => _woundReroll.State;
            set => _woundReroll.State = value;
        }
        public RollOutcome WoundRerollOutcome
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
            get => _armorRoll.State;
            set => _armorRoll.State = value;
        }
        public RollOutcome ArmorRollOutcome
        {
            get => _armorRoll.Outcome;
            set => _armorRoll.Outcome = value;
        }

        public int ArmorReRoll
        {
            get => _armorReRoll.Value;
            set => _armorReRoll.Value = value;
        }
        public RollOutcome ArmorReRollOutcome
        {
            get => _armorReRoll.Outcome;
            set => _armorReRoll.Outcome = value;
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
            get => _damageRoll.State;
            set => _damageRoll.State = value;
        }
        public RollOutcome DamageOutcome
        {
            get => _damageRoll.Outcome;
            set => _damageRoll.Outcome = value;
        }
        #endregion

        public int[] Raw
        {
            get
            {
                Debug.Assert(_hitRoll != null);
                Debug.Assert(_hitReroll != null);
                Debug.Assert(_woundRoll != null);
                Debug.Assert(_woundReroll != null);
                Debug.Assert(_armorRoll != null);
                Debug.Assert(_armorReRoll != null);
                Debug.Assert(_damageRoll != null);

                int[] raw = new int[6];
                raw[0] = _hitRoll.Value;
                raw[1] = _hitReroll.Value;
                raw[2] = _woundRoll.Value;
                raw[3] = _woundReroll.Value;
                raw[4] = _armorRoll.Value;
                raw[5] = _armorReRoll.Value;
                raw[6] = _damageRoll.Value;

                return raw;
            }
        }

        #endregion
    }
}
