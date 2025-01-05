
namespace Financial_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var SpyForecast = SPY_Daily_Forecast_ML.Test.Predict();
            SpyForecast = SPY_Daily_Forecast_ML.Test.Predict(horizon: 5);

            double[] dataC = new double[SpyForecast.Close.Length];
            Array.Copy(SpyForecast.Close, dataC, SpyForecast.Close.Length);

            double[] dataLB = new double[SpyForecast.Close_LB.Length];
            Array.Copy(SpyForecast.Close_LB, dataLB, SpyForecast.Close_LB.Length);

            double[] dataUB = new double[SpyForecast.Close_UB.Length];
            Array.Copy(SpyForecast.Close_UB, dataUB, SpyForecast.Close_UB.Length);
            double[] index = { 1, 2, 3, 4, 5 };




            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var form1 = new SPYForecastForm();
            //Application.Run(form1);


            /**form1.FormsPlot1.Plot.Clear();
            form1.FormsPlot1.Plot.Add.Scatter(dataLB, index);
            form1.FormsPlot1.Plot.Add.Scatter(dataUB, index);
            form1.FormsPlot1.Plot.Add.Scatter(dataC, index);**/

            // predict with default option.
            var modelOutput = SPY_Daily_Forecast_ML.Test.Predict();
            Console.WriteLine("Close: " + string.Join(",", modelOutput.Close));
            Console.WriteLine("LB: " + string.Join(",", modelOutput.Close_LB));
            Console.WriteLine("UB: " + string.Join(",", modelOutput.Close_UB));

            // predict next 5 periods
            modelOutput = SPY_Daily_Forecast_ML.Test.Predict(horizon: 5);
            Console.WriteLine("Close: " + string.Join(",", modelOutput.Close));
            Console.WriteLine("LB: " + string.Join(",", modelOutput.Close_LB));
            Console.WriteLine("UB: " + string.Join(",", modelOutput.Close_UB));
            //var form2 = new Main_Menu_Form();
            using (MultiFormContext context = new MultiFormContext(new Main_Menu_Form()))
            {
                Application.Run(context);
            }
        }
    }
}