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
                trackBarHousing.Value = Convert.ToInt32(housingExpense.Value);
                labelHousingExpense.Text = (housingExpense.Value).ToString("€#.#");
            }
            else
            {
                trackBarHousing.Value = 0;
            }

            if (groceries != null)
            {
                trackBarGroceries.Maximum = Convert.ToInt32(max);
                trackBarGroceries.Value = Convert.ToInt32(groceries.Value);
                labelGroceriesExpense.Text = (groceries.Value).ToString("€#.#");
            }
            else
            {
                trackBarGroceries.Value = 0;
            }
            if (entertainmentExpense != null)
            {
                trackBarEntertainment.Maximum = Convert.ToInt32(max);
                trackBarEntertainment.Value = Convert.ToInt32(entertainmentExpense.Value);
                labelEntertainmentExpense.Text = (entertainmentExpense.Value).ToString("€#.#");
            }
            else
            {
                trackBarEntertainment.Value = 0;
            }
            if (transportExpense != null)
            {
                trackBarTransport.Maximum = Convert.ToInt32(max);
                trackBarTransport.Value = Convert.ToInt32(transportExpense.Value);
                labelTransportExpense.Text = (transportExpense.Value).ToString("€#.#");

            }
            else
            {
                trackBarTransport.Value = 0;
            }
            if (healthExpense != null)
            {
                trackBarHealth.Maximum = Convert.ToInt32(max);
                trackBarHealth.Value = Convert.ToInt32(healthExpense.Value);
                labelHealthExpense.Text = (healthExpense.Value).ToString("€#.#");
            }
            else
            {
                trackBarHealth.Value = 0;
            }
            if (shoppingExpense != null)
            {
                trackBarShopping.Maximum = Convert.ToInt32(max);
                trackBarShopping.Value = Convert.ToInt32(shoppingExpense.Value);
                labelShoppingExpense.Text = (shoppingExpense.Value).ToString("€#.#");
            }
            else
            {
                trackBarShopping.Value = 0;
            }
            if (utilitiesExpense != null)
            {
                trackBarUtilities.Maximum = Convert.ToInt32(max);
                trackBarUtilities.Value = Convert.ToInt32(utilitiesExpense.Value);
                labelUtilitiesExpense.Text = (utilitiesExpense.Value).ToString("€#.#");
            }
            else
            {
                trackBarUtilities.Value = 0;
            }
            if (otherExpense != null)
            {
                trackBarOther.Maximum = Convert.ToInt32(max);
                trackBarOther.Value = Convert.ToInt32(otherExpense.Value);
                labelOtherExpense.Text = (otherExpense.Value).ToString("€#.#");
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
        }

        private void trackBarGroceries_Scroll(object sender, EventArgs e)
        {
            var value = trackBarGroceries.Value;
            labelGroceriesExpense.Text = (value).ToString("€#.#");

        }

        private void trackBarTransport_Scroll(object sender, EventArgs e)
        {
            var value = trackBarTransport.Value;
            labelTransportExpense.Text = (value).ToString("€#.#");
        }

        private void trackBarEntertainment_Scroll(object sender, EventArgs e)
        {
            var value = trackBarEntertainment.Value;
            labelEntertainmentExpense.Text = (value).ToString("€#.#");
        }

        private void trackBarHealth_Scroll(object sender, EventArgs e)
        {
            var value = trackBarHealth.Value;
            labelHealthExpense.Text = (value).ToString("€#.#");
        }

        private void trackBarShopping_Scroll(object sender, EventArgs e)
        {
            var value = trackBarShopping.Value;
            labelShoppingExpense.Text = (value).ToString("€#.#");
        }

        private void trackBarUtilities_Scroll(object sender, EventArgs e)
        {
            var value = trackBarUtilities.Value;
            labelUtilitiesExpense.Text = (value).ToString("€#.#");
        }

        private void trackBarOther_Scroll(object sender, EventArgs e)
        {
            var value = trackBarOther.Value;
            labelOtherExpense.Text = (value).ToString("€#.#");
        }

        private void trackBarSavings_Scroll(object sender, EventArgs e)
        {
            var value = trackBarSavings.Value;
            labelSavings.Text = (value).ToString("€#.#");
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            if (btnAddGoal.Top < 500) {
                btnAddGoal.Top += 60;
            }
            else
            {
                btnAddGoal.BackColor = System.Drawing.Color.Gray;
            }
            
        }
    }
}
