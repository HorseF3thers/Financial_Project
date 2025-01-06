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
            chartBuilder.processData();
            chart = chartBuilder.buildChart();
            this.Controls.Add(chart);
            chart.MinimumSize = new Size(1212, 824);
            chartPanel.Controls.Add(chart);
        }
    }
}
