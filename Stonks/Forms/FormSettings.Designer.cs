namespace Stonks.Forms
{
    partial class FormSettings
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
            this.modeToggleBtn.Location = new System.Drawing.Point(697, 76);
            this.modeToggleBtn.Name = "modeToggleBtn";
            this.modeToggleBtn.Size = new System.Drawing.Size(50, 24);
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
            this.labelMode.Location = new System.Drawing.Point(556, 80);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(135, 20);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Toggle Light Mode";
            this.labelMode.Click += new System.EventHandler(this.labelMode_Click);
            // 
            // FormSettings
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.modeToggleBtn);
            this.Name = "FormSettings";
            this.Tag = "";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle modeToggleBtn;
        private System.Windows.Forms.Label labelMode;
    }
}