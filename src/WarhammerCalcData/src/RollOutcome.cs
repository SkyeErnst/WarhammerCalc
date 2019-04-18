namespace WarhammerCalcData
{
    /// <summary>
    /// The outcome of a roll. Hit, miss, etc.
    /// </summary>
    public enum RollOutcome
    {
        /// <summary>
        /// The default value for this enum.
        /// Used to aid in debugging and sorting.
        /// </summary>
        DefaultOutcome = 0,
        /// <summary>
        /// A successful dice roll
        /// </summary>
        Success,
        /// <summary>
        /// A failed dice roll
        /// </summary>
        Fail,
        /// <summary>
        /// If this kind of shot can never fail.
        /// For example, auto hitting shots, mortal wounds, damage, etc.
        /// </summary>
        Na,
    }
}