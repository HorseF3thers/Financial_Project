namespace Financial_Project
{
    partial class Main_Menu_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            chart_panel = new Panel();
            SPY_data_panel = new Panel();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            forecast_ML_Button = new Button();
            tickerEntry = new ComboBox();
            tickerLabel = new Label();
            durationLabel = new Label();
            durationCB = new ComboBox();
            chartTypeLabel = new Label();
            chartTypeCB = new ComboBox();
            darkmodeCheck = new CheckBox();
            mlCB = new ComboBox();
            openChartButton = new Button();
            openChartCB = new ComboBox();
            InsiderButton = new Button();
            financial_Data_Button = new Button();
            financialDataCB = new ComboBox();
            lineCheckbox = new CheckBox();
            OHLCcheckbox = new CheckBox();
            candleCheckbox = new CheckBox();
            newChartButton = new Button();
            durationCBTwo = new ComboBox();
            textBox1 = new TextBox();
            SPY_data_panel.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // chart_panel
            // 
            chart_panel.AutoSize = true;
            chart_panel.BackColor = SystemColors.ActiveCaption;
            chart_panel.Location = new Point(365, 140);
            chart_panel.Name = "chart_panel";
            chart_panel.Size = new Size(1360, 925);
            chart_panel.TabIndex = 0;
            // 
            // SPY_data_panel
            // 
            SPY_data_panel.BackColor = SystemColors.ActiveCaption;
            SPY_data_panel.Controls.Add(richTextBox1);
            SPY_data_panel.Location = new Point(12, 140);
            SPY_data_panel.Name = "SPY_data_panel";
            SPY_data_panel.Size = new Size(347, 367);
            SPY_data_panel.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(9, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(323, 341);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(244, 68);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(243, 32);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(243, 32);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // forecast_ML_Button
            // 
            forecast_ML_Button.Location = new Point(240, 551);
            forecast_ML_Button.Name = "forecast_ML_Button";
            forecast_ML_Button.Size = new Size(119, 50);
            forecast_ML_Button.TabIndex = 2;
            forecast_ML_Button.Text = "Forecast ML";
            forecast_ML_Button.UseVisualStyleBackColor = true;
            forecast_ML_Button.Click += forecast_ML_Click;
            // 
            // tickerEntry
            // 
            tickerEntry.FormattingEnabled = true;
            tickerEntry.Location = new Point(436, 101);
            tickerEntry.Name = "tickerEntry";
            tickerEntry.Size = new Size(182, 33);
            tickerEntry.TabIndex = 3;
            // 
            // tickerLabel
            // 
            tickerLabel.AutoSize = true;
            tickerLabel.Location = new Point(369, 104);
            tickerLabel.Name = "tickerLabel";
            tickerLabel.Size = new Size(61, 25);
            tickerLabel.TabIndex = 4;
            tickerLabel.Text = "Ticker:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(635, 104);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(85, 25);
            durationLabel.TabIndex = 5;
            durationLabel.Text = "Duration:";
            // 
            // durationCB
            // 
            durationCB.FormattingEnabled = true;
            durationCB.Location = new Point(726, 101);
            durationCB.Name = "durationCB";
            durationCB.Size = new Size(182, 33);
            durationCB.TabIndex = 6;
            durationCB.SelectedIndexChanged += durationCB_SelectedIndexChanged;
            // 
            // chartTypeLabel
            // 
            chartTypeLabel.AutoSize = true;
            chartTypeLabel.Location = new Point(931, 104);
            chartTypeLabel.Name = "chartTypeLabel";
            chartTypeLabel.Size = new Size(100, 25);
            chartTypeLabel.TabIndex = 7;
            chartTypeLabel.Text = "Chart Type:";
            // 
            // chartTypeCB
            // 
            chartTypeCB.FormattingEnabled = true;
            chartTypeCB.Location = new Point(1037, 101);
            chartTypeCB.Name = "chartTypeCB";
            chartTypeCB.Size = new Size(182, 33);
            chartTypeCB.TabIndex = 8;
            chartTypeCB.Text = "Line";
            chartTypeCB.SelectedIndexChanged += chartTypeCB_SelectedIndexChanged;
            // 
            // darkmodeCheck
            // 
            darkmodeCheck.AutoSize = true;
            darkmodeCheck.Location = new Point(1253, 104);
            darkmodeCheck.Name = "darkmodeCheck";
            darkmodeCheck.Size = new Size(122, 29);
            darkmodeCheck.TabIndex = 10;
            darkmodeCheck.Text = "Darkmode";
            darkmodeCheck.UseVisualStyleBackColor = true;
            // 
            // mlCB
            // 
            mlCB.FormattingEnabled = true;
            mlCB.Location = new Point(21, 561);
            mlCB.Name = "mlCB";
            mlCB.Size = new Size(213, 33);
            mlCB.TabIndex = 11;
            mlCB.SelectedIndexChanged += mlCB_SelectedIndexChanged;
            // 
            // openChartButton
            // 
            openChartButton.Location = new Point(240, 613);
            openChartButton.Name = "openChartButton";
            openChartButton.Size = new Size(119, 50);
            openChartButton.TabIndex = 12;
            openChartButton.Text = "Open Chart";
            openChartButton.UseVisualStyleBackColor = true;
            openChartButton.Click += openChartButton_Click;
            // 
            // openChartCB
            // 
            openChartCB.FormattingEnabled = true;
            openChartCB.Location = new Point(21, 620);
            openChartCB.Name = "openChartCB";
            openChartCB.Size = new Size(213, 33);
            openChartCB.TabIndex = 13;
            // 
            // InsiderButton
            // 
            InsiderButton.Location = new Point(209, 866);
            InsiderButton.Name = "InsiderButton";
            InsiderButton.Size = new Size(150, 50);
            InsiderButton.TabIndex = 14;
            InsiderButton.Text = "Insider";
            InsiderButton.UseVisualStyleBackColor = true;
            InsiderButton.Click += InsiderButton_Click;
            // 
            // financial_Data_Button
            // 
            financial_Data_Button.Location = new Point(218, 755);
            financial_Data_Button.Name = "financial_Data_Button";
            financial_Data_Button.Size = new Size(141, 50);
            financial_Data_Button.TabIndex = 15;
            financial_Data_Button.Text = "Financial Data";
            financial_Data_Button.UseVisualStyleBackColor = true;
            financial_Data_Button.Click += financial_Data_Button_Click;
            // 
            // financialDataCB
            // 
            financialDataCB.FormattingEnabled = true;
            financialDataCB.Location = new Point(21, 765);
            financialDataCB.Name = "financialDataCB";
            financialDataCB.Size = new Size(182, 33);
            financialDataCB.TabIndex = 16;
            financialDataCB.TextChanged += financialDataCB_TextChanged;
            // 
            // lineCheckbox
            // 
            lineCheckbox.AutoSize = true;
            lineCheckbox.Checked = true;
            lineCheckbox.CheckState = CheckState.Checked;
            lineCheckbox.Location = new Point(21, 707);
            lineCheckbox.Name = "lineCheckbox";
            lineCheckbox.Size = new Size(69, 29);
            lineCheckbox.TabIndex = 17;
            lineCheckbox.Text = "Line";
            lineCheckbox.UseVisualStyleBackColor = true;
            lineCheckbox.CheckedChanged += lineCheckbox_CheckedChanged;
            // 
            // OHLCcheckbox
            // 
            OHLCcheckbox.AutoSize = true;
            OHLCcheckbox.Location = new Point(110, 707);
            OHLCcheckbox.Name = "OHLCcheckbox";
            OHLCcheckbox.Size = new Size(83, 29);
            OHLCcheckbox.TabIndex = 18;
            OHLCcheckbox.Text = "OHLC";
            OHLCcheckbox.UseVisualStyleBackColor = true;
            OHLCcheckbox.CheckedChanged += OHLCcheckbox_CheckedChanged;
            // 
            // candleCheckbox
            // 
            candleCheckbox.AutoSize = true;
            candleCheckbox.Location = new Point(218, 707);
            candleCheckbox.Name = "candleCheckbox";
            candleCheckbox.Size = new Size(127, 29);
            candleCheckbox.TabIndex = 19;
            candleCheckbox.Text = "Candlestick";
            candleCheckbox.UseVisualStyleBackColor = true;
            candleCheckbox.CheckedChanged += candleCheckbox_CheckedChanged;
            // 
            // newChartButton
            // 
            newChartButton.Location = new Point(1403, 99);
            newChartButton.Name = "newChartButton";
            newChartButton.Size = new Size(112, 34);
            newChartButton.TabIndex = 20;
            newChartButton.Text = "New Chart";
            newChartButton.UseVisualStyleBackColor = true;
            newChartButton.Click += newChartButton_Click;
            // 
            // durationCBTwo
            // 
            durationCBTwo.FormattingEnabled = true;
            durationCBTwo.Location = new Point(21, 668);
            durationCBTwo.Name = "durationCBTwo";
            durationCBTwo.Size = new Size(213, 33);
            durationCBTwo.TabIndex = 21;
            durationCBTwo.SelectedIndexChanged += durationCBTwo_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 876);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 22;
            textBox1.Text = "Ticker";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Main_Menu_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1737, 1077);
            Controls.Add(textBox1);
            Controls.Add(durationCBTwo);
            Controls.Add(newChartButton);
            Controls.Add(candleCheckbox);
            Controls.Add(OHLCcheckbox);
            Controls.Add(lineCheckbox);
            Controls.Add(financialDataCB);
            Controls.Add(financial_Data_Button);
            Controls.Add(InsiderButton);
            Controls.Add(openChartCB);
            Controls.Add(openChartButton);
            Controls.Add(mlCB);
            Controls.Add(darkmodeCheck);
            Controls.Add(chartTypeCB);
            Controls.Add(chartTypeLabel);
            Controls.Add(durationCB);
            Controls.Add(durationLabel);
            Controls.Add(tickerLabel);
            Controls.Add(tickerEntry);
            Controls.Add(forecast_ML_Button);
            Controls.Add(SPY_data_panel);
            Controls.Add(chart_panel);
            Name = "Main_Menu_Form";
            Text = "Main_Menu_Form";
            SPY_data_panel.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel chart_panel;
        private Panel SPY_data_panel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Button forecast_ML_Button;
        private ComboBox tickerEntry;
        private Label tickerLabel;
        private Label durationLabel;
        private ComboBox durationCB;
        private Label chartTypeLabel;
        private ComboBox chartTypeCB;
        private CheckBox darkmodeCheck;
        private ComboBox mlCB;
        private Button openChartButton;
        private ComboBox openChartCB;
        private Button InsiderButton;
        private Button financial_Data_Button;
        private ComboBox financialDataCB;
        private RichTextBox richTextBox1;
        private CheckBox lineCheckbox;
        private CheckBox OHLCcheckbox;
        private CheckBox candleCheckbox;
        private Button newChartButton;
        private ComboBox durationCBTwo;
        private TextBox textBox1;
    }
}