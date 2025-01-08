using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Project
{
    public partial class Company_Overview_Form : Form
    {
        public Company_Overview_Form(string ticker)
        {
            InitializeComponent();

            API_Manager aM = API_Manager.GetInstance();
            tickerLabel.Text = ticker;
            JsonDocument data = aM.getCompanyOverview(ticker);
            companyDescription.Text = data.RootElement.GetProperty("Description").GetString();
            string finData = data.RootElement.GetProperty("AssetType").GetString();
            finData += "\nName: " + data.RootElement.GetProperty("Name").GetString();
            finData += "\nSector: " + data.RootElement.GetProperty("Sector").GetString();
            finData += "\nIndustry: " + data.RootElement.GetProperty("Industry").GetString();
            finData += "\nMarket Cap: " + data.RootElement.GetProperty("MarketCapitalization").GetString();
            finData += "\nEDITDA: " + data.RootElement.GetProperty("EBITDA").GetString();
            finData += "\nPERatio: " + data.RootElement.GetProperty("PERatio").GetString();
            finData += "\nBookValue: " + data.RootElement.GetProperty("BookValue").GetString();
            finData += "\nDividend Per Share: " + data.RootElement.GetProperty("DividendPerShare").GetString();
            finData += "\nDividend Yield: " + data.RootElement.GetProperty("DividendYield").GetString();
            finData += "\nEPS: " + data.RootElement.GetProperty("EPS").GetString();
            finData += "\nRevenue TTM: " + data.RootElement.GetProperty("RevenueTTM").GetString();
            finData += "\nGross Profit TTM: " + data.RootElement.GetProperty("GrossProfitTTM").GetString();
            finData += "\nQuarterly Earnings Growth YOY: " + data.RootElement.GetProperty("QuarterlyEarningsGrowthYOY").GetString();
            finData += "\nQuarterly Revenue Growth YOY: " + data.RootElement.GetProperty("QuarterlyRevenueGrowthYOY").GetString();
            finData += "\nAnalyst Target Price: " + data.RootElement.GetProperty("AnalystTargetPrice").GetString();
            finData += "\nTrailing PE: " + data.RootElement.GetProperty("TrailingPE").GetString();
            finData += "\nForward PE: " + data.RootElement.GetProperty("ForwardPE").GetString();
            finData += "\nBeta: " + data.RootElement.GetProperty("Beta").GetString();
            finData += "\n52 Week High: " + data.RootElement.GetProperty("52WeekHigh").GetString();
            finData += "\n52 Week Low: " + data.RootElement.GetProperty("52WeekLow").GetString();
            finData += "\n50 Day Moving Average: " + data.RootElement.GetProperty("50DayMovingAverage").GetString();
            finData += "\n200 Day Moving Average: " + data.RootElement.GetProperty("200DayMovingAverage").GetString();
            finData += "\nDividend Date: " + data.RootElement.GetProperty("DividendDate").GetString();
            finData += "\nEx Dividend Date: " + data.RootElement.GetProperty("ExDividendDate").GetString();
            finDataBox.Text = finData;
        }
    }
}
