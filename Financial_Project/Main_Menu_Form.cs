using ScottPlot;
using ScottPlot.WinForms;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financial_Project.Chart_Builder;

namespace Financial_Project
{
    public partial class Main_Menu_Form : Form
    {
        public readonly FormsPlot spy = new FormsPlot() { Dock = DockStyle.Fill };
        private API_Manager apiManager;
        public Main_Menu_Form()
        {
            InitializeComponent();

            apiManager = API_Manager.GetInstance();
            Chart_Form form = new Chart_Form("Line", "SPY", "Compact", false);
            form.Dock = DockStyle.Fill;
            form.AutoSize = true;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chart_panel.Controls.Add(form);
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

        private void openChartButton_Click(object sender, EventArgs e)
        {
            string ticker = openChartCB.Text;
            Thread thread = new Thread(() =>
            {
                Chart_Form chart = new Chart_Form("Line", ticker, "Compact", false);
                Form form = new Form();
                Panel panel = new Panel();
                panel.MinimumSize = new Size(1232, 844);
                chart.MinimumSize = new Size(1222, 834);
                form.AutoSize = true;
                panel.Controls.Add(chart);
                form.Controls.Add(panel);
                Application.Run(form);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
