using System;
using System.Windows.Forms;
using WarhammerCalcDice;

namespace WarhammerCalcUI
{
    static class MainProgram
    {
        public static DiceRoller DiceRollRef;

        internal static Ui UiRef;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DiceRollRef = new DiceRoller();
            UiRef = new Ui();
            
            Application.Run(UiRef);
        }
    }
}
