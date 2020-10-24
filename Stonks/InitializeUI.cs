using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace Stonks
{
    public enum IconChar
    {
        Home,
        Car,
        ShoppingBag,
        TicketAlt,
        Heartbeat,
        Wrench,
        FolderMinus
    }
    public static class InitializeUI
    {
        public static void LoadTrackBars(Expense expense, TrackBar trackbar, Label labelPlanned, Label labelActual, Double maximumValue)
        {
            if (expense != null)
            {
                trackbar.Maximum = Convert.ToInt32(maximumValue); //Luzta jei ivedi dideli sk.
                trackbar.Value = Convert.ToInt32(expense.PlannedValue); //Fix if value becomes higher than expense(just like savings?)
                labelPlanned.Text = (expense.PlannedValue).ToString("€#.#");
                labelActual.Text = (expense.Value).ToString("€#.#");
            }
            else
            {
                trackbar.Value = 0;
            }
        }

        public static void LoadCurrentDate(Label labelDate) {
            labelDate.Text = DateTime.Now.ToString("yyyy-M-dd");
        }

        public static void SavePlannedValues(Label labelExpense, TrackBar trackBar, ExpenseType type)
        {
            var value = trackBar.Value;
            labelExpense.Text = (value).ToString("€#.#");
            Program.financialPlan.AddExpense(new Expense() { Type = type, PlannedValue = value, Value = Program.financialPlan.GetExpense(type).Value });
        }

        public static void UpdatePlannedSavings(Label labelPlannedSavings)
        {
            labelPlannedSavings.Text = (Program.financialPlan.GetPlannedSavings()).ToString("€#.#");
        }

        public static void AddGoalVisuals(Int32 type, String name, String goal, Int32 locationX, Int32 locationY, Form currentForm, Button btnAddGoal)
        {
            Point loc = btnAddGoal.Location;
            int locationXX = loc.X;
            Int32 startX = locationXX;
            Int32 startY = 150;
            int locX = startX + locationX;
            int locY = startY + locationY;
            int btnCount = locationY / 50;

            //ICON
            IconPictureBox icon = new IconPictureBox
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74))))),
                ForeColor = System.Drawing.Color.Gainsboro,
                IconChar = FontAwesome.Sharp.IconChar.FolderMinus,
                IconColor = System.Drawing.Color.Gainsboro,
                Location = new System.Drawing.Point(locX, locY - 5),
                Margin = new System.Windows.Forms.Padding(3, 2, 3, 2),
                Name = "iconGoal",
                Size = new System.Drawing.Size(40, 32),
            };
            currentForm.Controls.Add(icon);

            //GOAL NAME
            Double goalConverted = Convert.ToDouble(goal);
            Label goalName = new System.Windows.Forms.Label
            {
                Location = new Point(locX + 50, locY), //Change Y depending on the goal ammount
                Text = name,
                AutoSize = true,
                ForeColor = System.Drawing.Color.Gainsboro,
                Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold)
            };
            currentForm.Controls.Add(goalName);

            //SLIDER
            TrackBar trackBarGoal = new System.Windows.Forms.TrackBar
            {
                Location = new Point(locX + 110, locY - 5),
                Margin = new Padding(3, 2, 3, 2),
                Maximum = Convert.ToInt32(goalConverted * 1.2),
                Value = Convert.ToInt32(goalConverted),
                Name = "trackBarGoal",
                Size = new Size(155, 55),
                TabIndex = 2,
                TickStyle = TickStyle.None
            };
            currentForm.Controls.Add(trackBarGoal);

            //LABEL PRICE
            Label goalPrice = new System.Windows.Forms.Label
            {
                Location = new Point(locX + 270, locY), //Change Y depending on the goal ammount
                Text = (goalConverted).ToString("€#.#"),
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Gainsboro
            };
            currentForm.Controls.Add(goalPrice);

            //LABEL ESTIMATED TIME
            Label estimatedTime = new System.Windows.Forms.Label
            {
                Location = new Point(locX + 340, locY), //Change Y depending on the goal ammount
                Text = (Convert.ToInt32(goalConverted / Program.financialPlan.Savings)).ToString("# months"),
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Gainsboro
            };
            currentForm.Controls.Add(estimatedTime);
        }

        public static int GetGoalLength()
        {
            var x = 0;
            foreach (FinancialGoal goal in Program.financialPlan.FinancialGoals)
            {
                x++;
            }

            return x;
        }

        public static void loadGoals(Button btnAddGoal, Button buttondelete, Label labelStop, Form form)
        {
            var x = 0;
            var y = 0;
            var z = 0;

            foreach (FinancialGoal goal in Program.financialPlan.FinancialGoals)
            {
                InitializeUI.AddGoalVisuals(0, goal.Name, Convert.ToString(goal.Value), y, x, form, btnAddGoal);
                btnAddGoal.Top += 90;
                buttondelete.Top += 90;
                x += 75;
                z++;
            }

            if (z == 3)
            {
                labelStop.Visible = true;
                btnAddGoal.BackColor = System.Drawing.Color.Gray;
                btnAddGoal.Enabled = false;
            }
        }

        public static void AddNewGoal(Button btnAddGoal, Button buttondelete, Label labelStop, int lengthGoals, String goalName, String goal, Int32 type, Form form)
        {
            if (lengthGoals <= 3 || btnAddGoal.Top >= 400)
            {
                if (btnAddGoal.Top < 400 && (!goalName.Equals("") || !goal.Equals("")) && lengthGoals <= 4)
                {
                    btnAddGoal.Top += 90;
                    buttondelete.Top += 90;
                    InitializeUI.AddGoalVisuals(type, goalName, goal, 0, 75 * lengthGoals, form, btnAddGoal);
                    Program.financialPlan.AddFinancialGoal(new FinancialGoal() { Value = Convert.ToDouble(goal), Name = goalName });
                }

                if (btnAddGoal.Top >= 400)
                {
                    btnAddGoal.BackColor = System.Drawing.Color.Gray;
                    labelStop.Visible = true;
                    btnAddGoal.Enabled = false;
                }
            }
            else
            {
                labelStop.Visible = true;
                btnAddGoal.BackColor = System.Drawing.Color.Gray;
                btnAddGoal.Enabled = false;
            }
        }
    }

}
