using System;
using System.Windows.Forms;

namespace Stonks.Forms
{
    public partial class FormSmartSaver : Form
    {
        public FormSmartSaver()
        {
            InitializeComponent();
            Program.financialPlan.Savings = Program.financialPlan.Income - Program.financialPlan.GetSpendings();
            this.Text = "Smart Saver";
            setTrackBarValues();
            labelStop.Visible = false;
            InitializeUI.loadGoals(btnAddGoal, buttondelete, labelStop, this);
            InitializeUI.LoadCurrentDate(labelDate);
        }

        private void FormSmartSaver_Load(object sender, EventArgs e)
        {
        }

        public void setTrackBarValues()
        {
            var income = Program.financialPlan.Income;
            var housingExpense = Program.financialPlan.GetExpense(ExpenseType.Housing);
            var groceries = Program.financialPlan.GetExpense(ExpenseType.Groceries);
            var transportExpense = Program.financialPlan.GetExpense(ExpenseType.Transport);
            var entertainmentExpense = Program.financialPlan.GetExpense(ExpenseType.Entertainment);
            var healthExpense = Program.financialPlan.GetExpense(ExpenseType.Health);
            var shoppingExpense = Program.financialPlan.GetExpense(ExpenseType.Shopping);
            var utilitiesExpense = Program.financialPlan.GetExpense(ExpenseType.Utilities);
            var otherExpense = Program.financialPlan.GetExpense(ExpenseType.Other);
            var savings = Program.financialPlan.Savings;
            var max = Program.financialPlan.GetMaxExpense();


            InitializeUI.LoadTrackBars(housingExpense, trackBarHousing, labelHousingExpense, labelHousingExpensesActual, max);
            InitializeUI.LoadTrackBars(groceries, trackBarGroceries, labelGroceriesExpense, labelGroceriesExpensesActual, max);
            InitializeUI.LoadTrackBars(entertainmentExpense, trackBarEntertainment, labelEntertainmentExpense, labelEntertainmentExpensesActual, max);
            InitializeUI.LoadTrackBars(transportExpense, trackBarTransport, labelTransportExpense, labelTransportExpensesActual, max);
            InitializeUI.LoadTrackBars(healthExpense, trackBarHealth, labelHealthExpense, labelHealthExpensesActual, max);
            InitializeUI.LoadTrackBars(shoppingExpense, trackBarShopping, labelShoppingExpense, labelShoppingExpensesActual, max);
            InitializeUI.LoadTrackBars(utilitiesExpense, trackBarUtilities, labelUtilitiesExpense, labelUtilitiesExpensesActual, max);
            InitializeUI.LoadTrackBars(otherExpense, trackBarOther, labelOtherExpense, labelOtherExpensesActual, max);

            try
            {
                trackBarSavings.Minimum = Convert.ToInt32(income * (-1));
                trackBarSavings.Maximum = Convert.ToInt32(income);
                trackBarSavings.Value = Convert.ToInt32(savings);
                labelPlannedSavings.Text = (Program.financialPlan.GetPlannedSavings()).ToString("€#.#");
                labelSavings.Text = (savings).ToString("€#.#");
            }
            catch
            {
                trackBarSavings.Value = 0;
                labelSavings.Text = (savings).ToString("€#.#");
            }


        }

        private void trackBarHousing_ValueChange(object sender, EventArgs e)
        {

        }

        private void trackBarHousing_Scroll(object sender, EventArgs e)
        {
            InitializeUI.SavePlannedValues(labelHousingExpense, trackBarHousing, ExpenseType.Housing);
            InitializeUI.UpdatePlannedSavings(labelPlannedSavings);
        }

        private void trackBarGroceries_Scroll(object sender, EventArgs e)
        {
            InitializeUI.SavePlannedValues(labelGroceriesExpense, trackBarGroceries, ExpenseType.Groceries);
            InitializeUI.UpdatePlannedSavings(labelPlannedSavings);
        }

        private void trackBarTransport_Scroll(object sender, EventArgs e)
        {
            InitializeUI.SavePlannedValues(labelTransportExpense, trackBarTransport, ExpenseType.Transport);
            InitializeUI.UpdatePlannedSavings(labelPlannedSavings);
        }

        private void trackBarEntertainment_Scroll(object sender, EventArgs e)
        {
            InitializeUI.SavePlannedValues(labelEntertainmentExpense, trackBarEntertainment, ExpenseType.Entertainment);
            InitializeUI.UpdatePlannedSavings(labelPlannedSavings);
        }

        private void trackBarHealth_Scroll(object sender, EventArgs e)
        {
            InitializeUI.SavePlannedValues(labelHealthExpense, trackBarHealth, ExpenseType.Health);
            InitializeUI.UpdatePlannedSavings(labelPlannedSavings);
        }

        private void trackBarShopping_Scroll(object sender, EventArgs e)
        {
            InitializeUI.SavePlannedValues(labelShoppingExpense, trackBarShopping, ExpenseType.Shopping);
            InitializeUI.UpdatePlannedSavings(labelPlannedSavings);
        }

        private void trackBarUtilities_Scroll(object sender, EventArgs e)
        {
            InitializeUI.SavePlannedValues(labelUtilitiesExpense, trackBarUtilities, ExpenseType.Utilities);
            InitializeUI.UpdatePlannedSavings(labelPlannedSavings);
        }

        private void trackBarOther_Scroll(object sender, EventArgs e)
        {
            InitializeUI.SavePlannedValues(labelOtherExpense, trackBarOther, ExpenseType.Other);
            InitializeUI.UpdatePlannedSavings(labelPlannedSavings);
        }

        private void trackBarSavings_Scroll(object sender, EventArgs e)
        {
            var value = trackBarSavings.Value;
            labelSavings.Text = (value).ToString("€#.#");
            InitializeUI.UpdatePlannedSavings(labelPlannedSavings);
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            int lengthGoals = InitializeUI.GetGoalLength();
            AddGoalForm dialog = new AddGoalForm();
            dialog.ShowDialog();
            String goalName = dialog.TextBoxGoal;
            String goal = dialog.textBoxGoalPrice;
            Int32 type = dialog.comboBoxGoalType;

            InitializeUI.AddNewGoal(btnAddGoal, buttondelete, labelStop, lengthGoals, goalName, goal, type, this);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            FormDeleteGoal dialog = new FormDeleteGoal();
            dialog.ShowDialog();
            int goalToDelete = dialog.comboBox1.SelectedIndex;
            int i = 0;

            foreach (FinancialGoal goal in Program.financialPlan.FinancialGoals)
            {
                if (i == goalToDelete)
                {
                    Program.financialPlan.RemoveFinancialGoal(goal);
                    break;
                }
                i++;
            }

            this.Controls.Clear();
            this.InitializeComponent();
            Program.financialPlan.Savings = Program.financialPlan.Income - Program.financialPlan.GetSpendings();
            setTrackBarValues();
            labelStop.Visible = false;
            InitializeUI.loadGoals(btnAddGoal, buttondelete, labelStop, this);
        }

        private void iconHousing_MouseHover(object sender, EventArgs e)
        {
            iconName.Show("Housing", iconHousing);
        }

        private void iconGroceries_MouseHover(object sender, EventArgs e)
        {
            iconName.Show("Groceries", iconGroceries);
        }

        private void iconTransport_MouseHover(object sender, EventArgs e)
        {
            iconName.Show("Transport", iconTransport);
        }

        private void iconEntertainment_MouseHover(object sender, EventArgs e)
        {
            iconName.Show("Entertainment", iconEntertainment);
        }

        private void iconHealth_MouseHover(object sender, EventArgs e)
        {
            iconName.Show("Health", iconHealth);
        }

        private void iconShopping_MouseHover(object sender, EventArgs e)
        {
            iconName.Show("Shopping", iconShopping);
        }

        private void iconUtilities_MouseHover(object sender, EventArgs e)
        {
            iconName.Show("Utilities", iconUtilities);
        }

        private void iconOther_MouseHover(object sender, EventArgs e)
        {
            iconName.Show("Other", iconOther);
        }

        private void iconPictureBox1_MouseHover(object sender, EventArgs e)
        {
            iconName.Show("Piggy bank", iconPictureBox1);
        }
    }
}
