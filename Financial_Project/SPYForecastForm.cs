using ScottPlot.WinForms;

namespace Financial_Project
{
    public partial class SPYForecastForm : Form
    {
        public readonly FormsPlot FormsPlot1 = new FormsPlot() { Dock = DockStyle.Fill };
        public SPYForecastForm()
        {
            InitializeComponent();

            panel1.Controls.Add(FormsPlot1);

            // Plot data using the control
            //double[] data = ScottPlot.Generate.Sin();
            //FormsPlot1.Plot.Add.Signal(data);



            var SpyForecast = SPY_Daily_Forecast_ML.Test.Predict();
            SpyForecast = SPY_Daily_Forecast_ML.Test.Predict(horizon: 5);

            double[] dataC = new double[SpyForecast.Close.Length];
            Array.Copy(SpyForecast.Close, dataC, SpyForecast.Close.Length);

            double[] dataLB = new double[SpyForecast.Close_LB.Length];
            Array.Copy(SpyForecast.Close_LB, dataLB, SpyForecast.Close_LB.Length);

            double[] dataUB = new double[SpyForecast.Close_UB.Length];
            Array.Copy(SpyForecast.Close_UB, dataUB, SpyForecast.Close_UB.Length);
            FormsPlot1.Plot.Add.Signal(dataLB);
            FormsPlot1.Plot.Add.Signal(dataUB);
            FormsPlot1.Plot.Add.Signal(dataC);
            FormsPlot1.Refresh();
        }
    }
}
