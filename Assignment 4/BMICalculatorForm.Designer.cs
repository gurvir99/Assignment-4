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
            this.MetricLable = new System.Windows.Forms.Label();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Title_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title_Label.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Title_Label.Location = new System.Drawing.Point(26, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(251, 52);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "BMI Calculator";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.Controls.Add(this.MetricLable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ImperialLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadioButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 85);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ImperialLabel
            // 
            this.ImperialLabel.BackColor = System.Drawing.Color.Orange;
            this.ImperialLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ImperialLabel.Location = new System.Drawing.Point(3, 0);
            this.ImperialLabel.Name = "ImperialLabel";
            this.ImperialLabel.Size = new System.Drawing.Size(140, 42);
            this.ImperialLabel.TabIndex = 0;
            this.ImperialLabel.Text = "Imperial";
            this.ImperialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MetricLable
            // 
            this.MetricLable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MetricLable.Location = new System.Drawing.Point(3, 42);
            this.MetricLable.Name = "MetricLable";
            this.MetricLable.Size = new System.Drawing.Size(140, 43);
            this.MetricLable.TabIndex = 1;
            this.MetricLable.Text = "Metric";
            this.MetricLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialRadioButton.Checked = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(149, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(33, 36);
            this.ImperialRadioButton.TabIndex = 2;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MetricRadioButton.Location = new System.Drawing.Point(149, 45);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(33, 37);
            this.MetricRadioButton.TabIndex = 3;
            this.MetricRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Title_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ImperialLabel;
        private System.Windows.Forms.Label MetricLable;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
    }
}

