using ScottPlot;
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

namespace Financial_Project
{
    public partial class Main_Menu_Form : Form
    {
        public readonly FormsPlot spy = new FormsPlot() { Dock = DockStyle.Fill };
        public Main_Menu_Form()
        {
            InitializeComponent();
            chart_panel.Controls.Add(spy);

            var prices = Generate.RandomOHLCs(90);
            spy.Plot.Add.Candlestick(prices);
            spy.Plot.Axes.DateTimeTicksBottom();
        }

        private void forecast_ML_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                SPYForecastForm form = new SPYForecastForm();
                Application.Run(form);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
