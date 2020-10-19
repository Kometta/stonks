using System;

namespace Stonks
{
    [Serializable]
    class FinancialGoal
    {
        public double Value { get; set; }
        public String Name { get; set; }
        public double AllocatedFunds { get; set; }
        public double MonthsToDeadline { get; set; }

        public void SetDeadline(DateTime dealineIn)
        {
            MonthsToDeadline = (DateTime.Now - dealineIn).TotalDays / 30;
        }

        public double GetDeadline()
        {
            return Value / AllocatedFunds;
        }

        public void SetAllocatedFunds()
        {
            AllocatedFunds = Value / MonthsToDeadline;
        }

        public double GetAllocatedFunds()
        {
            SetAllocatedFunds();
            return AllocatedFunds;
        }
    }
}
