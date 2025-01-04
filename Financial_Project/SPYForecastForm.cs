using ScottPlot;
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
            double[] index = { 0, 1, 2, 3, 4 };


            var sp = FormsPlot1.Plot.Add.Scatter(index, dataC, new ScottPlot.Color(0,0,255));
            sp.LineWidth = 4;
            sp.MarkerSize = 10;
            var sp1 = FormsPlot1.Plot.Add.Scatter(index, dataLB, new ScottPlot.Color(255, 0, 0));
            sp1.LineWidth = 4;
            sp1.MarkerSize = 10;
            var sp2 = FormsPlot1.Plot.Add.Scatter(index, dataUB, new ScottPlot.Color(0, 255, 0));
            sp2.LineWidth = 4;
            sp2.MarkerSize = 10;
            FormsPlot1.Plot.Axes.AutoScale();
            string filePath = "C:\\Users\\Josh E\\Documents\\Spy_Forecast\\1-3-25\\SPYForecast.png";
            if(!File.Exists(filePath))
            {
                FormsPlot1.Plot.SavePng(filePath, 500, 375);
            }
            else
            {
                Console.WriteLine("File already exists");
            }
            FormsPlot1.Refresh();
        }
    }
}
