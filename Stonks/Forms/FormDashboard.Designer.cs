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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDashboardEarnings = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelDashboardSpendings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 27);
            this.textBox1.TabIndex = 0;
            // 
            // labelDashboardEarnings
            // 
            this.labelDashboardEarnings.AutoSize = true;
            this.labelDashboardEarnings.Location = new System.Drawing.Point(61, 82);
            this.labelDashboardEarnings.Name = "labelDashboardEarnings";
            this.labelDashboardEarnings.Size = new System.Drawing.Size(123, 20);
            this.labelDashboardEarnings.TabIndex = 1;
            this.labelDashboardEarnings.Text = "Monthly Earnings";
            this.labelDashboardEarnings.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 27);
            this.textBox2.TabIndex = 2;
            // 
            // labelDashboardSpendings
            // 
            this.labelDashboardSpendings.AutoSize = true;
            this.labelDashboardSpendings.Location = new System.Drawing.Point(61, 151);
            this.labelDashboardSpendings.Name = "labelDashboardSpendings";
            this.labelDashboardSpendings.Size = new System.Drawing.Size(78, 20);
            this.labelDashboardSpendings.TabIndex = 3;
            this.labelDashboardSpendings.Text = "Spendings";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDashboardSpendings);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelDashboardEarnings);
            this.Controls.Add(this.textBox1);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDashboardEarnings;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelDashboardSpendings;
    }
}