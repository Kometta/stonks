using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Stonks.Forms;

namespace Stonks
{
    [Serializable]
    class FinancialPlan
    {
        public double Income { get; set; }
        public double Savings { get; set; }
        private List<FinancialGoal> FinancialGoals { get; set; }
        private List<Expense> Expenses { get; set; }

        public FinancialPlan ()
        {
            FinancialGoals = new List<FinancialGoal>();
            Expenses = new List<Expense>();
        }

        public void AddFinancialGoal(FinancialGoal goal)
        {
            FinancialGoals.Add(goal);
        }

        //returns false if item not found
        public bool RemoveFinancialGoal(FinancialGoal goal)
        {
            return FinancialGoals.Remove(goal);
        }

        //returns false if expense of same type already exists
        public bool AddExpense(Expense expense)
        {
            if (Expenses.Select(x => x.Type == expense.Type).Count() != 0)
                return false;
            
            Expenses.Add(expense);
            return true;
        }

        //returns false if expense of same type does not exist
        public bool ModifyExpense(Expense expense)
        {
            if (Expenses.Select(x => x.Type == expense.Type).Count() == 0)
                return false;

            Expenses.RemoveAll(x => x.Type == expense.Type);
            Expenses.Add(expense);
            return true;
        }

        //returns false if item not found
        public bool RemoveExpense(Expense expense)
        {
            return Expenses.Remove(expense);
        }

        //returns null if item not found
        public Expense GetExpense(ExpenseType type)
        {
            return Expenses.Where(x => x.Type == type).FirstOrDefault();
        }

        public double GetSpendings()
        {
            double spendings = 0;

            foreach (Expense expense in Expenses) {
                spendings += expense.Value;
            }
            return spendings;
        }
    }
}
