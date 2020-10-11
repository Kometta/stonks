using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

            //Setting the values to represent the track bars
            if (housingExpense != null) {
                trackBarHousing.Maximum = Convert.ToInt32(max);
                trackBarHousing.Value = Convert.ToInt32(housingExpense.PlannedValue); //Fix if value becomes higher than expense(just like savings?)
                labelHousingExpense.Text = (housingExpense.PlannedValue).ToString("€#.#");
                labelHousingExpensesActual.Text = (housingExpense.Value).ToString("€#.#");
            }
            else
            {
                trackBarHousing.Value = 0;
            }

            if (groceries != null)
            {
                trackBarGroceries.Maximum = Convert.ToInt32(max);
                trackBarGroceries.Value = Convert.ToInt32(groceries.PlannedValue);
                labelGroceriesExpense.Text = (groceries.PlannedValue).ToString("€#.#");
                labelGroceriesExpensesActual.Text = (groceries.Value).ToString("€#.#");

            }
            else
            {
                trackBarGroceries.Value = 0;
            }
            if (entertainmentExpense != null)
            {
                trackBarEntertainment.Maximum = Convert.ToInt32(max);
                trackBarEntertainment.Value = Convert.ToInt32(entertainmentExpense.PlannedValue);
                labelEntertainmentExpense.Text = (entertainmentExpense.PlannedValue).ToString("€#.#");
                labelEntertainmentExpensesActual.Text = (entertainmentExpense.Value).ToString("€#.#");
            }
            else
            {
                trackBarEntertainment.Value = 0;
            }
            if (transportExpense != null)
            {
                trackBarTransport.Maximum = Convert.ToInt32(max);
                trackBarTransport.Value = Convert.ToInt32(transportExpense.PlannedValue);
                labelTransportExpense.Text = (transportExpense.PlannedValue).ToString("€#.#");
                labelTransportExpensesActual.Text = (transportExpense.Value).ToString("€#.#");

            }
            else
            {
                trackBarTransport.Value = 0;
            }
            if (healthExpense != null)
            {
                trackBarHealth.Maximum = Convert.ToInt32(max);
                trackBarHealth.Value = Convert.ToInt32(healthExpense.PlannedValue);
                labelHealthExpense.Text = (healthExpense.PlannedValue).ToString("€#.#");
                labelHealthExpensesActual.Text = (healthExpense.Value).ToString("€#.#");
            }
            else
            {
                trackBarHealth.Value = 0;
            }
            if (shoppingExpense != null)
            {
                trackBarShopping.Maximum = Convert.ToInt32(max);
                trackBarShopping.Value = Convert.ToInt32(shoppingExpense.PlannedValue);
                labelShoppingExpense.Text = (shoppingExpense.PlannedValue).ToString("€#.#");
                labelShoppingExpensesActual.Text = (shoppingExpense.Value).ToString("€#.#");

            }
            else
            {
                trackBarShopping.Value = 0;
            }
            if (utilitiesExpense != null)
            {
                trackBarUtilities.Maximum = Convert.ToInt32(max);
                trackBarUtilities.Value = Convert.ToInt32(utilitiesExpense.PlannedValue);
                labelUtilitiesExpense.Text = (utilitiesExpense.PlannedValue).ToString("€#.#");
                labelUtilitiesExpensesActual.Text = (utilitiesExpense.Value).ToString("€#.#");
            }
            else
            {
                trackBarUtilities.Value = 0;
            }
            if (otherExpense != null)
            {
                trackBarOther.Maximum = Convert.ToInt32(max);
                trackBarOther.Value = Convert.ToInt32(otherExpense.PlannedValue);
                labelOtherExpense.Text = (otherExpense.PlannedValue).ToString("€#.#");
                labelOtherExpensesActual.Text = (otherExpense.Value).ToString("€#.#");
            }
            else
            {
                trackBarOther.Value = 0;
            }

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
                trackBarSavings.Value = -1000;
                labelSavings.Text = (savings).ToString("€#.#");
            }
            

        }

        private void trackBarHousing_ValueChange(object sender, EventArgs e)
        {

        }

        double savings = Program.financialPlan.Savings;

        //Changing label values depending on the sliders
        private void trackBarHousing_Scroll(object sender, EventArgs e)
        {
            var value = trackBarHousing.Value;
            labelHousingExpense.Text = (value).ToString("€#.#");
            Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Housing, PlannedValue = value, Value = Program.financialPlan.GetExpense(ExpenseType.Housing).Value});
            updatePlannedSavings();
        }

        private void trackBarGroceries_Scroll(object sender, EventArgs e)
        {
            var value = trackBarGroceries.Value;
            labelGroceriesExpense.Text = (value).ToString("€#.#");
            Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Groceries, PlannedValue = value, Value = Program.financialPlan.GetExpense(ExpenseType.Groceries).Value });
            updatePlannedSavings();
        }

        private void trackBarTransport_Scroll(object sender, EventArgs e)
        {
            var value = trackBarTransport.Value;
            labelTransportExpense.Text = (value).ToString("€#.#");
            Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Transport, PlannedValue = value, Value = Program.financialPlan.GetExpense(ExpenseType.Transport).Value });
            updatePlannedSavings();
        }

        private void trackBarEntertainment_Scroll(object sender, EventArgs e)
        {
            var value = trackBarEntertainment.Value;
            labelEntertainmentExpense.Text = (value).ToString("€#.#");
            Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Entertainment, PlannedValue = value, Value = Program.financialPlan.GetExpense(ExpenseType.Entertainment).Value });
            updatePlannedSavings();
        }

        private void trackBarHealth_Scroll(object sender, EventArgs e)
        {
            var value = trackBarHealth.Value;
            labelHealthExpense.Text = (value).ToString("€#.#");
            Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Health, PlannedValue = value, Value = Program.financialPlan.GetExpense(ExpenseType.Health).Value });
            updatePlannedSavings();
        }

        private void trackBarShopping_Scroll(object sender, EventArgs e)
        {
            var value = trackBarShopping.Value;
            labelShoppingExpense.Text = (value).ToString("€#.#");
            Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Shopping, PlannedValue = value, Value = Program.financialPlan.GetExpense(ExpenseType.Shopping).Value });
            updatePlannedSavings();
        }

        private void trackBarUtilities_Scroll(object sender, EventArgs e)
        {
            var value = trackBarUtilities.Value;
            labelUtilitiesExpense.Text = (value).ToString("€#.#");
            Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Utilities, PlannedValue = value, Value = Program.financialPlan.GetExpense(ExpenseType.Utilities).Value });
            updatePlannedSavings();
        }

        private void trackBarOther_Scroll(object sender, EventArgs e)
        {
            var value = trackBarOther.Value;
            labelOtherExpense.Text = (value).ToString("€#.#");
            Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Other, PlannedValue = value, Value = Program.financialPlan.GetExpense(ExpenseType.Other).Value });
            updatePlannedSavings();
        }

        private void trackBarSavings_Scroll(object sender, EventArgs e)
        {
            var value = trackBarSavings.Value;
            labelSavings.Text = (value).ToString("€#.#");
            updatePlannedSavings();
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            AddGoalForm dialog = new AddGoalForm();
            dialog.ShowDialog();
            //TextBox goal = dialog.textBoxGoalName;
            if (btnAddGoal.Top < 500) {
                btnAddGoal.Top += 60;
                //label.Text = goal.Text;
            }
            else
            {
                btnAddGoal.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void updatePlannedSavings() {
            labelPlannedSavings.Text = (Program.financialPlan.GetPlannedSavings()).ToString("€#.#");
        }
    }
}
