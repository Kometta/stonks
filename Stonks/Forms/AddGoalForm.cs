using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stonks.Forms
{
    public partial class AddGoalForm : Form
    {
        public AddGoalForm()
        {
            InitializeComponent();
        }

        private void AddGoalForm_Load(object sender, EventArgs e)
        {

        }

        public String TextBoxGoal
        {
            get
            {
                return textBoxGoalName.Text;
            }
        }

        public String textBoxGoalPrice
        {
            get
            {
                return textBoxPrice.Text;
            }
        }

        public Int32 comboBoxGoalType
        {
            get
            {
                return comboBoxGoalTypes.TabIndex;
            }
        }


        private void textBoxGoalName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxGoalTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
