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
            labelEarnings.Text = (Program.financialPlan.Income).ToString("€#.#");
            //labelSavings.Text = (Program.financialPlan.Savings).ToString("€#.#");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
        }
    }
}
