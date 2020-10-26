namespace Stonks.Forms
{
    partial class Settings
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
            this.modeToggleBtn = new MetroFramework.Controls.MetroToggle();
            this.labelMode = new System.Windows.Forms.Label();
            this.dataMeasure = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveInfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modeToggleBtn
            // 
            this.modeToggleBtn.AccessibleName = "";
            this.modeToggleBtn.AutoSize = true;
            this.modeToggleBtn.CustomBackground = false;
            this.modeToggleBtn.DisplayStatus = false;
            this.modeToggleBtn.FontSize = MetroFramework.MetroLinkSize.Small;
            this.modeToggleBtn.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.modeToggleBtn.Location = new System.Drawing.Point(609, 115);
            this.modeToggleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modeToggleBtn.Name = "modeToggleBtn";
            this.modeToggleBtn.Size = new System.Drawing.Size(50, 17);
            this.modeToggleBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.modeToggleBtn.StyleManager = null;
            this.modeToggleBtn.TabIndex = 0;
            this.modeToggleBtn.Tag = "";
            this.modeToggleBtn.Text = "~StatusOff";
            this.modeToggleBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.modeToggleBtn.UseStyleColors = false;
            this.modeToggleBtn.UseVisualStyleBackColor = true;
            this.modeToggleBtn.CheckedChanged += new System.EventHandler(this.modeToggleBtn_CheckedChanged);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMode.Location = new System.Drawing.Point(503, 118);
            this.labelMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(96, 13);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Toggle Light Mode";
            this.labelMode.Click += new System.EventHandler(this.labelMode_Click);
            // 
            // dataMeasure
            // 
            this.dataMeasure.FormattingEnabled = true;
            this.dataMeasure.Items.AddRange(new object[] {
            "Months",
            "Years"});
            this.dataMeasure.Location = new System.Drawing.Point(128, 118);
            this.dataMeasure.Name = "dataMeasure";
            this.dataMeasure.Size = new System.Drawing.Size(121, 21);
            this.dataMeasure.TabIndex = 2;
            this.dataMeasure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(124, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Measure data in:";
            // 
            // saveInfoBtn
            // 
            this.saveInfoBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.saveInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveInfoBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveInfoBtn.FlatAppearance.BorderSize = 0;
            this.saveInfoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveInfoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveInfoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.saveInfoBtn.ForeColor = System.Drawing.Color.White;
            this.saveInfoBtn.Location = new System.Drawing.Point(332, 301);
            this.saveInfoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveInfoBtn.Name = "saveInfoBtn";
            this.saveInfoBtn.Size = new System.Drawing.Size(98, 34);
            this.saveInfoBtn.TabIndex = 6;
            this.saveInfoBtn.Text = "Save Info";
            this.saveInfoBtn.UseVisualStyleBackColor = false;
            this.saveInfoBtn.Click += new System.EventHandler(this.saveInfoBtn_Click);
            // 
            // Settings
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(749, 448);
            this.Controls.Add(this.saveInfoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataMeasure);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.modeToggleBtn);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Settings";
            this.Tag = "";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle modeToggleBtn;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox dataMeasure;
        private System.Windows.Forms.Button saveInfoBtn;
    }
}