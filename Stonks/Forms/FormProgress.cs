using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Stonks.Forms
{
    public partial class FormProgress : Form
    {
        public FormProgress()
        {
            InitializeComponent();

        }

        private void chartExpenses_Click(object sender, EventArgs e)
        {

        }

        private void FormProgress_Load(object sender, EventArgs e)
        {
            fillChart();
        }

        private void fillChart()
        {
            chartPlanned.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chartPlanned.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Transparent;

            chartPlanned.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartPlanned.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            Title title;

            try
            {
                //ExpensesChart 
                chartPlanned.Series["Monthly Expenses"].Points.AddXY("Housing", Program.financialPlan.GetExpense(ExpenseType.Housing).Value);
                chartPlanned.Series["Monthly Expenses"].Points.AddXY("Groceries", Program.financialPlan.GetExpense(ExpenseType.Groceries).Value);
                chartPlanned.Series["Monthly Expenses"].Points.AddXY("Transport", Program.financialPlan.GetExpense(ExpenseType.Transport).Value);
                chartPlanned.Series["Monthly Expenses"].Points.AddXY("Entertainment", Program.financialPlan.GetExpense(ExpenseType.Entertainment).Value);
                chartPlanned.Series["Monthly Expenses"].Points.AddXY("Health", Program.financialPlan.GetExpense(ExpenseType.Health).Value);
                chartPlanned.Series["Monthly Expenses"].Points.AddXY("Shopping", Program.financialPlan.GetExpense(ExpenseType.Shopping).Value);
                chartPlanned.Series["Monthly Expenses"].Points.AddXY("Utilities", Program.financialPlan.GetExpense(ExpenseType.Utilities).Value);
                chartPlanned.Series["Monthly Expenses"].Points.AddXY("Other", Program.financialPlan.GetExpense(ExpenseType.Other).Value);  

                //Planned Expenses Chart
                chartPlanned.Series["Planned Expenses"].Points.AddXY("Housing", Program.financialPlan.GetExpense(ExpenseType.Housing).PlannedValue);
                chartPlanned.Series["Planned Expenses"].Points.AddXY("Groceries", Program.financialPlan.GetExpense(ExpenseType.Groceries).PlannedValue);
                chartPlanned.Series["Planned Expenses"].Points.AddXY("Transport", Program.financialPlan.GetExpense(ExpenseType.Transport).PlannedValue);
                chartPlanned.Series["Planned Expenses"].Points.AddXY("Entertainment", Program.financialPlan.GetExpense(ExpenseType.Entertainment).PlannedValue);
                chartPlanned.Series["Planned Expenses"].Points.AddXY("Health", Program.financialPlan.GetExpense(ExpenseType.Health).PlannedValue);
                chartPlanned.Series["Planned Expenses"].Points.AddXY("Shopping", Program.financialPlan.GetExpense(ExpenseType.Shopping).PlannedValue);
                chartPlanned.Series["Planned Expenses"].Points.AddXY("Utilities", Program.financialPlan.GetExpense(ExpenseType.Utilities).PlannedValue);
                chartPlanned.Series["Planned Expenses"].Points.AddXY("Other", Program.financialPlan.GetExpense(ExpenseType.Other).PlannedValue);

                title = chartPlanned.Titles.Add("Your Planned Expenses VS Your Monthly Expenses");
            }
            catch
            {
                title = chartPlanned.Titles.Add("Record Your Expenses to view comparison graph");
            }

            title.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            title.ForeColor = System.Drawing.Color.White;

        }
    }
}
