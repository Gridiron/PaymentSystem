namespace PaymentSystem
{
    partial class LowClassEmployeeMenu
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
            this.remakeButton = new System.Windows.Forms.Button();
            this.vacationButton = new System.Windows.Forms.Button();
            this.makeReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remakeButton
            // 
            this.remakeButton.Location = new System.Drawing.Point(174, 12);
            this.remakeButton.Name = "remakeButton";
            this.remakeButton.Size = new System.Drawing.Size(75, 48);
            this.remakeButton.TabIndex = 0;
            this.remakeButton.Text = "Remake report";
            this.remakeButton.UseVisualStyleBackColor = true;
            this.remakeButton.Click += new System.EventHandler(this.remakeButton_Click);
            // 
            // vacationButton
            // 
            this.vacationButton.Location = new System.Drawing.Point(93, 12);
            this.vacationButton.Name = "vacationButton";
            this.vacationButton.Size = new System.Drawing.Size(75, 48);
            this.vacationButton.TabIndex = 1;
            this.vacationButton.Text = "Ask for a vacation";
            this.vacationButton.UseVisualStyleBackColor = true;
            this.vacationButton.Click += new System.EventHandler(this.vacationButton_Click);
            // 
            // makeReportButton
            // 
            this.makeReportButton.Location = new System.Drawing.Point(12, 9);
            this.makeReportButton.Name = "makeReportButton";
            this.makeReportButton.Size = new System.Drawing.Size(75, 51);
            this.makeReportButton.TabIndex = 2;
            this.makeReportButton.Text = "Make report";
            this.makeReportButton.UseVisualStyleBackColor = true;
            this.makeReportButton.Click += new System.EventHandler(this.makeReportButton_Click);
            // 
            // LowClassEmployeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 69);
            this.Controls.Add(this.makeReportButton);
            this.Controls.Add(this.vacationButton);
            this.Controls.Add(this.remakeButton);
            this.Name = "LowClassEmployeeMenu";
            this.Text = "LowClassEmployeeMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button remakeButton;
        private System.Windows.Forms.Button vacationButton;
        private System.Windows.Forms.Button makeReportButton;
    }
}