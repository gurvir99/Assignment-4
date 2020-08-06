namespace Assignment_4
{
    partial class BMICalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialLabel = new System.Windows.Forms.Label();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricLable = new System.Windows.Forms.Label();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ValuesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLable = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextbox = new System.Windows.Forms.TextBox();
            this.WeightTextbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.ValuesTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Title_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title_Label.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Title_Label.Location = new System.Drawing.Point(200, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(251, 52);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "BMI Calculator";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.00386F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.99614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel1.Controls.Add(this.ImperialLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MetricLable, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadioButton, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(89, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.82563F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 44);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ImperialLabel
            // 
            this.ImperialLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.ImperialLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImperialLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ImperialLabel.Location = new System.Drawing.Point(3, 0);
            this.ImperialLabel.Name = "ImperialLabel";
            this.ImperialLabel.Size = new System.Drawing.Size(141, 40);
            this.ImperialLabel.TabIndex = 0;
            this.ImperialLabel.Text = "Imperial";
            this.ImperialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialRadioButton.Checked = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(153, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(33, 34);
            this.ImperialRadioButton.TabIndex = 2;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricLable
            // 
            this.MetricLable.BackColor = System.Drawing.Color.SandyBrown;
            this.MetricLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MetricLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MetricLable.Location = new System.Drawing.Point(323, 0);
            this.MetricLable.Name = "MetricLable";
            this.MetricLable.Size = new System.Drawing.Size(147, 40);
            this.MetricLable.TabIndex = 1;
            this.MetricLable.Text = "Metric";
            this.MetricLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MetricRadioButton.Location = new System.Drawing.Point(265, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(33, 35);
            this.MetricRadioButton.TabIndex = 3;
            this.MetricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // ValuesTableLayoutPanel
            // 
            this.ValuesTableLayoutPanel.ColumnCount = 2;
            this.ValuesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ValuesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ValuesTableLayoutPanel.Controls.Add(this.HeightLable, 0, 0);
            this.ValuesTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.ValuesTableLayoutPanel.Controls.Add(this.HeightTextbox, 1, 0);
            this.ValuesTableLayoutPanel.Controls.Add(this.WeightTextbox, 1, 1);
            this.ValuesTableLayoutPanel.Location = new System.Drawing.Point(89, 164);
            this.ValuesTableLayoutPanel.Name = "ValuesTableLayoutPanel";
            this.ValuesTableLayoutPanel.RowCount = 2;
            this.ValuesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ValuesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ValuesTableLayoutPanel.Size = new System.Drawing.Size(475, 70);
            this.ValuesTableLayoutPanel.TabIndex = 2;
            this.ValuesTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ValuesTableLayoutPanel_Paint);
            // 
            // HeightLable
            // 
            this.HeightLable.BackColor = System.Drawing.Color.Khaki;
            this.HeightLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightLable.ForeColor = System.Drawing.Color.Black;
            this.HeightLable.Location = new System.Drawing.Point(3, 0);
            this.HeightLable.Name = "HeightLable";
            this.HeightLable.Size = new System.Drawing.Size(231, 35);
            this.HeightLable.TabIndex = 0;
            this.HeightLable.Text = "Your Height (Mt/Inch)";
            this.HeightLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WeightLabel
            // 
            this.WeightLabel.BackColor = System.Drawing.Color.Khaki;
            this.WeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WeightLabel.Location = new System.Drawing.Point(3, 35);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(231, 33);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "Your Weight (Kg/Pounds)";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WeightLabel.Click += new System.EventHandler(this.WeightLabel_Click);
            // 
            // HeightTextbox
            // 
            this.HeightTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightTextbox.Location = new System.Drawing.Point(240, 3);
            this.HeightTextbox.MaxLength = 9;
            this.HeightTextbox.Name = "HeightTextbox";
            this.HeightTextbox.Size = new System.Drawing.Size(232, 30);
            this.HeightTextbox.TabIndex = 3;
            this.HeightTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeightTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTextbox_KeyPress);
            // 
            // WeightTextbox
            // 
            this.WeightTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightTextbox.Location = new System.Drawing.Point(240, 38);
            this.WeightTextbox.MaxLength = 9;
            this.WeightTextbox.Name = "WeightTextbox";
            this.WeightTextbox.Size = new System.Drawing.Size(232, 30);
            this.WeightTextbox.TabIndex = 3;
            this.WeightTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WeightTextbox.TextChanged += new System.EventHandler(this.WeightTextbox_TextChanged);
            this.WeightTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTextbox_KeyPress);
            // 
            // CalculateButton
            // 
            this.CalculateButton.AutoSize = true;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.ForeColor = System.Drawing.Color.Black;
            this.CalculateButton.Location = new System.Drawing.Point(89, 265);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(180, 39);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // BMITextBox
            // 
            this.BMITextBox.Location = new System.Drawing.Point(209, 344);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.ReadOnly = true;
            this.BMITextBox.Size = new System.Drawing.Size(352, 45);
            this.BMITextBox.TabIndex = 4;
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(92, 345);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(111, 45);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(381, 265);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(183, 39);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ValuesTableLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Title_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ValuesTableLayoutPanel.ResumeLayout(false);
            this.ValuesTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ImperialLabel;
        private System.Windows.Forms.Label MetricLable;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.TableLayoutPanel ValuesTableLayoutPanel;
        private System.Windows.Forms.Label HeightLable;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextbox;
        private System.Windows.Forms.TextBox HeightTextbox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ResetButton;
    }
}

