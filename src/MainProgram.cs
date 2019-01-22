using System;
using System.Windows.Forms;

namespace MathHammer
{
    static class MainProgram
    {
        internal static Calculator Calc;
        internal static Ui ui;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Calc = new Calculator();
            ui = new Ui();
            
            Application.Run(ui);
        }
    }
}
