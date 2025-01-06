namespace Financial_Project.Chart_Builder
{
    partial class Chart_Form
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
            chartPanel = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // chartPanel
            // 
            chartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartPanel.AutoSize = true;
            chartPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chartPanel.BackColor = SystemColors.ActiveCaption;
            chartPanel.Location = new Point(12, 12);
            chartPanel.MaximumSize = new Size(1880, 1040);
            chartPanel.MinimumSize = new Size(500, 250);
            chartPanel.Name = "chartPanel";
            chartPanel.Size = new Size(500, 250);
            chartPanel.TabIndex = 0;
            // 
            // Chart_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(chartPanel);
            MaximumSize = new Size(1920, 1080);
            Name = "Chart_Form";
            Padding = new Padding(0, 0, 10, 10);
            Size = new Size(525, 275);
            Resize += Chart_Form_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel chartPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}