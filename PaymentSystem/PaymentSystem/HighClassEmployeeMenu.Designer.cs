namespace PaymentSystem
{
    partial class HighClassEmployeeMenu
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
            this.vacationButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.checkBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vacationButton
            // 
            this.vacationButton.Location = new System.Drawing.Point(221, 12);
            this.vacationButton.Name = "vacationButton";
            this.vacationButton.Size = new System.Drawing.Size(90, 65);
            this.vacationButton.TabIndex = 0;
            this.vacationButton.Text = "Ask for a vacation";
            this.vacationButton.UseVisualStyleBackColor = true;
            this.vacationButton.Click += new System.EventHandler(this.vacationButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(125, 12);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(90, 65);
            this.fillButton.TabIndex = 1;
            this.fillButton.Text = "Fill form";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            this.fillButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fillButton_MouseClick);
            // 
            // checkBt
            // 
            this.checkBt.Location = new System.Drawing.Point(12, 12);
            this.checkBt.Name = "checkBt";
            this.checkBt.Size = new System.Drawing.Size(107, 65);
            this.checkBt.TabIndex = 2;
            this.checkBt.Text = "Check report";
            this.checkBt.UseVisualStyleBackColor = true;
            this.checkBt.Click += new System.EventHandler(this.checkButton_Click);
            this.checkBt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkButton_MouseClick);
            // 
            // HighClassEmployeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 87);
            this.Controls.Add(this.checkBt);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.vacationButton);
            this.Name = "HighClassEmployeeMenu";
            this.Text = "HighClassEmployeeMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vacationButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button checkBt;
    }
}