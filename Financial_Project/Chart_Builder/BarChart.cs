using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Project.Chart_Builder
{
    public class BarChart : AbstractChartBuilder
    {
        double[] xData = new double[60];
        List<double> xdata = new List<double>();
        List<string> yData = new List<string>();
        public override FormsPlot buildChart()
        {
            if (xData == null)
            {
                throw new Exception("Data not set");
            }
            FormsPlot plot = new FormsPlot();
            var barPlot = plot.Plot.Add.Bars(xdata.ToArray());
            var bar = 0;
            foreach (var item in yData)
            {
                if(bar >= 59)
                {
                    break;
                }
                barPlot.Bars[bar].Label = item;
                bar++;
            }
            barPlot.ValueLabelStyle.FontSize = 10;
            barPlot.Horizontal = true;
            barPlot.ValueLabelStyle.Bold = true;
            var min = xdata.Min();
            var max = xdata.Max();
            if(Math.Abs(min) > max)
            {
                max = Math.Abs(min);
            }
            else
            {
                min = -max;
            }
            plot.Plot.Axes.SetLimitsX(min, max);
            plot.Plot.Add.VerticalLine(0, 1, Colors.Black);
            plot.Plot.Title(ticker);
            plot.MinimumSize = new System.Drawing.Size(1800, 960);
            return plot;
        }

        public override void processDataHistorical()
        {
            var dataArray = data.RootElement.GetProperty("data").EnumerateArray();
            int limit = 60;
            foreach (var element in dataArray)
            {
                if (limit == 0)
                {
                    break;
                }
                limit--;
                var aqOrDisp = element.GetProperty("acquisition_or_disposal").GetString();
                var date = element.GetProperty("transaction_date").GetString();
                double shares = 0;

                var sharesString = element.GetProperty("shares").GetString();
                if (!double.TryParse(sharesString, out shares))
                {
                    continue;
                }

                if(aqOrDisp == "A")
                {
                    shares = Math.Abs(shares);
                }
                else
                {
                    shares = -Math.Abs(shares);
                }
                xdata.Add(shares);
                yData.Add(date);
            }
        }

        public override void processDataIntraday()
        {
            //this will never be used inside of this plot type
            throw new NotImplementedException();
        }
    }
}
