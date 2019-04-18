namespace WarhammerCalcData
{
    /// <summary>
    /// The state of the shot. IE, if it hit, missed, was rerolled and hit, etc.
    /// </summary>
    public enum ShotOutcome
    {
        /// <summary>
        /// A successful dice roll
        /// </summary>
        Success,
        /// <summary>
        /// A failed dice roll
        /// </summary>
        Fail,
        /// <summary>
        /// If the original roll failed, but the new roll did not.
        /// </summary>
        RerollSucces,
        /// <summary>
        /// If both the reroll and the original roll failed.
        /// </summary>
        RerollFail,
        /// <summary>
        /// If this kind of shot can never fail.
        /// For example, auto hitting shots, mortal wounds, etc.
        /// </summary>
        Na,

    }
}
