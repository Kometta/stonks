using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stonks
{
    static class Program
    {
        public static string saveFilePath = "C:\\financialPlan.bin";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                FinancialPlanController.FinancialPlans = BinarySerialization.ReadFromBinaryFile<List<FinancialPlan>>(saveFilePath);
                FinancialPlanController.UpdateActive();
            }
            catch
            {
                FinancialPlanController.AddNewPlan();
            }
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Stonks());
            BinarySerialization.WriteToBinaryFile(saveFilePath, FinancialPlanController.FinancialPlans);
        }
    }
}
