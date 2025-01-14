using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Project.Chart_Builder
{
    public partial class Chart_Form : UserControl
    {
        public FormsPlot chart = new FormsPlot() { Dock = DockStyle.Fill };
        public string ticker;
        public string chartType;
        public string timeframe;
        public bool darkMode;
        int width, height;
        public Chart_Form(string chartType, string ticker, string timeframe, bool darkMode)
        {
            InitializeComponent();
            this.ticker = ticker;
            this.chartType = chartType;
            this.timeframe = timeframe;
            this.darkMode = darkMode;
            AbstractChartBuilder chartBuilder = AbstractChartBuilder.getInstance(chartType);
            chartBuilder.setData(ticker, timeframe);
            chartBuilder.setDarkMode(darkMode);
            if (timeframe == "Intraday")
            {
                chartBuilder.processDataIntraday();
            }
            else
            {
                chartBuilder.processDataHistorical();
            }
            chart = chartBuilder.buildChart();
            this.Controls.Add(chart);
            chart.Size = new Size(1820, 1080);
            chartPanel.Controls.Add(chart);
        }
        public void resizeChart(int width, int height)
        {
            this.width = width;
            this.height = height;
            chart.Size = new Size(width, height);
            chartPanel.Size = new Size(width, height);
        }

        private void Chart_Form_Resize(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            chartPanel.Controls.Clear();
            AbstractChartBuilder chartBuilder = AbstractChartBuilder.getInstance(chartType);
            chartBuilder.setData(ticker, timeframe);
            chartBuilder.setDarkMode(darkMode);
            if (timeframe == "Intraday")
            {
                chartBuilder.processDataIntraday();
            }
            else
            {
                chartBuilder.processDataHistorical();
            }
            chart = chartBuilder.buildChart();
            this.Controls.Add(chart);
            chart.Size = new Size(this.width, this.height);
            chartPanel.Controls.Add(chart);
        }
    }
}
