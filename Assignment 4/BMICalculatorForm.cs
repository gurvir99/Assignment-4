using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class BMICalculatorForm : Form
    {
        double height;
        double weight;
        double bmi;
        
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ValuesTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WeightTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (HeightTextbox.Text != "" && WeightTextbox.Text != "")
            {
                if (MetricRadioButton.Checked)
                {
                    height = Convert.ToDouble(HeightTextbox.Text);
                    weight = Convert.ToDouble(WeightTextbox.Text);
                    bmi = (weight) / (height * height);
                    BMITextBox.Text = bmi.ToString("N2");
                }
                else
                {
                    height = Convert.ToDouble(HeightTextbox.Text);
                    weight = Convert.ToDouble(WeightTextbox.Text);
                    bmi = (weight * 703) / (height * height);
                    BMITextBox.Text = bmi.ToString("N2");
                }
            }
        }

        private void HeightTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void WeightTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextbox.Text = "";
            WeightTextbox.Text = "";
            BMITextBox.Text = "";
        }

        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
