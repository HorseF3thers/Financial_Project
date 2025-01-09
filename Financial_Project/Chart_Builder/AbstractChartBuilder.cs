using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;
using ScottPlot.WinForms;
using System.Text.Json;

namespace Financial_Project.Chart_Builder
{
    public abstract class AbstractChartBuilder
    {
        public JsonDocument data;
        public bool darkMode = false;
        public string ticker;
        public static AbstractChartBuilder getInstance(string chartType)
        {
            switch
                (chartType)
            {
                case "Candlestick":
                    return new CandlestickChart();
                case "Line":
                    return new ScatterPlot();
                case "OHLC":
                    return new OHLCChart();
                case "Bar":
                    return new BarChart();
                default:
                    return null;
            }
        }
        public void setData(string ticker, string timeframe)
        {
            this.ticker = ticker;
            switch (timeframe)
            {
                case "Intraday":
                    data = API_Manager.GetInstance().getIntraday(ticker);
                    break;
                case "Compact":
                    data = API_Manager.GetInstance().getShortHistorical(ticker);
                    break;
                case "Full":
                    data = API_Manager.GetInstance().getFullHistorical(ticker);
                    break;
                case "Insider":
                    data = API_Manager.GetInstance().getInsider(ticker);
                    break;
                default:
                    break;
            }
        }
        public void setDarkMode(bool darkMode)
        {
            this.darkMode = darkMode;
        }
        public abstract void processDataHistorical();
        public abstract void processDataIntraday();
        public abstract FormsPlot buildChart();
    }
}
