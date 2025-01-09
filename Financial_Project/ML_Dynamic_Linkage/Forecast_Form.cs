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
    public partial class Forecast_Form : Form, ML_IF
    {
        public readonly FormsPlot chart = new FormsPlot() { Dock = DockStyle.Fill };
        public Forecast_Form()
        {
            InitializeComponent();
        }

        public void createForm(double[] dataC, double[] dataLB, double[] dataUB)
        {
            double[] index = { 1, 2, 3, 4, 5 };
            var sp = chart.Plot.Add.Scatter(index, dataC, new ScottPlot.Color(0, 0, 255));
            sp.LineWidth = 4;
            sp.MarkerSize = 10;
            var sp1 = chart.Plot.Add.Scatter(index, dataLB, new ScottPlot.Color(255, 0, 0));
            sp1.LineWidth = 4;
            sp1.MarkerSize = 10;
            var sp2 = chart.Plot.Add.Scatter(index, dataUB, new ScottPlot.Color(0, 255, 0));
            sp2.LineWidth = 4;
            sp2.MarkerSize = 10;
            chart.Plot.Axes.AutoScale();
            chart.Refresh();
            chartPanel.Controls.Add(chart);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                chart.Plot.SavePng(filePath, 1142, 764);
            }
        }
    }
}
