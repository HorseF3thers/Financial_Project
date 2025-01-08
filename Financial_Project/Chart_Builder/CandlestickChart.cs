using ScottPlot.WinForms;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarfBuzzSharp;

namespace Financial_Project.Chart_Builder
{
    public class CandlestickChart : AbstractChartBuilder
    {
        private DateTime[] xData;
        private OHLC[] Ohlc;
        public override FormsPlot buildChart()
        {
            if (Ohlc == null || xData == null)
            {
                throw new Exception("Data not set");
            }
            FormsPlot plot = new FormsPlot();
            plot.Plot.Add.Candlestick(Ohlc);
            plot.Plot.Axes.DateTimeTicksBottom();
            plot.Plot.ScaleFactor = 1;
            plot.Plot.Title(ticker);

            return plot;
        }

        public override void processDataHistorical()
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
            Ohlc = ohlc.ToArray();
            xData = dates.ToArray();
        }

        public override void processDataIntraday()
        {
            if (data == null)
            {
                throw new Exception("Data not set");
            }

            var timeSeries = data.RootElement.GetProperty("Time Series (15min)");
            var dates = new List<DateTime>();
            var ohlc = new List<OHLC>();
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
                ohlc.Add(new OHLC(openPrice, highPrice, lowPrice, closePrice, date, TimeSpan.FromMinutes(15)));
            }
            Ohlc = ohlc.ToArray();
            xData = dates.ToArray();
        }
    }
}
