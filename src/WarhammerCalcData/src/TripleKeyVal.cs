﻿namespace WarhammerCalcData
{
    /// <summary>
    /// Custom implementation of the KeyValuePair class,
    /// featuring a slimmed down footprint and mutable values.
    /// </summary>
    public class TripleKeyVal<TState, TValue, TOutcome>
    {
        public TripleKeyVal(TState state, TValue value, TOutcome outcome)
        {
            State = state;
            Value = value;
            Outcome = outcome;
        }

        #region public properties

        public TValue Value { get; set; }

        public TState State { get; set; }

        public TOutcome Outcome { get; set; }

        #endregion
    }
}