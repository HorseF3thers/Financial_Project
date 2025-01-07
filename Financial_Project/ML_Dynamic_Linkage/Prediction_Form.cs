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

namespace Financial_Project.ML_Dynamic_Linkage
{
    public partial class Prediction_Form : Form
    {
        public readonly FormsPlot chart = new FormsPlot() { Dock = DockStyle.Fill };

        public Prediction_Form()
        {
            InitializeComponent();
        }

        public void createForm(float output)
        {
            var xs = new double[] { 0 };
            var ys = new double[] { (double)output };
            var sp = chart.Plot.Add.Scatter(xs, ys);
            sp.LineWidth = 4;
            sp.MarkerSize = 10;
            chart.Plot.Axes.AutoScale();
            chart.Refresh();
            chartPanel.Controls.Add(chart);
        }
    }
}
