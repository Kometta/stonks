using System;

namespace Stonks
{
    [Flags]
    public enum ExpenseType
    {
        Groceries = 1 << 0,
        Housing = 1 << 1,
        Transport = 1 << 2,
        Entertainment = 1 << 3,
        Health = 1 << 4,
        Shopping = 1 << 5,
        Utilities = 1 << 6,
        Other = 1 << 7
    }

    [Serializable]
    public class Expense : ICloneable
    {
        public ExpenseType Type { get; set; }
        public double Value { get; set; }
        public double PlannedValue { get; set; }

        public Expense ()
        {
        }

        public Expense (ExpenseType type, double value, double plannedValue)
        {
            Type = type;
            Value = value;
            PlannedValue = plannedValue;
        }

        public object Clone()
        {
            return new Expense(Type, Value, PlannedValue);
        }
    }
}
