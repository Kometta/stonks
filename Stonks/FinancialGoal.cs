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

        public void SetFundsByDeadline(DateTime dealineIn)
        {
            MonthsToDeadline = (DateTime.Now - dealineIn).TotalDays / 30;
            AllocatedFunds = Value / MonthsToDeadline;
        }

        public void SetDeadlineByFunds(double value)
        {
            AllocatedFunds = value;
            MonthsToDeadline = Value / AllocatedFunds;
        }
    }
}
