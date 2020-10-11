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

        public TextBox TextBoxGoalName
        {
            get
            {
                return textBoxGoalName;
            }
        }

        private void textBoxGoalName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
