using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment_4
{
    //Student: Gurvir Singh #301108852
    //Course: Programming 2 - COMP123001
    //Semester: Summer 2020
    //Date last modified: 2020-08-07
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        //timer added to the splashform in order to close it after 3 seconds
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.BMICalculatorForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
