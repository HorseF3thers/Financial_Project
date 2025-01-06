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
        bool darkMode = false;
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
                default:
                    return null;
            }
        }
        public void setData(string ticker, string timeframe)
        {
            switch(timeframe)
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
                default:
                    break;
            }
        }
        public void setDarkMode(bool darkMode)
        {
            this.darkMode = darkMode;
        }
        public abstract void processData();
        public abstract FormsPlot buildChart();
    }
}
