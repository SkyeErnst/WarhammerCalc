using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathHammer.src;

namespace MathHammer.src
{
    static class MainProgram
    {
        internal static Calculator Calc;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Calc = new Calculator();
            
            Application.Run(new UI());
        }
    }
}
