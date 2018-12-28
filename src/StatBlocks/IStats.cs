using System;

namespace MathHammer.src.StatBlocks
{
    interface IStats
    {
        int Tough { get; }
        int Save { get; }
        int InvulSave { get; }
    }
}
