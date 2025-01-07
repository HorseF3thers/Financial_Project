using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Project.Chart_Builder
{
    public class OHLCChart : AbstractChartBuilder
    {
        private DateTime[] xData;
        private List<OHLC> Ohlc;
        public override FormsPlot buildChart()
        {
            if (Ohlc == null || xData == null)
            {
                throw new Exception("Data not set");
            }
            FormsPlot plot = new FormsPlot();
            plot.Plot.Add.OHLC(Ohlc);
            plot.Plot.Axes.DateTimeTicksBottom();
            plot.Plot.ScaleFactor = 2;
            return plot;
        }

        public override void processData()
        {
            if (data == null)
            {
                throw new Exception("Data not set");
            }

            var timeSeries = data.RootElement.GetProperty("Time Series (Daily)");
            var dates = new List<DateTime>();
            var ohlc = new List<OHLC>();
            int i = 0;
            foreach (var element in timeSeries.EnumerateObject())
            {
                var date = DateTime.Parse(element.Name);
                var openPriceString = element.Value.GetProperty("1. open");
                var highPriceString = element.Value.GetProperty("2. high");
                var lowPriceString = element.Value.GetProperty("3. low");
                var closePriceString = element.Value.GetProperty("4. close");
                var openPrice = double.Parse(openPriceString.GetString());
                var highPrice = double.Parse(highPriceString.GetString());
                var lowPrice = double.Parse(lowPriceString.GetString());
                var closePrice = double.Parse(closePriceString.GetString());
                dates.Add(date);
                ohlc.Add(new OHLC(openPrice, highPrice, lowPrice, closePrice, date, TimeSpan.FromDays(1)));
            }
            Ohlc = ohlc;
            xData = dates.ToArray();
        }
    }
}
