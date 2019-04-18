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
        /// This shot caused the tesla effect to trigger
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
        MortalWound
    }
}