using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Project.Chart_Builder
{
    public class ScatterPlot : AbstractChartBuilder
    {
        private DateTime[] xData;
        private double[] yData;
        public override FormsPlot buildChart()
        {
            if(xData == null || yData == null)
            {
                throw new Exception("Data not set");
            }
            FormsPlot plot = new FormsPlot();
            plot.Plot.Add.Scatter(xData, yData);
            plot.Plot.Axes.DateTimeTicksBottom();
            plot.Plot.ScaleFactor = 2;
            plot.Plot.Title(ticker);
            return plot;
        }

        public override void processDataHistorical()
        {
            if(data == null)
            {
                throw new Exception("Data not set");
            }

            var timeSeries = data.RootElement.GetProperty("Time Series (Daily)");
            var dates = new List<DateTime>();
            var closePrices = new List<double>();
            foreach(var element in timeSeries.EnumerateObject())
            {
                var date = DateTime.Parse(element.Name);
                var closePriceString = element.Value.GetProperty("4. close");

                var closePrice = double.Parse(closePriceString.GetString());

                dates.Add(date);
                closePrices.Add(closePrice);
            }
            xData = dates.ToArray();
            yData = closePrices.ToArray();
        }

        public override void processDataIntraday()
        {
            if (data == null)
            {
                throw new Exception("Data not set");
            }

            var timeSeries = data.RootElement.GetProperty("Time Series (15min)");
            var dates = new List<DateTime>();
            var closePrices = new List<double>();
            foreach (var element in timeSeries.EnumerateObject())
            {
                var date = DateTime.Parse(element.Name);
                var closePriceString = element.Value.GetProperty("4. close");

                var closePrice = double.Parse(closePriceString.GetString());

                dates.Add(date);
                closePrices.Add(closePrice);
            }
            xData = dates.ToArray();
            yData = closePrices.ToArray();
        }
    }
}
