namespace Financial_Project.ML_Dynamic_Linkage
{
    partial class Prediction_Form
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
            chartPanel.BackColor = SystemColors.ActiveBorder;
            chartPanel.BorderStyle = BorderStyle.Fixed3D;
            chartPanel.Location = new Point(232, 12);
            chartPanel.Name = "chartPanel";
            chartPanel.Size = new Size(734, 520);
            chartPanel.TabIndex = 0;
            // 
            // Prediction_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(978, 544);
            Controls.Add(chartPanel);
            Name = "Prediction_Form";
            Text = "Prediction_Form";
            ResumeLayout(false);
        }

        #endregion

        public Panel chartPanel;
    }
}