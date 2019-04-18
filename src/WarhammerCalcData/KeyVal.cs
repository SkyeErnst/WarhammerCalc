namespace WarhammerCalcData
{
    /// <summary>
    /// Custom implementation of the KeyValuePair class,
    /// featuring a slimmed down footprint and mutable values.
    /// </summary>
    public class KeyVal<TKey, TValue, TOutcome>
    {
        public KeyVal(TKey key, TValue value, TOutcome outcome)
        {
            Key = key;
            Value = value;
            Outcome = outcome;
        }

        #region public properties

        public TValue Value { get; set; }

        public TKey Key { get; set; }

        public TOutcome Outcome { get; set; }

        #endregion
    }
}