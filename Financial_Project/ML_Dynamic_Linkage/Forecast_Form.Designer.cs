namespace Financial_Project.ML_Dynamic_Linkage
{
    partial class Forecast_Form
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
            saveButton = new Button();
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
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.BackColor = SystemColors.AppWorkspace;
            saveButton.Location = new Point(854, 551);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // Forecast_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1039, 609);
            Controls.Add(saveButton);
            Controls.Add(chartPanel);
            MinimumSize = new Size(1061, 665);
            Name = "Forecast_Form";
            Text = "Forecast_Form";
            ResumeLayout(false);
        }

        #endregion

        public Panel chartPanel;
        private Button saveButton;
    }
}