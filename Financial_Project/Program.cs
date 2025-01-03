
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

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
            var form1 = new SPYForecastForm();
            Application.Run(form1);

            form1.FormsPlot1.Plot.Clear();
            form1.FormsPlot1.Plot.Add.Scatter(dataLB, index);
            form1.FormsPlot1.Plot.Add.Scatter(dataUB, index);
            form1.FormsPlot1.Plot.Add.Scatter(dataC, index);

        }
    }
}