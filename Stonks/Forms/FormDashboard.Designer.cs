using System.Drawing;

namespace Stonks.Forms
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEarningsName = new System.Windows.Forms.Label();
            this.labelSavingsName = new System.Windows.Forms.Label();
            this.labelEarnings = new System.Windows.Forms.Label();
            this.labelSavings = new System.Windows.Forms.Label();
            this.labelSpendingsName = new System.Windows.Forms.Label();
            this.labelSpendings = new System.Windows.Forms.Label();
            this.gaugeSavings = new LiveCharts.WinForms.SolidGauge();
            this.gaugeSpendings = new LiveCharts.WinForms.SolidGauge();
            this.labelRatioESAVE = new System.Windows.Forms.Label();
            this.labelRatioESPEND = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEarningsName
            // 
            this.labelEarningsName.AutoSize = true;
            this.labelEarningsName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEarningsName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelEarningsName.Location = new System.Drawing.Point(79, 70);
            this.labelEarningsName.Name = "labelEarningsName";
            this.labelEarningsName.Size = new System.Drawing.Size(107, 31);
            this.labelEarningsName.TabIndex = 0;
            this.labelEarningsName.Text = "Earnings:";
            // 
            // labelSavingsName
            // 
            this.labelSavingsName.AutoSize = true;
            this.labelSavingsName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSavingsName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSavingsName.Location = new System.Drawing.Point(622, 70);
            this.labelSavingsName.Name = "labelSavingsName";
            this.labelSavingsName.Size = new System.Drawing.Size(97, 31);
            this.labelSavingsName.TabIndex = 0;
            this.labelSavingsName.Text = "Savings:";
            // 
            // labelEarnings
            // 
            this.labelEarnings.AutoSize = true;
            this.labelEarnings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEarnings.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelEarnings.Location = new System.Drawing.Point(101, 101);
            this.labelEarnings.Name = "labelEarnings";
            this.labelEarnings.Size = new System.Drawing.Size(49, 28);
            this.labelEarnings.TabIndex = 1;
            this.labelEarnings.Text = "0.00";
            // 
            // labelSavings
            // 
            this.labelSavings.AutoSize = true;
            this.labelSavings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSavings.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSavings.Location = new System.Drawing.Point(642, 101);
            this.labelSavings.Name = "labelSavings";
            this.labelSavings.Size = new System.Drawing.Size(49, 28);
            this.labelSavings.TabIndex = 1;
            this.labelSavings.Text = "0.00";
            // 
            // labelSpendingsName
            // 
            this.labelSpendingsName.AutoSize = true;
            this.labelSpendingsName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpendingsName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSpendingsName.Location = new System.Drawing.Point(338, 70);
            this.labelSpendingsName.Name = "labelSpendingsName";
            this.labelSpendingsName.Size = new System.Drawing.Size(127, 31);
            this.labelSpendingsName.TabIndex = 0;
            this.labelSpendingsName.Text = "Spendings:";
            // 
            // labelSpendings
            // 
            this.labelSpendings.AutoSize = true;
            this.labelSpendings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpendings.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSpendings.Location = new System.Drawing.Point(369, 101);
            this.labelSpendings.Name = "labelSpendings";
            this.labelSpendings.Size = new System.Drawing.Size(49, 28);
            this.labelSpendings.TabIndex = 1;
            this.labelSpendings.Text = "0.00";
            // 
            // gaugeSavings
            // 
            this.gaugeSavings.Location = new System.Drawing.Point(43, 178);
            this.gaugeSavings.Name = "gaugeSavings";
            this.gaugeSavings.Size = new System.Drawing.Size(306, 338);
            this.gaugeSavings.TabIndex = 2;
            // 
            // gaugeSpendings
            // 
            this.gaugeSpendings.Location = new System.Drawing.Point(475, 216);
            this.gaugeSpendings.Name = "gaugeSpendings";
            this.gaugeSpendings.Size = new System.Drawing.Size(307, 283);
            this.gaugeSpendings.TabIndex = 2;
            // 
            // labelRatioESAVE
            // 
            this.labelRatioESAVE.AutoSize = true;
            this.labelRatioESAVE.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRatioESAVE.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRatioESAVE.Location = new System.Drawing.Point(43, 193);
            this.labelRatioESAVE.Name = "labelRatioESAVE";
            this.labelRatioESAVE.Size = new System.Drawing.Size(277, 31);
            this.labelRatioESAVE.TabIndex = 0;
            this.labelRatioESAVE.Text = "Earnings to Savings Ratio:";
            // 
            // labelRatioESPEND
            // 
            this.labelRatioESPEND.AutoSize = true;
            this.labelRatioESPEND.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRatioESPEND.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRatioESPEND.Location = new System.Drawing.Point(475, 193);
            this.labelRatioESPEND.Name = "labelRatioESPEND";
            this.labelRatioESPEND.Size = new System.Drawing.Size(307, 31);
            this.labelRatioESPEND.TabIndex = 0;
            this.labelRatioESPEND.Text = "Earnings to Spendings Ratio:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(900, 548);
            this.Controls.Add(this.labelRatioESPEND);
            this.Controls.Add(this.labelRatioESAVE);
            this.Controls.Add(this.gaugeSpendings);
            this.Controls.Add(this.gaugeSavings);
            this.Controls.Add(this.labelSpendings);
            this.Controls.Add(this.labelSpendingsName);
            this.Controls.Add(this.labelSavings);
            this.Controls.Add(this.labelEarnings);
            this.Controls.Add(this.labelSavingsName);
            this.Controls.Add(this.labelEarningsName);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEarningsName;
        private System.Windows.Forms.Label labelSavingsName;
        private System.Windows.Forms.Label labelEarnings;
        private System.Windows.Forms.Label labelSavings;
        private System.Windows.Forms.Label labelSpendingsName;
        private System.Windows.Forms.Label labelSpendings;
        private LiveCharts.WinForms.SolidGauge gaugeSavings;
        private LiveCharts.WinForms.SolidGauge gaugeSpendings;
        private System.Windows.Forms.Label labelRatioESAVE;
        private System.Windows.Forms.Label labelRatioESPEND;
    }
}