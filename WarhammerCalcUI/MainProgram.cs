using System;
using System.Windows.Forms;
using WarhammerCalcDice;

namespace WarhammerCalcUI
{
    static class MainProgram
    {
        internal static DiceRoller diceRoller;
        internal static Ui ui;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            diceRoller = new DiceRoller();
            ui = new Ui();
            
            Application.Run(ui);
        }
    }
}
