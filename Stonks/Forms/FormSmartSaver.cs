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

            //Setting the values to represent the track bars
            if (housingExpense != null) {
                try
                {
                    trackBarHousing.Value = Convert.ToInt32((housingExpense.Value * 100) / income);
                    labelHousingExpense.Text = (housingExpense.Value).ToString("€#.#");
                }
                catch
                {
                    trackBarHousing.Value = 100;
                    labelHousingExpense.Text = (housingExpense.Value).ToString("€#.#");
                }

            }
            else
            {
                trackBarHousing.Value = 0;
            }

            if (groceries != null)
            {
                try
                {
                    trackBarGroceries.Value = Convert.ToInt32((groceries.Value * 100) / income);
                    labelGroceriesExpense.Text = (groceries.Value).ToString("€#.#");
                }
                catch
                {
                    trackBarGroceries.Value = 100;
                    labelGroceriesExpense.Text = (groceries.Value).ToString("€#.#");
                }
                
            }
            else
            {
                trackBarGroceries.Value = 0;
            }
            if (entertainmentExpense != null)
            {
                try
                {
                    trackBarEntertainment.Value = Convert.ToInt32((entertainmentExpense.Value * 100) / income);
                    labelEntertainmentExpense.Text = (entertainmentExpense.Value).ToString("€#.#");
                }
                catch
                {
                    trackBarEntertainment.Value = 100;
                    labelEntertainmentExpense.Text = (entertainmentExpense.Value).ToString("€#.#");
                }
                
            }
            else
            {
                trackBarEntertainment.Value = 0;
            }
            if (transportExpense != null)
            {
                try
                {
                    trackBarTransport.Value = Convert.ToInt32((transportExpense.Value * 100) / income);
                    labelTransportExpense.Text = (transportExpense.Value).ToString("€#.#");
                }
                catch
                {
                    trackBarTransport.Value = 100;
                    labelTransportExpense.Text = (transportExpense.Value).ToString("€#.#");
                }
                
            }
            else
            {
                trackBarTransport.Value = 0;
            }
            if (healthExpense != null)
            {
                try
                {
                    trackBarHealth.Value = Convert.ToInt32((healthExpense.Value * 100) / income);
                    labelHealthExpense.Text = (healthExpense.Value).ToString("€#.#");
                }
                catch
                {
                    trackBarHealth.Value = 100;
                    labelHealthExpense.Text = (healthExpense.Value).ToString("€#.#");
                }
            }
            else
            {
                trackBarHealth.Value = 0;
            }
            if (shoppingExpense != null)
            {
                try
                {
                    trackBarShopping.Value = Convert.ToInt32((shoppingExpense.Value * 100) / income);
                    labelShoppingExpense.Text = (shoppingExpense.Value).ToString("€#.#");
                }
                catch
                {
                    trackBarShopping.Value = 100;
                    labelShoppingExpense.Text = (shoppingExpense.Value).ToString("€#.#");
                }
            }
            else
            {
                trackBarShopping.Value = 0;
            }
            if (utilitiesExpense != null)
            {
                try
                {
                    trackBarUtilities.Value = Convert.ToInt32((utilitiesExpense.Value * 100) / income);
                    labelUtilitiesExpense.Text = (utilitiesExpense.Value).ToString("€#.#");
                }
                catch
                {
                    trackBarUtilities.Value = 100;
                    labelUtilitiesExpense.Text = (utilitiesExpense.Value).ToString("€#.#");
                }
            }
            else
            {
                trackBarUtilities.Value = 0;
            }
            if (otherExpense != null)
            {
                try
                {
                    trackBarOther.Value = Convert.ToInt32((otherExpense.Value * 100) / income);
                    labelOtherExpense.Text = (otherExpense.Value).ToString("€#.#");
                }
                catch
                {
                    trackBarOther.Value = 100;
                    labelOtherExpense.Text = (otherExpense.Value).ToString("€#.#");
                }
            }
            else
            {
                trackBarOther.Value = 0;
            }
            try
            {
                trackBarSavings.Value = Convert.ToInt32((Program.financialPlan.Savings * 100) / income);
                labelSavings.Text = (savings).ToString("€#.#");
            }
            catch
            {
                trackBarSavings.Value = 100;
            }
            
        }

        private void trackBarHousing_ValueChange(object sender, EventArgs e)
        {

        }
    }
}
