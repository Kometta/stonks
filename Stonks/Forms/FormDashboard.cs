using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stonks.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.Text = Resources.LStrings.HomeLabel;
            var Spendings = FinancialPlanController.ActivePlan.GetSpendings();
            FinancialPlanController.ActivePlan.Savings = FinancialPlanController.ActivePlan.Income - FinancialPlanController.ActivePlan.GetSpendings();
            labelEarnings.Text = (FinancialPlanController.ActivePlan.Income).ToString("€#.#");
            labelSpendings.Text = Spendings.ToString("€#.#");
            labelSavings.Text = (FinancialPlanController.ActivePlan.Savings).ToString("€#.#");
            gaugeSavings.Value = FinancialPlanController.ActivePlan.Savings;
            gaugeSavings.To = FinancialPlanController.ActivePlan.Income;
            gaugeSpendings.Value = Spendings;
            gaugeSpendings.To = FinancialPlanController.ActivePlan.Income;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
        }
    }
}
