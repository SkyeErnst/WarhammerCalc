using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHammer.src.StatBlocks
{
    public struct KeqStats : IStats
    {
        public int Tough => 8;
        public int Save => 3;
        public int InvulSave => 5;
        public int Wounds => 28;
    }
}
