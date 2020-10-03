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
            this.Text = "Home";
            var Spendings = Program.financialPlan.GetSpendings();
            Program.financialPlan.Savings = Program.financialPlan.Income - Program.financialPlan.GetSpendings();
            labelEarnings.Text = (Program.financialPlan.Income).ToString("€#.#");
            labelSpendings.Text = Spendings.ToString("€#.#");
            labelSavings.Text = (Program.financialPlan.Savings).ToString("€#.#");
            gaugeSavings.Value = Program.financialPlan.Savings;
            gaugeSavings.To = Program.financialPlan.Income;
            gaugeSpendings.Value = Spendings;
            gaugeSpendings.To = Program.financialPlan.Income;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
        }
    }
}
