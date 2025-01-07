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

            var SpyForecast = SPY_Daily_Forecast_ML.Test.Predict();
            SpyForecast = SPY_Daily_Forecast_ML.Test.Predict(horizon: 5);

            double[] dataC = new double[SpyForecast.Close.Length];
            Array.Copy(SpyForecast.Close, dataC, SpyForecast.Close.Length);

            double[] dataLB = new double[SpyForecast.Close_LB.Length];
            Array.Copy(SpyForecast.Close_LB, dataLB, SpyForecast.Close_LB.Length);

            double[] dataUB = new double[SpyForecast.Close_UB.Length];
            Array.Copy(SpyForecast.Close_UB, dataUB, SpyForecast.Close_UB.Length);
            double[] index = { 1, 2, 3, 4, 5 };


            var sp = FormsPlot1.Plot.Add.Scatter(index, dataC, new ScottPlot.Color(0, 0, 255));
            sp.LineWidth = 4;
            sp.MarkerSize = 10;
            var sp1 = FormsPlot1.Plot.Add.Scatter(index, dataLB, new ScottPlot.Color(255, 0, 0));
            sp1.LineWidth = 4;
            sp1.MarkerSize = 10;
            var sp2 = FormsPlot1.Plot.Add.Scatter(index, dataUB, new ScottPlot.Color(0, 255, 0));
            sp2.LineWidth = 4;
            sp2.MarkerSize = 10;
            FormsPlot1.Plot.Axes.AutoScale();
            FormsPlot1.Refresh();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                FormsPlot1.Plot.SavePng(filePath, 500, 375);
            }
        }
    }
}
