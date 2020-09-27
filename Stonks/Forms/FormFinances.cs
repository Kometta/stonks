using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stonks.Forms
{
    public partial class MyFinances : Form
    {
        public MyFinances()
        {
            InitializeComponent();
            this.Text = "My Finances";
            textBoxEarnings.Text = Convert.ToString(Program.financialPlan.Income);
            //textBoxHousing.Text = Convert.ToString(Program.financialPlan); How can I show the Housing expense value
        }

        private void MyFinances_Load(object sender, EventArgs e)
        {

        }

        private void labelUtilities_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveFinances_Click(object sender, EventArgs e)
        {
            if (textBoxEarnings.Text != null)
            {
                Program.financialPlan.Income = Convert.ToDouble(textBoxEarnings.Text);
            }
            Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Housing, Reduction = 0, Value = Convert.ToDouble(textBoxHousing.Text) });
            Program.financialPlan.AddExpense(new Expense() { Type = ExpenseType.Transport, Reduction = 0, Value = Convert.ToDouble(textBoxTransport.Text) });
        }
    }
}
