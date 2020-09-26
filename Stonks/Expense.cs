using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Stonks
{
    public enum ExpenseType
    {
        Groceries = 0,
    }

    [Serializable]
    class Expense
    {
        public ExpenseType Type { get; set; }
        public double Value { get; set; }
        public double Reduction { get; set; }
    }
}
