﻿using System;
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

            //Setting the values to represent the track bars
            if (housingExpense != null) {
                trackBarHousing.Value = Convert.ToInt32((housingExpense.Value * 100) / income);
            }
            else
            {
                trackBarHousing.Value = 0;
            }

            if (groceries != null)
            {
                trackBarGroceries.Value = Convert.ToInt32((groceries.Value * 100) / income);
            }
            else
            {
                trackBarGroceries.Value = 0;
            }
            if (entertainmentExpense != null)
            {
                trackBarEntertainment.Value = Convert.ToInt32((entertainmentExpense.Value * 100) / income);
            }
            else
            {
                trackBarEntertainment.Value = 0;
            }
            if (transportExpense != null)
            {
                trackBarTransport.Value = Convert.ToInt32((transportExpense.Value * 100) / income);
            }
            else
            {
                trackBarTransport.Value = 0;
            }
            if (healthExpense != null)
            {
                trackBarHealth.Value = Convert.ToInt32((healthExpense.Value * 100) / income);
            }
            else
            {
                trackBarHealth.Value = 0;
            }
            if (shoppingExpense != null)
            {
                trackBarShopping.Value = Convert.ToInt32((shoppingExpense.Value * 100) / income);
            }
            else
            {
                trackBarShopping.Value = 0;
            }
            if (utilitiesExpense != null)
            {
                trackBarUtilities.Value = Convert.ToInt32((utilitiesExpense.Value * 100) / income);
            }
            else
            {
                trackBarUtilities.Value = 0;
            }
            if (otherExpense != null)
            {
                trackBarOther.Value = Convert.ToInt32((otherExpense.Value * 100) / income);
            }
            else
            {
                trackBarOther.Value = 0;
            }
            //trackBarSavings.Value = Convert.ToInt32((Program.financialPlan.Savings * 100)/income); FIX LATER
        }
    }
}
