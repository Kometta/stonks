using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

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
                trackbar.Maximum = Convert.ToInt32(maximumValue); 
                trackbar.Value = Convert.ToInt32(expense.PlannedValue); 
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

        public static void LoadSavingsTrackBar(TrackBar trackBarSavings, Label labelPlannedSavings, Label labelSavings) {
            try
            {
                trackBarSavings.Minimum = Convert.ToInt32(Program.financialPlan.Income * (-1));
                trackBarSavings.Maximum = Convert.ToInt32(Program.financialPlan.Income);
                trackBarSavings.Value = Convert.ToInt32(Program.financialPlan.Savings);
                labelPlannedSavings.Text = (Program.financialPlan.GetPlannedSavings()).ToString("€#.#");
                labelSavings.Text = (Program.financialPlan.Savings).ToString("€#.#");
            }
            catch
            {
                trackBarSavings.Value = 0;
                labelSavings.Text = (Program.financialPlan.Savings).ToString("€#.#");
            }
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

        public static void AddGoalVisuals(Int32 type, String name, String goal, Int32 locationX, Int32 locationY, Form currentForm, Button btnAddGoal, int measurements)
        {
            int btnLocationX = btnAddGoal.Location.X;
            Int32 startX = btnLocationX;
            Int32 startY = 150;
            int locX = startX + locationX;
            int locY = startY + locationY;

            //ICON
            IconPictureBox icon = new IconPictureBox
            {
                BackColor = Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74))))),
                ForeColor = Color.Gainsboro,
                IconChar = FontAwesome.Sharp.IconChar.FolderMinus,
                IconColor = Color.Gainsboro,
                Location = new Point(locX, locY - 5),
                Margin = new Padding(3, 2, 3, 2),
                Name = "iconGoal",
                Size = new Size(40, 32),
            };        

            //GOAL NAME
            Double goalConverted = Convert.ToDouble(goal);
            Label goalName = new Label
            {
                Location = new Point(locX + 50, locY), 
                Text = name,
                AutoSize = true,
                ForeColor = Color.Gainsboro,
                Font = new Font("Segoe UI", 10.2F, FontStyle.Bold)
            };

            //SLIDER
            TrackBar trackBarGoal = new TrackBar
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

            //LABEL PRICE
            Label goalPrice = new Label
            {
                Location = new Point(locX + 270, locY), 
                Text = (goalConverted).ToString("€#.#"),
                AutoSize = true,
                Font = new Font("Segoe UI", 10.2F, FontStyle.Bold),
                ForeColor = Color.Gainsboro
            };

            //LABEL ESTIMATED TIME
            Label estimatedTime = new Label
            {
                Location = new Point(locX + 340, locY),
                Text = FinancialGoal.GetEstimatedTime(Program.financialPlan.Savings, goalConverted, measurements),
                AutoSize = true,
                Font = new Font("Segoe UI", 10.2F, FontStyle.Bold),
                ForeColor = Color.Gainsboro
            };

            currentForm.Controls.Add(icon);
            currentForm.Controls.Add(goalName);
            currentForm.Controls.Add(trackBarGoal);
            currentForm.Controls.Add(goalPrice);
            currentForm.Controls.Add(estimatedTime);
        }

        public static void RemoveGoalVisuals(int goalToDelete) {
            int i = 0;

            foreach (FinancialGoal goal in Program.financialPlan.FinancialGoals)
            {
                if (i == goalToDelete)
                {
                    Program.financialPlan.RemoveFinancialGoal(goal);
                    break;
                }
                i++;
            }
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

        public static void loadGoals(Button btnAddGoal, Button buttondelete, Label labelStop, Form form, int measurements)
        {
            var x = 0;
            var y = 0;
            var z = 0;

            foreach (FinancialGoal goal in Program.financialPlan.FinancialGoals)
            {
                InitializeUI.AddGoalVisuals(0, goal.Name, Convert.ToString(goal.Value), y, x, form, btnAddGoal, measurements);
                btnAddGoal.Top += 90;
                buttondelete.Top += 90;
                x += 75;
                z++;
            }

            if (z == 3)
            {
                labelStop.Visible = true;
                btnAddGoal.BackColor = Color.Gray;
                btnAddGoal.Enabled = false;
            }
        }

        public static void AddNewGoal(Button btnAddGoal, Button buttondelete, Label labelStop, int lengthGoals, String goalName, String goal, Int32 type, Form form, int measurements)
        {
            if (lengthGoals <= 3 || btnAddGoal.Top >= 400)
            {
                if (btnAddGoal.Top < 400 && (!goalName.Equals("") || !goal.Equals("")) && lengthGoals <= 3)
                {
                    btnAddGoal.Top += 90;
                    buttondelete.Top += 90;
                    InitializeUI.AddGoalVisuals(type, goalName, goal, 0, 75 * lengthGoals, form, btnAddGoal, measurements);
                    Program.financialPlan.AddFinancialGoal(new FinancialGoal() { Value = Convert.ToDouble(goal), Name = goalName });
                }

                if (btnAddGoal.Top >= 400)
                {
                    btnAddGoal.BackColor = Color.Gray;
                    labelStop.Visible = true;
                    btnAddGoal.Enabled = false;
                }
            }
            else
            {
                labelStop.Visible = true;
                btnAddGoal.BackColor = Color.Gray;
                btnAddGoal.Enabled = false;
            }
        }
    }

}
