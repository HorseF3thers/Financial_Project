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
            SuspendLayout();
            // 
            // chartPanel
            // 
            chartPanel.BackColor = SystemColors.ActiveCaption;
            chartPanel.Location = new Point(12, 12);
            chartPanel.Name = "chartPanel";
            chartPanel.Size = new Size(1120, 717);
            chartPanel.TabIndex = 0;
            // 
            // Chart_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1144, 741);
            Controls.Add(chartPanel);
            Name = "Chart_Form";
            Text = "Chart_Form";
            ResumeLayout(false);
        }

        #endregion

        private Panel chartPanel;
    }
}