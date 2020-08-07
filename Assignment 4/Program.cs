using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    //Student: Gurvir Singh #301108852
    //Course: Programming 2 - COMP123001
    //Semester: Summer 2020
    //Date last modified: 2020-08-07
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
