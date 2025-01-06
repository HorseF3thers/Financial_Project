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
            checkBox1 = new CheckBox();
            mlCB = new ComboBox();
            openChartButton = new Button();
            openChartCB = new ComboBox();
            HeatmapButton = new Button();
            financial_Data_Button = new Button();
            financialDataCB = new ComboBox();
            SPY_data_panel.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // chart_panel
            // 
            chart_panel.BackColor = SystemColors.ActiveCaption;
            chart_panel.Location = new Point(365, 140);
            chart_panel.Name = "chart_panel";
            chart_panel.Size = new Size(1232, 844);
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
            forecast_ML_Button.Location = new Point(209, 551);
            forecast_ML_Button.Name = "forecast_ML_Button";
            forecast_ML_Button.Size = new Size(150, 50);
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
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1253, 104);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 29);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Darkmode";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // mlCB
            // 
            mlCB.FormattingEnabled = true;
            mlCB.Location = new Point(21, 561);
            mlCB.Name = "mlCB";
            mlCB.Size = new Size(182, 33);
            mlCB.TabIndex = 11;
            // 
            // openChartButton
            // 
            openChartButton.Location = new Point(209, 635);
            openChartButton.Name = "openChartButton";
            openChartButton.Size = new Size(150, 50);
            openChartButton.TabIndex = 12;
            openChartButton.Text = "Open Chart";
            openChartButton.UseVisualStyleBackColor = true;
            openChartButton.Click += openChartButton_Click;
            // 
            // openChartCB
            // 
            openChartCB.FormattingEnabled = true;
            openChartCB.Location = new Point(21, 645);
            openChartCB.Name = "openChartCB";
            openChartCB.Size = new Size(182, 33);
            openChartCB.TabIndex = 13;
            // 
            // HeatmapButton
            // 
            HeatmapButton.Location = new Point(209, 866);
            HeatmapButton.Name = "HeatmapButton";
            HeatmapButton.Size = new Size(150, 50);
            HeatmapButton.TabIndex = 14;
            HeatmapButton.Text = "Heatmap";
            HeatmapButton.UseVisualStyleBackColor = true;
            // 
            // financial_Data_Button
            // 
            financial_Data_Button.Location = new Point(209, 723);
            financial_Data_Button.Name = "financial_Data_Button";
            financial_Data_Button.Size = new Size(150, 50);
            financial_Data_Button.TabIndex = 15;
            financial_Data_Button.Text = "Financial Data";
            financial_Data_Button.UseVisualStyleBackColor = true;
            // 
            // financialDataCB
            // 
            financialDataCB.FormattingEnabled = true;
            financialDataCB.Location = new Point(21, 733);
            financialDataCB.Name = "financialDataCB";
            financialDataCB.Size = new Size(182, 33);
            financialDataCB.TabIndex = 16;
            // 
            // Main_Menu_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1609, 996);
            Controls.Add(financialDataCB);
            Controls.Add(financial_Data_Button);
            Controls.Add(HeatmapButton);
            Controls.Add(openChartCB);
            Controls.Add(openChartButton);
            Controls.Add(mlCB);
            Controls.Add(checkBox1);
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
        private CheckBox checkBox1;
        private ComboBox mlCB;
        private Button openChartButton;
        private ComboBox openChartCB;
        private Button HeatmapButton;
        private Button financial_Data_Button;
        private ComboBox financialDataCB;
        private RichTextBox richTextBox1;
    }
}