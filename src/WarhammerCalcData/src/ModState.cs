namespace WarhammerCalcData
{
    public partial struct RollLineSimple
    {

        /// <summary>
        /// Handles special cases for weapons such as Tesla weapons,
        /// mortal wounds, auto hitting weapons like flamers, etc.
        /// </summary>
        public enum State
        {
            NormalState = 0,
            Tesla,
            Autohit,
            Na,
            MortalWound
        }
    }
}
