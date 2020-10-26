using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Stonks.Forms;

namespace Stonks.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            
            InitializeComponent();
            this.Text = "Settings";
         }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        private void labelMode_Click(object sender, EventArgs e)
        {

        }

        private void modeToggleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (modeToggleBtn.Checked == true)
            {
                SwitchToLightMode();
                Stonks.mode = true;
            }
            else {
                SwitchBack();
                Stonks.mode = false;
            }
        }
        private void SwitchToLightMode() {
            this.BackColor = Color.White;
            labelMode.ForeColor = Color.Black;
        }

        private void SwitchBack() {
            this.BackColor = Color.FromArgb(34, 33, 74);
            labelMode.ForeColor = Color.Gainsboro;
        }

        private void FormSettings_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveInfoBtn_Click(object sender, EventArgs e)
        {
            Program.financialPlan.DisplayData = dataMeasure.SelectedIndex;
        }
    }
}
