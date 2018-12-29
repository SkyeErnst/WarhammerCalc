using System;
using System.Drawing.Text;

namespace MathHammer.src.StatBlocks
{
    interface IStats
    {
        int Tough { get; }
        int Save { get; }
        int InvulSave { get; }
        int Wounds { get; }
    }
}
