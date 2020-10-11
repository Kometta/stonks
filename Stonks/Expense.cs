using System;

namespace Stonks
{
    public enum ExpenseType
    {
        Groceries,
        Housing,
        Transport,
        Entertainment,
        Health,
        Shopping,
        Utilities,
        Other
    }

    [Serializable]
    class Expense
    {
        public ExpenseType Type { get; set; }
        public double Value { get; set; }
        public double PlannedValue { get; set; }

        public Expense (ExpenseType type, double value, double plannedValue)
        {
            Type = type;
            Value = value;
            PlannedValue = plannedValue;
        }
    }
}
