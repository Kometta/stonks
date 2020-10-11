namespace Stonks.Forms
{
    partial class Account
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
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelUserDataName = new System.Windows.Forms.Label();
            this.labelUserDataLast = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveInfoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.White;
            this.iconUser.IconSize = 67;
            this.iconUser.Location = new System.Drawing.Point(399, 74);
            this.iconUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(98, 67);
            this.iconUser.TabIndex = 0;
            this.iconUser.TabStop = false;
            this.iconUser.Click += new System.EventHandler(this.iconUser_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 190);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(549, 190);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 22);
            this.textBox2.TabIndex = 2;
            // 
            // labelUserDataName
            // 
            this.labelUserDataName.AutoSize = true;
            this.labelUserDataName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelUserDataName.ForeColor = System.Drawing.Color.White;
            this.labelUserDataName.Location = new System.Drawing.Point(164, 172);
            this.labelUserDataName.Name = "labelUserDataName";
            this.labelUserDataName.Size = new System.Drawing.Size(92, 20);
            this.labelUserDataName.TabIndex = 3;
            this.labelUserDataName.Text = "First Name";
            // 
            // labelUserDataLast
            // 
            this.labelUserDataLast.AutoSize = true;
            this.labelUserDataLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelUserDataLast.ForeColor = System.Drawing.Color.White;
            this.labelUserDataLast.Location = new System.Drawing.Point(549, 172);
            this.labelUserDataLast.Name = "labelUserDataLast";
            this.labelUserDataLast.Size = new System.Drawing.Size(91, 20);
            this.labelUserDataLast.TabIndex = 3;
            this.labelUserDataLast.Text = "Last Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 278);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(549, 278);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 22);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(549, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bank";
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
            this.saveInfoBtn.Location = new System.Drawing.Point(383, 367);
            this.saveInfoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveInfoBtn.Name = "saveInfoBtn";
            this.saveInfoBtn.Size = new System.Drawing.Size(130, 42);
            this.saveInfoBtn.TabIndex = 5;
            this.saveInfoBtn.Text = "Save Info";
            this.saveInfoBtn.UseVisualStyleBackColor = false;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(944, 495);
            this.Controls.Add(this.saveInfoBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelUserDataLast);
            this.Controls.Add(this.labelUserDataName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iconUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Account";
            this.Text = "FormUserData";
            this.Load += new System.EventHandler(this.FormUserData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelUserDataName;
        private System.Windows.Forms.Label labelUserDataLast;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveInfoBtn;
    }
}