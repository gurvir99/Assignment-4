using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    static class Program
    {
        public static SplashForm splashForm;
        public static BMICalculatorForm BMICalculatorForm;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //new Splashform and BMICalculatorForm object istantiated
            splashForm = new SplashForm();
            BMICalculatorForm = new BMICalculatorForm();

            Application.Run(splashForm);
        }
    }
}
