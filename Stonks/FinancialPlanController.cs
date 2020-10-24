using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks
{
    static class FinancialPlanController
    {
        public static List<FinancialPlan> FinancialPlans { get; set; } = new List<FinancialPlan>();
        static FinancialPlan ActivePlan 
        {
            get
            {
                if (ActivePlan == null)
                {
                    if (FinancialPlans.Count == 0)
                        AddNewPlan();
                    ActivePlan = FinancialPlans.Last();
                }

                return ActivePlan;
            }

            set
            {
            }
        }

        public static void AddNewPlan (bool copyPrevious = false)
        {
            if (copyPrevious)
                FinancialPlans.Add(FinancialPlans.Count > 1 ? new FinancialPlan(FinancialPlans.ElementAt(FinancialPlans.Count - 2)) : new FinancialPlan());
            else
                FinancialPlans.Add(new FinancialPlan());
        }
    }
}
