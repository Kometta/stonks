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

    public static class DictionaryExtensions
    {
        public static Dictionary<ExpenseType, TextBox> AddBoxExpenseType(this Dictionary<ExpenseType, TextBox> source, ExpenseType key, TextBox value) 
        {
            source.Add(key, value);
            return source;
        }

        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (T item in enumeration)
            {
                action(item);
            }
        }
    }

    public partial class MyFinances : Form
    {
        Dictionary<ExpenseType, TextBox> BoxExpenseType;
        
        public MyFinances()
        {   
            InitializeComponent();
            this.Text = "My Finances";
            InitBoxExpenseType();
            LoadExpenses();
        }

        private void MyFinances_Load(object sender, EventArgs e)
        {
        }

        private void LabelUtilities_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSaveFinances_Click(object sender, EventArgs e)
        {
            SaveExpenseValues();
        }

        public void InitBoxExpenseType() {
            BoxExpenseType = new Dictionary<ExpenseType, TextBox>();
            BoxExpenseType
                .AddBoxExpenseType(ExpenseType.Housing, textBoxHousing)
                .AddBoxExpenseType(ExpenseType.Groceries, textBoxFood)
                .AddBoxExpenseType(ExpenseType.Transport, textBoxTransport)
                .AddBoxExpenseType(ExpenseType.Entertainment, textBoxEntertainment)
                .AddBoxExpenseType(ExpenseType.Health, textBoxHealth)
                .AddBoxExpenseType(ExpenseType.Shopping, textBoxShopping)
                .AddBoxExpenseType(ExpenseType.Utilities, textBoxUtilities)
                .AddBoxExpenseType(ExpenseType.Other, textBoxOther);
        }

        public void LoadExpenses() 
        {
            //Income
            if (textBoxEarnings == null)
            {
                textBoxEarnings.Text = "0";
            }
            else
            {
                textBoxEarnings.Text = Convert.ToString(Program.financialPlan.Income);
            }

            //Expenses
            BoxExpenseType.ForEach(x => x.Value.Text = (Program.financialPlan.GetExpense(x.Key) != null) ? Convert.ToString(Program.financialPlan.GetExpense(x.Key).Value) : "0");
            }

        public void SaveExpenseValues()
        {
            //Income
            if (textBoxEarnings.Text != null)
            {
                Program.financialPlan.Income = Convert.ToDouble(textBoxEarnings.Text);
            }

            //Expenses
            BoxExpenseType.ForEach(x => Program.financialPlan.AddExpense(new Expense(x.Key, Convert.ToDouble(x.Value.Text), 0)));
        }
    }
}
