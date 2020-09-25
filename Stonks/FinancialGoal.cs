﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stonks
{
    class FinancialGoal
    {
        public double Value { get; set; }
        public DateTime Deadline { get; set; }

        public TimeSpan GetTimeToDeadline()
        {
            return Deadline.Subtract(DateTime.Now);
        }

        public void SetDeadlineInTimeSpan(TimeSpan dealineIn)
        {
            Deadline = DateTime.Now.Add(dealineIn);
        }
    }
}