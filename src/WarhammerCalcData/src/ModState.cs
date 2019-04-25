namespace WarhammerCalcData
{
    /// <summary>
    /// Handles special cases for weapons such as Tesla weapons,
    /// mortal wounds, auto hitting weapons like flamers, etc.
    /// </summary>
    public enum State
    {
        /// <summary>
        /// Default value for enum instance.
        /// Useful for debugging and sorting
        /// </summary>
        DefaultState = 0,
        /// <summary>
        /// No special modifiers are applied
        /// </summary>
        NormalState,
        /// <summary>
        /// This shot was caused by the triggering of the tesla effect
        /// </summary>
        Tesla,
        /// <summary>
        /// This shot has the autohit rule
        /// </summary>
        Autohit,
        /// <summary>
        /// Used if no special state can apply to this roll
        /// </summary>
        Na,
        /// <summary>
        /// State for if an ADDED shot caused a mortal wound.
        /// I.E, this is only applied to the added RollLine objects
        /// that are generated for applying mortal wound damage.
        /// </summary>
        MortalWound
    }
}