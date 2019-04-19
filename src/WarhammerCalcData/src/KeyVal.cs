namespace WarhammerCalcData
{
    public class KeyVal<TState, TValue>
    {

        public KeyVal(TState state, TValue value)
        {
            State = state;
            Value = value;
        }

        public TState State { get; set; }

        public TValue Value { get; set; }

    }
}
