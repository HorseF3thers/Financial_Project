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
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            forecast_ML = new Button();
            tickerEntry = new ComboBox();
            tickerLabel = new Label();
            durationLabel = new Label();
            durationCB = new ComboBox();
            chartTypeLabel = new Label();
            chartTypeCB = new ComboBox();
            checkBox1 = new CheckBox();
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
            SPY_data_panel.Location = new Point(12, 140);
            SPY_data_panel.Name = "SPY_data_panel";
            SPY_data_panel.Size = new Size(347, 367);
            SPY_data_panel.TabIndex = 1;
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
            // forecast_ML
            // 
            forecast_ML.Location = new Point(209, 551);
            forecast_ML.Name = "forecast_ML";
            forecast_ML.Size = new Size(150, 50);
            forecast_ML.TabIndex = 2;
            forecast_ML.Text = "Forecast ML";
            forecast_ML.UseVisualStyleBackColor = true;
            forecast_ML.Click += forecast_ML_Click;
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
            // Main_Menu_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1609, 996);
            Controls.Add(checkBox1);
            Controls.Add(chartTypeCB);
            Controls.Add(chartTypeLabel);
            Controls.Add(durationCB);
            Controls.Add(durationLabel);
            Controls.Add(tickerLabel);
            Controls.Add(tickerEntry);
            Controls.Add(forecast_ML);
            Controls.Add(SPY_data_panel);
            Controls.Add(chart_panel);
            Name = "Main_Menu_Form";
            Text = "Main_Menu_Form";
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
        private Button forecast_ML;
        private ComboBox tickerEntry;
        private Label tickerLabel;
        private Label durationLabel;
        private ComboBox durationCB;
        private Label chartTypeLabel;
        private ComboBox chartTypeCB;
        private CheckBox checkBox1;
    }
}