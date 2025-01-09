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
using Financial_Project.ML_Dynamic_Linkage;
using System.Xaml.Permissions;

namespace Financial_Project
{
    public partial class Main_Menu_Form : Form
    {
        public readonly FormsPlot spy = new FormsPlot() { Dock = DockStyle.Fill };
        private API_Manager apiManager;
        string chartType = "Line";
        List<string> chartTypeList = new List<string> { "OHLC", "Candlestick", "Line" };
        List<string> duration = new List<string> { "Intraday", "Compact", "Full" };
        string durationString = "Compact";
        string durationStringTwo = "Compact";
        string selectedMLModel = "SPY_Daily_Forecast_ML";
        string financialDataTicker = "SPY";
        string insiderTicker = "NVDA";

        List<string> mlModels = new List<string> { "SPY_Daily_Forecast_ML", "SPY_Daily_ML", "SPY_Monthly_ML", "SPY_Weekly_ML", "XLB_Monthly_ML",
                                "XLC_Monthly_ML", "XLE_Monthly_ML", "XLF_Monthly_ML", "XLI_Monthly_ML", "XLK_Monthly_ML", "XLP_Monthly_ML",
                                "XLRE_Monthly_ML", "XLU_Monthly_ML", "XLV_Monthly_ML", "XLY_Monthly_ML"};

        public Main_Menu_Form()
        {
            InitializeComponent();

            apiManager = API_Manager.GetInstance();
            Chart_Form form = new Chart_Form("Candlestick", "SPY", "Compact", false);
            form.Dock = DockStyle.Fill;
            chart_panel.Controls.Add(form);

            durationCB.DataSource = duration;
            durationCBTwo.DataSource = duration;
            chartTypeCB.DataSource = chartTypeList;
            mlCB.DataSource = mlModels;
        }

        private void forecast_ML_Click(object sender, EventArgs e)
        {
            ML_choice mL_Choice = new ML_choice(selectedMLModel);
        }

        private void openChartButton_Click(object sender, EventArgs e)
        {
            string ticker = openChartCB.Text;

            Thread thread = new Thread(() =>
            {
                Chart_Form chart = new Chart_Form(chartType, ticker, durationStringTwo, false);
                Form form = new Form();
                Panel panel = new Panel();
                panel.Size = new Size(1242, 864);
                panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                panel.AutoSize = true;

                panel.BorderStyle = BorderStyle.Fixed3D;
                chart.Size = new Size(1202, 814);
                form.Size = new Size(1362, 974);

                panel.Controls.Add(chart);
                form.Controls.Add(panel);
                Application.Run(form);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OHLCcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (OHLCcheckbox.Checked)
            {
                chartType = "OHLC";
                candleCheckbox.Checked = false;
                lineCheckbox.Checked = false;
            }
        }

        private void candleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (candleCheckbox.Checked)
            {
                chartType = "Candlestick";
                OHLCcheckbox.Checked = false;
                lineCheckbox.Checked = false;
            }
        }

        private void lineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (lineCheckbox.Checked)
            {
                chartType = "Line";
                OHLCcheckbox.Checked = false;
                candleCheckbox.Checked = false;
            }
        }

        private void newChartButton_Click(object sender, EventArgs e)
        {
            if (tickerEntry.Text != "")
            {
                string ticker = tickerEntry.Text;
                string chartType = chartTypeCB.Text;
                bool darkMode = darkmodeCheck.Checked;
                Chart_Form chart = new Chart_Form(chartType, ticker, durationString, darkMode);
                chart.Dock = DockStyle.Fill;
                chart.AutoSize = true;
                chart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                chart_panel.Controls.Clear();
                chart_panel.Controls.Add(chart);

            }
        }

        private void chartTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartType = chartTypeCB.Text;
        }

        private void durationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            durationString = durationCB.Text;
        }

        private void durationCBTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            durationStringTwo = durationCBTwo.Text;
        }

        private void mlCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMLModel = mlCB.Text;
        }

        private void financial_Data_Button_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Company_Overview_Form company_Overview_Form = new Company_Overview_Form(financialDataTicker);
                Application.Run(company_Overview_Form);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void financialDataCB_TextChanged(object sender, EventArgs e)
        {
            financialDataTicker = financialDataCB.Text;
        }

        private void InsiderButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Chart_Form chart = new Chart_Form("Bar", insiderTicker, "Insider", false);
                Form form = new Form();
                Panel panel = new Panel();
                panel.MinimumSize = new Size(1820, 980);
                panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                panel.AutoSize = true;

                panel.BorderStyle = BorderStyle.Fixed3D;
                chart.MinimumSize = new Size(1800, 960);
                form.Size = new Size(1920, 1080);
                form.AutoSize = true;

                panel.Controls.Add(chart);
                form.Controls.Add(panel);
                chart.Refresh();
                Application.Run(form);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            insiderTicker = textBox1.Text;
        }
    }
}
