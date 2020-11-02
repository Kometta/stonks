using System;
using System.Windows.Forms;
using Stonks.Forms;

namespace Stonks.Forms
{
    public partial class FormSmartSaver : Form
    {
        int selection = FinancialPlanController.ActivePlan.DisplayData;
        public FormSmartSaver()
        {
            InitializeComponent();
            FinancialPlanController.ActivePlan.Savings = FinancialPlanController.ActivePlan.Income - FinancialPlanController.ActivePlan.GetSpendings();
            this.Text = Resources.LStrings.SmartSaverLabel;
            setTrackBarValues();
            labelStop.Visible = false;
            InitializeUI.loadGoals(btnAddGoal, buttondelete, labelStop, this, selection);
            InitializeUI.LoadCurrentDate(labelDate);
        }

        private void FormSmartSaver_Load(object sender, EventArgs e)
        {
            selection = FinancialPlanController.ActivePlan.DisplayData;
        }

        public void setTrackBarValues()
        {
            var housingExpense = FinancialPlanController.ActivePlan.GetExpense(ExpenseType.Housing);
            var groceries = FinancialPlanController.ActivePlan.GetExpense(ExpenseType.Groceries);
            var transportExpense = FinancialPlanController.ActivePlan.GetExpense(ExpenseType.Transport);
            var entertainmentExpense = FinancialPlanController.ActivePlan.GetExpense(ExpenseType.Entertainment);
            var healthExpense = FinancialPlanController.ActivePlan.GetExpense(ExpenseType.Health);
            var shoppingExpense = FinancialPlanController.ActivePlan.GetExpense(ExpenseType.Shopping);
            var utilitiesExpense = FinancialPlanController.ActivePlan.GetExpense(ExpenseType.Utilities);
            var otherExpense = FinancialPlanController.ActivePlan.GetExpense(ExpenseType.Other);
            var max = FinancialPlanController.ActivePlan.GetMaxExpense() * 2;


            InitializeUI.LoadTrackBars(housingExpense, trackBarHousing, labelHousingExpense, labelHousingExpensesActual, max);
            InitializeUI.LoadTrackBars(groceries, trackBarGroceries, labelGroceriesExpense, labelGroceriesExpensesActual, max);
            InitializeUI.LoadTrackBars(entertainmentExpense, trackBarEntertainment, labelEntertainmentExpense, labelEntertainmentExpensesActual, max);
            InitializeUI.LoadTrackBars(transportExpense, trackBarTransport, labelTransportExpense, labelTransportExpensesActual, max);
            InitializeUI.LoadTrackBars(healthExpense, trackBarHealth, labelHealthExpense, labelHealthExpensesActual, max);
            InitializeUI.LoadTrackBars(shoppingExpense, trackBarShopping, labelShoppingExpense, labelShoppingExpensesActual, max);
            InitializeUI.LoadTrackBars(utilitiesExpense, trackBarUtilities, labelUtilitiesExpense, labelUtilitiesExpensesActual, max);
            InitializeUI.LoadTrackBars(otherExpense, trackBarOther, labelOtherExpense, labelOtherExpensesActual, max);

            InitializeUI.LoadSavingsTrackBar(trackBarSavings, labelPlannedSavings, labelSavings);
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

            InitializeUI.AddNewGoal(btnAddGoal, buttondelete, labelStop, lengthGoals, goalName, goal, type, this, selection);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            FormDeleteGoal dialog = new FormDeleteGoal();
            dialog.ShowDialog();
            int goalToDelete = dialog.comboBox1.SelectedIndex;

            InitializeUI.RemoveGoalVisuals(goalToDelete);

            this.Controls.Clear();
            this.InitializeComponent();
            FinancialPlanController.ActivePlan.Savings = FinancialPlanController.ActivePlan.Income - FinancialPlanController.ActivePlan.GetSpendings();
            setTrackBarValues();
            labelStop.Visible = false;
            InitializeUI.loadGoals(btnAddGoal, buttondelete, labelStop, this, selection);
        }

        private void iconHousing_MouseHover(object sender, EventArgs e)
        {
            iconName.Show(ExpenseType.Housing.ToString(), iconHousing);
        }

        private void iconGroceries_MouseHover(object sender, EventArgs e)
        {
            iconName.Show(ExpenseType.Groceries.ToString(), iconGroceries);
        }

        private void iconTransport_MouseHover(object sender, EventArgs e)
        {
            iconName.Show(ExpenseType.Transport.ToString(), iconTransport);
        }

        private void iconEntertainment_MouseHover(object sender, EventArgs e)
        {
            iconName.Show(ExpenseType.Entertainment.ToString(), iconEntertainment);
        }

        private void iconHealth_MouseHover(object sender, EventArgs e)
        {
            iconName.Show(ExpenseType.Health.ToString(), iconHealth);
        }

        private void iconShopping_MouseHover(object sender, EventArgs e)
        {
            iconName.Show(ExpenseType.Shopping.ToString(), iconShopping);
        }

        private void iconUtilities_MouseHover(object sender, EventArgs e)
        {
            iconName.Show(ExpenseType.Utilities.ToString(), iconUtilities);
        }

        private void iconOther_MouseHover(object sender, EventArgs e)
        {
            iconName.Show(ExpenseType.Other.ToString(), iconOther);
        }

        private void iconPictureBox1_MouseHover(object sender, EventArgs e)
        {
            iconName.Show("Piggy bank", iconPictureBox1);
        }
    }
}
