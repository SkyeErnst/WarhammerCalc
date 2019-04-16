namespace WarhammerCalcData
{
    public struct RollLineSimple
    {
        private readonly int _hitRollResult;
        private readonly int _hitRerollResult;
        private readonly int _woundRollResult;
        private readonly int _woundRerollResult;
        private readonly int _armorSaveRollResult;
        private readonly int _damageRollResult;

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
            (int hitRoll, 
            int hitReroll, 
            int woundRoll, 
            int woundReroll,
            int armorRoll,
            int damageRoll)
        {
            _hitRollResult = hitRoll;
            _hitRerollResult = hitReroll;
            _woundRollResult = woundRoll;
            _woundRerollResult = woundReroll;
            _armorSaveRollResult = armorRoll;
            _damageRollResult = damageRoll;
        }

        #region Properties

        // The below properties function the same as the kind
        // with the {get;} style, but use a much simpler syntax.

        public int HitRollResult => _hitRollResult;
        public int HitRerollResult => _hitRerollResult;

        public int WoundRollResult => _woundRollResult;
        public int WoundRerollResult => _woundRerollResult;

        public int ArmorSaveRollResult => _armorSaveRollResult;

        public int DamageRollResult => _damageRollResult;

        #endregion
    }
}
