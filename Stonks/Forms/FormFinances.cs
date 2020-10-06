using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Stonks.Forms
{
    public partial class MyFinances : Form
    {
        
        public MyFinances()
        {   
            InitializeComponent();
            this.Text = "My Finances";
            loadExpenses();
            
        }

        private void MyFinances_Load(object sender, EventArgs e)
        {

        }

        private void labelUtilities_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveFinances_Click(object sender, EventArgs e)
        {
            saveExpenseValues();
        }

        public void loadExpenses() {
            var housingExpense = Program.financialPlan.GetExpense(ExpenseType.Housing);
            var groceries = Program.financialPlan.GetExpense(ExpenseType.Groceries);
            var transportExpense = Program.financialPlan.GetExpense(ExpenseType.Transport);
            var entertainmentExpense = Program.financialPlan.GetExpense(ExpenseType.Entertainment);
            var healthExpense = Program.financialPlan.GetExpense(ExpenseType.Health);
            var shoppingExpense = Program.financialPlan.GetExpense(ExpenseType.Shopping);
            var utilitiesExpense = Program.financialPlan.GetExpense(ExpenseType.Utilities);
            var otherExpense = Program.financialPlan.GetExpense(ExpenseType.Other);

            //Income
            if (textBoxEarnings == null)
            {
                textBoxEarnings.Text = Convert.ToString(0);
            }
            else
            {
                textBoxEarnings.Text = Convert.ToString(Program.financialPlan.Income);
            }

            //Housing
            if (textBoxHousing == null || housingExpense == null)
            {
                textBoxHousing.Text = "0";
            }
            else
            {
                textBoxHousing.Text = Convert.ToString(housingExpense.Value);
            }

            //Groceries
            if (textBoxFood == null || groceries == null)
            {
                textBoxFood.Text = "0";
            }
            else
            {
                textBoxFood.Text = Convert.ToString(groceries.Value);
            }

            //Transport
            if (textBoxTransport == null || transportExpense == null) {
                textBoxTransport.Text = "0";   
            }
            else
            {
                textBoxTransport.Text = Convert.ToString(transportExpense.Value);
            }

            //Entertainment
            if (textBoxEntertainment == null || entertainmentExpense == null)
            {
                textBoxEntertainment.Text = "0";
            }
            else
            {
                textBoxEntertainment.Text = Convert.ToString(entertainmentExpense.Value);
            }

            //Health
            if (textBoxHealth == null || healthExpense == null)
            {
                textBoxHealth.Text = "0";
            }
            else
            {
                textBoxHealth.Text = Convert.ToString(healthExpense.Value);
            }

            //Shopping
            if (textBoxShopping == null || shoppingExpense == null)
            {
                textBoxShopping.Text = "0";
            }
            else
            {
                textBoxShopping.Text = Convert.ToString(shoppingExpense.Value);
            }

            //Utilities
            if (textBoxUtilities == null || utilitiesExpense == null)
            {
                textBoxUtilities.Text = "0";
            }
            else
            {
                textBoxUtilities.Text = Convert.ToString(utilitiesExpense.Value);
            }

            //Other
            if (textBoxOther == null || otherExpense == null)
            {
                textBoxOther.Text = "0";
            }
            else
            {
                textBoxOther.Text = Convert.ToString(otherExpense.Value);
            }

        }

        public void saveExpenseValues() //Answer the question with team, do we want planned values to be 0 from the start or set to the values of the actual expenses of the user
        {
            //Income
            if (textBoxEarnings.Text != null)
            {
                Program.financialPlan.Income = Convert.ToDouble(textBoxEarnings.Text);
            }

            //Housing
            if (textBoxHousing.Text == null)
            {
                Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Housing, PlannedValue = 0, Value = Convert.ToDouble(textBoxHousing.Text) });
            }
            else if (textBoxHousing.Text != null)
            {
                Program.financialPlan.ModifyExpense(new Expense() { Type = ExpenseType.Housing, PlannedValue = Program.financialPlan.GetExpense(ExpenseType.Housing).PlannedValue, Value = Convert.ToDouble(textBoxHousing.Text) }); //Get Previous PlannedValue
            }

            //Groceries
            if (textBoxFood.Text == null)
            {
                Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Groceries, PlannedValue = 0, Value = Convert.ToDouble(textBoxFood.Text) });
            }
            else if (textBoxFood.Text != null)
            {
                Program.financialPlan.ModifyExpense(new Expense() { Type = ExpenseType.Groceries, PlannedValue = Program.financialPlan.GetExpense(ExpenseType.Groceries).PlannedValue, Value = Convert.ToDouble(textBoxFood.Text) });
            }

            //Transport
            if (textBoxTransport.Text == null)
            {
                Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Transport, PlannedValue = 0, Value = Convert.ToDouble(textBoxTransport.Text) });
            }
            else if (textBoxTransport.Text != null)
            {
                Program.financialPlan.ModifyExpense(new Expense() { Type = ExpenseType.Transport, PlannedValue = Program.financialPlan.GetExpense(ExpenseType.Transport).PlannedValue, Value = Convert.ToDouble(textBoxTransport.Text) });
            }

            //Entertainment
            if (textBoxEntertainment.Text == null)
            {
                Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Entertainment, PlannedValue = 0, Value = Convert.ToDouble(textBoxEntertainment.Text) });
            }
            else if (textBoxEntertainment.Text != null)
            {
                Program.financialPlan.ModifyExpense(new Expense() { Type = ExpenseType.Entertainment, PlannedValue = Program.financialPlan.GetExpense(ExpenseType.Entertainment).PlannedValue, Value = Convert.ToDouble(textBoxEntertainment.Text) });
            }

            //Health
            if (textBoxHealth.Text == null)
            {
                Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Health, PlannedValue = 0, Value = Convert.ToDouble(textBoxHealth.Text) });
            }
            else if (textBoxHealth.Text != null)
            {
                Program.financialPlan.ModifyExpense(new Expense() { Type = ExpenseType.Health, PlannedValue = Program.financialPlan.GetExpense(ExpenseType.Health).PlannedValue, Value = Convert.ToDouble(textBoxHealth.Text) });
            }
            //Shopping
            if (textBoxShopping.Text == null)
            {
                Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Shopping, PlannedValue = 0, Value = Convert.ToDouble(textBoxShopping.Text) });
            }
            else if (textBoxShopping.Text != null)
            {
                Program.financialPlan.ModifyExpense(new Expense() { Type = ExpenseType.Shopping, PlannedValue = Program.financialPlan.GetExpense(ExpenseType.Shopping).PlannedValue, Value = Convert.ToDouble(textBoxShopping.Text) });
            }
            //Utilities
            if (textBoxUtilities.Text == null)
            {
                Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Utilities, PlannedValue = 0, Value = Convert.ToDouble(textBoxUtilities.Text) });
            }
            else if (textBoxUtilities.Text != null)
            {
                Program.financialPlan.ModifyExpense(new Expense() { Type = ExpenseType.Utilities, PlannedValue = Program.financialPlan.GetExpense(ExpenseType.Utilities).PlannedValue, Value = Convert.ToDouble(textBoxUtilities.Text) });
            }

            //Other
            if (textBoxOther.Text == null)
            {
                Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Other, PlannedValue = 0, Value = Convert.ToDouble(textBoxOther.Text) });
            }
            else if (textBoxOther.Text != null)
            {
                Program.financialPlan.ModifyExpense(new Expense() { Type = ExpenseType.Other, PlannedValue = Program.financialPlan.GetExpense(ExpenseType.Other).PlannedValue, Value = Convert.ToDouble(textBoxOther.Text) });
            }
        }
    }
}
