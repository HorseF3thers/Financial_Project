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
        public readonly FormsPlot chart = new FormsPlot() { Dock = DockStyle.Fill };
        public Chart_Form(string chartType, string ticker, string timeframe, bool darkMode)
        {
            InitializeComponent();
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
            chart.Size = new Size(1202, 814);
            chartPanel.Controls.Add(chart);
        }

        private void Chart_Form_Resize(object sender, EventArgs e)
        {
            /**Chart_Form form = (Chart_Form)sender;
            chart.Width = form.Width;
            chart.Height = form.Height;**///come back to this later
        }
    }
}
