namespace WarhammerCalcData
{
    /// <summary>
    /// Custom implementation of the KeyValuePair class,
    /// featuring a slimmed down footprint and mutable values.
    /// </summary>
    public class KeyVal<TKey, TValue>
    {
        public KeyVal(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        #region public properties

        public TValue Value { get; set; }

        public TKey Key { get; set; }

        #endregion
    }
}