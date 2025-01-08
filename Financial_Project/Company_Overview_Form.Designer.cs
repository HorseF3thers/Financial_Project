namespace Financial_Project
{
    partial class Company_Overview_Form
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
            companyDescription = new RichTextBox();
            tickerLabel = new Label();
            finDataBox = new RichTextBox();
            SuspendLayout();
            // 
            // companyDescription
            // 
            companyDescription.Location = new Point(12, 68);
            companyDescription.Name = "companyDescription";
            companyDescription.Size = new Size(466, 741);
            companyDescription.TabIndex = 0;
            companyDescription.Text = "";
            // 
            // tickerLabel
            // 
            tickerLabel.AutoSize = true;
            tickerLabel.Font = new Font("Segoe UI", 16F);
            tickerLabel.Location = new Point(12, 20);
            tickerLabel.Name = "tickerLabel";
            tickerLabel.Size = new Size(105, 45);
            tickerLabel.TabIndex = 1;
            tickerLabel.Text = "ticker:";
            // 
            // finDataBox
            // 
            finDataBox.Location = new Point(501, 68);
            finDataBox.Name = "finDataBox";
            finDataBox.Size = new Size(1052, 741);
            finDataBox.TabIndex = 2;
            finDataBox.Text = "";
            // 
            // Company_Overview_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1565, 821);
            Controls.Add(finDataBox);
            Controls.Add(tickerLabel);
            Controls.Add(companyDescription);
            Name = "Company_Overview_Form";
            Text = "Company_Overview_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox companyDescription;
        private Label tickerLabel;
        private RichTextBox finDataBox;
    }
}