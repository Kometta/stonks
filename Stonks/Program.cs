using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stonks
{
    static class Program
    {
        public static FinancialPlan financialPlan;
        public static string saveFilePath = "C:\\financialPlan.bin";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            financialPlan = BinarySerialization.ReadFromBinaryFile<FinancialPlan>(saveFilePath);
            FinancialPlanController.FinancialPlans = BinarySerialization.ReadFromBinaryFile<List<FinancialPlan>>(saveFilePath);
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Stonks());
            BinarySerialization.WriteToBinaryFile(saveFilePath, financialPlan);
            BinarySerialization.WriteToBinaryFile(saveFilePath, FinancialPlanController.FinancialPlans);
        }
    }
}
