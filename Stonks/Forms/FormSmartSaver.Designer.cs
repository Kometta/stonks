namespace Stonks.Forms
{
    partial class FormSmartSaver
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
            this.labelSpendingsSlider = new System.Windows.Forms.Label();
            this.trackBarHousing = new System.Windows.Forms.TrackBar();
            this.trackBarGroceries = new System.Windows.Forms.TrackBar();
            this.trackBarTransport = new System.Windows.Forms.TrackBar();
            this.trackBarEntertainment = new System.Windows.Forms.TrackBar();
            this.trackBarHealth = new System.Windows.Forms.TrackBar();
            this.trackBarShopping = new System.Windows.Forms.TrackBar();
            this.trackBarUtilities = new System.Windows.Forms.TrackBar();
            this.iconHousing = new FontAwesome.Sharp.IconPictureBox();
            this.iconGroceries = new FontAwesome.Sharp.IconPictureBox();
            this.iconTransport = new FontAwesome.Sharp.IconPictureBox();
            this.iconEntertainment = new FontAwesome.Sharp.IconPictureBox();
            this.iconHealth = new FontAwesome.Sharp.IconPictureBox();
            this.iconShopping = new FontAwesome.Sharp.IconPictureBox();
            this.iconUtilities = new FontAwesome.Sharp.IconPictureBox();
            this.iconOther = new FontAwesome.Sharp.IconPictureBox();
            this.trackBarOther = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.trackBarSavings = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddGoal = new System.Windows.Forms.Button();
            this.labelHousingExpense = new System.Windows.Forms.Label();
            this.labelGroceriesExpense = new System.Windows.Forms.Label();
            this.labelTransportExpense = new System.Windows.Forms.Label();
            this.labelEntertainmentExpense = new System.Windows.Forms.Label();
            this.labelHealthExpense = new System.Windows.Forms.Label();
            this.labelShoppingExpense = new System.Windows.Forms.Label();
            this.labelUtilitiesExpense = new System.Windows.Forms.Label();
            this.labelOtherExpense = new System.Windows.Forms.Label();
            this.labelSavings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHousing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGroceries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEntertainment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUtilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHousing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGroceries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEntertainment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconShopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUtilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSavings)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSpendingsSlider
            // 
            this.labelSpendingsSlider.AutoSize = true;
            this.labelSpendingsSlider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSpendingsSlider.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSpendingsSlider.Location = new System.Drawing.Point(95, 24);
            this.labelSpendingsSlider.Name = "labelSpendingsSlider";
            this.labelSpendingsSlider.Size = new System.Drawing.Size(114, 28);
            this.labelSpendingsSlider.TabIndex = 0;
            this.labelSpendingsSlider.Text = "Spendings:";
            // 
            // trackBarHousing
            // 
            this.trackBarHousing.Location = new System.Drawing.Point(110, 65);
            this.trackBarHousing.Maximum = 100;
            this.trackBarHousing.Name = "trackBarHousing";
            this.trackBarHousing.Size = new System.Drawing.Size(155, 56);
            this.trackBarHousing.TabIndex = 2;
            this.trackBarHousing.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarHousing.ValueChanged += new System.EventHandler(this.FormSmartSaver_Load);
            // 
            // trackBarGroceries
            // 
            this.trackBarGroceries.Location = new System.Drawing.Point(110, 130);
            this.trackBarGroceries.Maximum = 100;
            this.trackBarGroceries.Name = "trackBarGroceries";
            this.trackBarGroceries.Size = new System.Drawing.Size(155, 56);
            this.trackBarGroceries.TabIndex = 2;
            this.trackBarGroceries.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarTransport
            // 
            this.trackBarTransport.Location = new System.Drawing.Point(110, 202);
            this.trackBarTransport.Maximum = 100;
            this.trackBarTransport.Name = "trackBarTransport";
            this.trackBarTransport.Size = new System.Drawing.Size(155, 56);
            this.trackBarTransport.TabIndex = 2;
            this.trackBarTransport.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarEntertainment
            // 
            this.trackBarEntertainment.Location = new System.Drawing.Point(110, 264);
            this.trackBarEntertainment.Maximum = 100;
            this.trackBarEntertainment.Name = "trackBarEntertainment";
            this.trackBarEntertainment.Size = new System.Drawing.Size(155, 56);
            this.trackBarEntertainment.TabIndex = 2;
            this.trackBarEntertainment.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarHealth
            // 
            this.trackBarHealth.Location = new System.Drawing.Point(110, 325);
            this.trackBarHealth.Maximum = 100;
            this.trackBarHealth.Name = "trackBarHealth";
            this.trackBarHealth.Size = new System.Drawing.Size(155, 56);
            this.trackBarHealth.TabIndex = 2;
            this.trackBarHealth.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarShopping
            // 
            this.trackBarShopping.Location = new System.Drawing.Point(110, 387);
            this.trackBarShopping.Maximum = 100;
            this.trackBarShopping.Name = "trackBarShopping";
            this.trackBarShopping.Size = new System.Drawing.Size(155, 56);
            this.trackBarShopping.TabIndex = 2;
            this.trackBarShopping.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarUtilities
            // 
            this.trackBarUtilities.Location = new System.Drawing.Point(110, 459);
            this.trackBarUtilities.Maximum = 100;
            this.trackBarUtilities.Name = "trackBarUtilities";
            this.trackBarUtilities.Size = new System.Drawing.Size(155, 56);
            this.trackBarUtilities.TabIndex = 2;
            this.trackBarUtilities.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // iconHousing
            // 
            this.iconHousing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconHousing.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconHousing.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconHousing.IconColor = System.Drawing.Color.Gainsboro;
            this.iconHousing.IconSize = 40;
            this.iconHousing.Location = new System.Drawing.Point(64, 65);
            this.iconHousing.Name = "iconHousing";
            this.iconHousing.Size = new System.Drawing.Size(40, 40);
            this.iconHousing.TabIndex = 3;
            this.iconHousing.TabStop = false;
            // 
            // iconGroceries
            // 
            this.iconGroceries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconGroceries.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconGroceries.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.iconGroceries.IconColor = System.Drawing.Color.Gainsboro;
            this.iconGroceries.IconSize = 40;
            this.iconGroceries.Location = new System.Drawing.Point(64, 130);
            this.iconGroceries.Name = "iconGroceries";
            this.iconGroceries.Size = new System.Drawing.Size(40, 40);
            this.iconGroceries.TabIndex = 3;
            this.iconGroceries.TabStop = false;
            // 
            // iconTransport
            // 
            this.iconTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconTransport.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconTransport.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconTransport.IconColor = System.Drawing.Color.Gainsboro;
            this.iconTransport.IconSize = 40;
            this.iconTransport.Location = new System.Drawing.Point(64, 202);
            this.iconTransport.Name = "iconTransport";
            this.iconTransport.Size = new System.Drawing.Size(40, 40);
            this.iconTransport.TabIndex = 3;
            this.iconTransport.TabStop = false;
            // 
            // iconEntertainment
            // 
            this.iconEntertainment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconEntertainment.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconEntertainment.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.iconEntertainment.IconColor = System.Drawing.Color.Gainsboro;
            this.iconEntertainment.IconSize = 40;
            this.iconEntertainment.Location = new System.Drawing.Point(64, 260);
            this.iconEntertainment.Name = "iconEntertainment";
            this.iconEntertainment.Size = new System.Drawing.Size(40, 40);
            this.iconEntertainment.TabIndex = 3;
            this.iconEntertainment.TabStop = false;
            // 
            // iconHealth
            // 
            this.iconHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconHealth.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconHealth.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.iconHealth.IconColor = System.Drawing.Color.Gainsboro;
            this.iconHealth.IconSize = 40;
            this.iconHealth.Location = new System.Drawing.Point(64, 325);
            this.iconHealth.Name = "iconHealth";
            this.iconHealth.Size = new System.Drawing.Size(40, 40);
            this.iconHealth.TabIndex = 3;
            this.iconHealth.TabStop = false;
            // 
            // iconShopping
            // 
            this.iconShopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconShopping.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconShopping.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.iconShopping.IconColor = System.Drawing.Color.Gainsboro;
            this.iconShopping.IconSize = 40;
            this.iconShopping.Location = new System.Drawing.Point(64, 387);
            this.iconShopping.Name = "iconShopping";
            this.iconShopping.Size = new System.Drawing.Size(40, 40);
            this.iconShopping.TabIndex = 3;
            this.iconShopping.TabStop = false;
            // 
            // iconUtilities
            // 
            this.iconUtilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconUtilities.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconUtilities.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iconUtilities.IconColor = System.Drawing.Color.Gainsboro;
            this.iconUtilities.IconSize = 40;
            this.iconUtilities.Location = new System.Drawing.Point(64, 459);
            this.iconUtilities.Name = "iconUtilities";
            this.iconUtilities.Size = new System.Drawing.Size(40, 40);
            this.iconUtilities.TabIndex = 3;
            this.iconUtilities.TabStop = false;
            // 
            // iconOther
            // 
            this.iconOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconOther.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconOther.IconChar = FontAwesome.Sharp.IconChar.FolderMinus;
            this.iconOther.IconColor = System.Drawing.Color.Gainsboro;
            this.iconOther.IconSize = 40;
            this.iconOther.Location = new System.Drawing.Point(64, 521);
            this.iconOther.Name = "iconOther";
            this.iconOther.Size = new System.Drawing.Size(40, 40);
            this.iconOther.TabIndex = 3;
            this.iconOther.TabStop = false;
            // 
            // trackBarOther
            // 
            this.trackBarOther.Location = new System.Drawing.Point(110, 521);
            this.trackBarOther.Maximum = 100;
            this.trackBarOther.Name = "trackBarOther";
            this.trackBarOther.Size = new System.Drawing.Size(155, 56);
            this.trackBarOther.TabIndex = 2;
            this.trackBarOther.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(603, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Savings:";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconSize = 56;
            this.iconPictureBox1.Location = new System.Drawing.Point(537, 76);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(60, 56);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // trackBarSavings
            // 
            this.trackBarSavings.Location = new System.Drawing.Point(603, 86);
            this.trackBarSavings.Maximum = 100;
            this.trackBarSavings.Name = "trackBarSavings";
            this.trackBarSavings.Size = new System.Drawing.Size(155, 56);
            this.trackBarSavings.TabIndex = 2;
            this.trackBarSavings.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(623, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Goals:";
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.BackColor = System.Drawing.Color.Orange;
            this.btnAddGoal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddGoal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddGoal.Location = new System.Drawing.Point(587, 199);
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.Size = new System.Drawing.Size(145, 43);
            this.btnAddGoal.TabIndex = 5;
            this.btnAddGoal.Text = "Add A Goal";
            this.btnAddGoal.UseVisualStyleBackColor = false;
            // 
            // labelHousingExpense
            // 
            this.labelHousingExpense.AutoSize = true;
            this.labelHousingExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHousingExpense.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHousingExpense.Location = new System.Drawing.Point(262, 65);
            this.labelHousingExpense.Name = "labelHousingExpense";
            this.labelHousingExpense.Size = new System.Drawing.Size(45, 23);
            this.labelHousingExpense.TabIndex = 6;
            this.labelHousingExpense.Text = "0.00";
            // 
            // labelGroceriesExpense
            // 
            this.labelGroceriesExpense.AutoSize = true;
            this.labelGroceriesExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGroceriesExpense.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelGroceriesExpense.Location = new System.Drawing.Point(262, 130);
            this.labelGroceriesExpense.Name = "labelGroceriesExpense";
            this.labelGroceriesExpense.Size = new System.Drawing.Size(45, 23);
            this.labelGroceriesExpense.TabIndex = 6;
            this.labelGroceriesExpense.Text = "0.00";
            // 
            // labelTransportExpense
            // 
            this.labelTransportExpense.AutoSize = true;
            this.labelTransportExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransportExpense.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTransportExpense.Location = new System.Drawing.Point(262, 202);
            this.labelTransportExpense.Name = "labelTransportExpense";
            this.labelTransportExpense.Size = new System.Drawing.Size(45, 23);
            this.labelTransportExpense.TabIndex = 6;
            this.labelTransportExpense.Text = "0.00";
            // 
            // labelEntertainmentExpense
            // 
            this.labelEntertainmentExpense.AutoSize = true;
            this.labelEntertainmentExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEntertainmentExpense.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelEntertainmentExpense.Location = new System.Drawing.Point(262, 264);
            this.labelEntertainmentExpense.Name = "labelEntertainmentExpense";
            this.labelEntertainmentExpense.Size = new System.Drawing.Size(45, 23);
            this.labelEntertainmentExpense.TabIndex = 6;
            this.labelEntertainmentExpense.Text = "0.00";
            // 
            // labelHealthExpense
            // 
            this.labelHealthExpense.AutoSize = true;
            this.labelHealthExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHealthExpense.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHealthExpense.Location = new System.Drawing.Point(262, 325);
            this.labelHealthExpense.Name = "labelHealthExpense";
            this.labelHealthExpense.Size = new System.Drawing.Size(45, 23);
            this.labelHealthExpense.TabIndex = 6;
            this.labelHealthExpense.Text = "0.00";
            // 
            // labelShoppingExpense
            // 
            this.labelShoppingExpense.AutoSize = true;
            this.labelShoppingExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelShoppingExpense.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelShoppingExpense.Location = new System.Drawing.Point(262, 387);
            this.labelShoppingExpense.Name = "labelShoppingExpense";
            this.labelShoppingExpense.Size = new System.Drawing.Size(45, 23);
            this.labelShoppingExpense.TabIndex = 6;
            this.labelShoppingExpense.Text = "0.00";
            // 
            // labelUtilitiesExpense
            // 
            this.labelUtilitiesExpense.AutoSize = true;
            this.labelUtilitiesExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUtilitiesExpense.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUtilitiesExpense.Location = new System.Drawing.Point(262, 459);
            this.labelUtilitiesExpense.Name = "labelUtilitiesExpense";
            this.labelUtilitiesExpense.Size = new System.Drawing.Size(45, 23);
            this.labelUtilitiesExpense.TabIndex = 6;
            this.labelUtilitiesExpense.Text = "0.00";
            // 
            // labelOtherExpense
            // 
            this.labelOtherExpense.AutoSize = true;
            this.labelOtherExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOtherExpense.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelOtherExpense.Location = new System.Drawing.Point(262, 521);
            this.labelOtherExpense.Name = "labelOtherExpense";
            this.labelOtherExpense.Size = new System.Drawing.Size(45, 23);
            this.labelOtherExpense.TabIndex = 6;
            this.labelOtherExpense.Text = "0.00";
            // 
            // labelSavings
            // 
            this.labelSavings.AutoSize = true;
            this.labelSavings.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSavings.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSavings.Location = new System.Drawing.Point(754, 86);
            this.labelSavings.Name = "labelSavings";
            this.labelSavings.Size = new System.Drawing.Size(45, 23);
            this.labelSavings.TabIndex = 6;
            this.labelSavings.Text = "0.00";
            // 
            // FormSmartSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(939, 604);
            this.Controls.Add(this.labelSavings);
            this.Controls.Add(this.labelOtherExpense);
            this.Controls.Add(this.labelUtilitiesExpense);
            this.Controls.Add(this.labelShoppingExpense);
            this.Controls.Add(this.labelHealthExpense);
            this.Controls.Add(this.labelEntertainmentExpense);
            this.Controls.Add(this.labelTransportExpense);
            this.Controls.Add(this.labelGroceriesExpense);
            this.Controls.Add(this.labelHousingExpense);
            this.Controls.Add(this.btnAddGoal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarSavings);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarOther);
            this.Controls.Add(this.iconOther);
            this.Controls.Add(this.iconUtilities);
            this.Controls.Add(this.iconShopping);
            this.Controls.Add(this.iconHealth);
            this.Controls.Add(this.iconEntertainment);
            this.Controls.Add(this.iconTransport);
            this.Controls.Add(this.iconGroceries);
            this.Controls.Add(this.iconHousing);
            this.Controls.Add(this.trackBarUtilities);
            this.Controls.Add(this.trackBarShopping);
            this.Controls.Add(this.trackBarHealth);
            this.Controls.Add(this.trackBarEntertainment);
            this.Controls.Add(this.trackBarTransport);
            this.Controls.Add(this.trackBarGroceries);
            this.Controls.Add(this.trackBarHousing);
            this.Controls.Add(this.labelSpendingsSlider);
            this.Name = "FormSmartSaver";
            this.Text = "FormSmartSaver";
            this.Load += new System.EventHandler(this.FormSmartSaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHousing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGroceries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEntertainment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUtilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHousing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGroceries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEntertainment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconShopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUtilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSavings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpendingsSlider;
        private System.Windows.Forms.TrackBar trackBarHousing;
        private System.Windows.Forms.TrackBar trackBarGroceries;
        private System.Windows.Forms.TrackBar trackBarTransport;
        private System.Windows.Forms.TrackBar trackBarEntertainment;
        private System.Windows.Forms.TrackBar trackBarHealth;
        private System.Windows.Forms.TrackBar trackBarShopping;
        private System.Windows.Forms.TrackBar trackBarUtilities;
        private FontAwesome.Sharp.IconPictureBox iconHousing;
        private FontAwesome.Sharp.IconPictureBox iconGroceries;
        private FontAwesome.Sharp.IconPictureBox iconTransport;
        private FontAwesome.Sharp.IconPictureBox iconEntertainment;
        private FontAwesome.Sharp.IconPictureBox iconHealth;
        private FontAwesome.Sharp.IconPictureBox iconShopping;
        private FontAwesome.Sharp.IconPictureBox iconUtilities;
        private FontAwesome.Sharp.IconPictureBox iconOther;
        private System.Windows.Forms.TrackBar trackBarOther;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TrackBar trackBarSavings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddGoal;
        private System.Windows.Forms.Label labelHousingExpense;
        private System.Windows.Forms.Label labelGroceriesExpense;
        private System.Windows.Forms.Label labelTransportExpense;
        private System.Windows.Forms.Label labelEntertainmentExpense;
        private System.Windows.Forms.Label labelHealthExpense;
        private System.Windows.Forms.Label labelShoppingExpense;
        private System.Windows.Forms.Label labelUtilitiesExpense;
        private System.Windows.Forms.Label labelOtherExpense;
        private System.Windows.Forms.Label labelSavings;
    }
}