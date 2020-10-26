using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stonks
{
    static class Program
    {
        public static FinancialPlan financialPlan;
        public static string saveFilePath = "C:\\financialPlan.bin";
        public static string saveFilePath2 = "C:\\financialPlan2.bin";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                financialPlan = BinarySerialization.ReadFromBinaryFile<FinancialPlan>(saveFilePath);
                FinancialPlanController.FinancialPlans = BinarySerialization.ReadFromBinaryFile<List<FinancialPlan>>(saveFilePath2);
            }
            catch (Exception e)
            {
                if (financialPlan == null)
                    financialPlan = new FinancialPlan();
            }
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Stonks());
            BinarySerialization.WriteToBinaryFile(saveFilePath, financialPlan);
            BinarySerialization.WriteToBinaryFile(saveFilePath2, FinancialPlanController.FinancialPlans);
        }
    }
}
