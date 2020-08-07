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
        //height, weight and bmi variables created.
        double height;
        double weight;
        double bmi;
        
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //string messages to display for results created
            string result1 = "            Underweight                      less than 18.5";
            string result2 = "            Normal                           between 18.5 and 24.9";
            string result3 = "            Overweight                       between 25 and 29.9";
            string result4 = "            Obese                            30 or greater";


            if (HeightTextbox.Text != "" && WeightTextbox.Text != "")
            {
                if (MetricRadioButton.Checked)
                {
                    height = Convert.ToDouble(HeightTextbox.Text);
                    weight = Convert.ToDouble(WeightTextbox.Text);
                    bmi = (weight) / (height * height);
                    BMITextBox.Text = bmi.ToString("N2");
                    if (bmi < 18.5)
                    {
                        ResultTextbox.Text = result1.ToString();
                    }
                    else if (bmi >= 18.5 && bmi < 24.9)
                    {
                        ResultTextbox.Text = result2.ToString();
                    }
                    else if (bmi >= 25 && bmi < 29.9)
                    {
                        ResultTextbox.Text = result3.ToString();
                    }
                    else
                    {
                        ResultTextbox.Text = result4.ToString();
                    }
                    BMIResultLabel.Show();
                    BMIScaleLabel.Show();
                    ResultTextbox.Show();
                }
                else
                {
                    height = Convert.ToDouble(HeightTextbox.Text);
                    weight = Convert.ToDouble(WeightTextbox.Text);
                    bmi = (weight * 703) / (height * height);
                    BMITextBox.Text = bmi.ToString("N2");
                    if (bmi < 18.5)
                    {
                        ResultTextbox.Text = result1.ToString();
                    }
                    else if (bmi >= 18.5 && bmi < 24.9)
                    {
                        ResultTextbox.Text = result2.ToString();
                    }
                    else if (bmi >= 25 && bmi < 29.9)
                    {
                        ResultTextbox.Text = result3.ToString();
                    }
                    else
                    {
                        ResultTextbox.Text = result4.ToString();
                    }
                    BMIResultLabel.Show();
                    BMIScaleLabel.Show();
                    ResultTextbox.Show();
                }
            }
        }

        //methods to make the Height and Weight Textboxes accept only numbers
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

        //method to reset the app by clicking on Reset button
        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextbox.Text = "";
            WeightTextbox.Text = "";
            BMITextBox.Text = "";
            BMIResultLabel.Hide();
            BMIScaleLabel.Hide();
            ResultTextbox.Hide();
        }

        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //method to hide the BMIResultLabel, BMIScaleLabel and ResultTextbox when the form loads
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            BMIResultLabel.Hide();
            BMIScaleLabel.Hide();
            ResultTextbox.Hide();
        }
    }
}
