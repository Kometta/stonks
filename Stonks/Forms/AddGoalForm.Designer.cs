namespace Stonks.Forms
{
    partial class AddGoalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGoalForm));
            this.labelAddYourGoal = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxGoalName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddYourGoal
            // 
            this.labelAddYourGoal.AutoSize = true;
            this.labelAddYourGoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddYourGoal.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAddYourGoal.Location = new System.Drawing.Point(131, 9);
            this.labelAddYourGoal.Name = "labelAddYourGoal";
            this.labelAddYourGoal.Size = new System.Drawing.Size(203, 28);
            this.labelAddYourGoal.TabIndex = 0;
            this.labelAddYourGoal.Text = "Add Your New Goal!";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelType.Location = new System.Drawing.Point(144, 221);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(165, 20);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "What type is your goal?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(118, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is the name of your goal?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(118, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "How much does your goal cost?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBoxGoalName
            // 
            this.textBoxGoalName.Location = new System.Drawing.Point(157, 100);
            this.textBoxGoalName.Name = "textBoxGoalName";
            this.textBoxGoalName.Size = new System.Drawing.Size(152, 27);
            this.textBoxGoalName.TabIndex = 3;
            this.textBoxGoalName.TextChanged += new System.EventHandler(this.textBoxGoalName_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(175, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save Info";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(482, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxGoalName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelAddYourGoal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 420);
            this.MinimumSize = new System.Drawing.Size(500, 420);
            this.Name = "AddGoalForm";
            this.Text = "Add your new goal";
            this.Load += new System.EventHandler(this.AddGoalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddYourGoal;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBoxGoalName;
    }
}