using System;


namespace MathHammer.src.StatBlocks
{
    public struct MeqStats : IStats
    {
        public int Tough => 4;
        public int Save => 3;
        public int InvulSave => 0;
        public int Wounds => 1;
    }
}
