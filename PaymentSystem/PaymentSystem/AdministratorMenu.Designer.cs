namespace PaymentSystem
{
    partial class AdministratorMenu
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
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vacationButton
            // 
            this.vacationButton.Location = new System.Drawing.Point(12, 12);
            this.vacationButton.Name = "vacationButton";
            this.vacationButton.Size = new System.Drawing.Size(75, 80);
            this.vacationButton.TabIndex = 0;
            this.vacationButton.Text = "Ask for a vacation";
            this.vacationButton.UseVisualStyleBackColor = true;
            this.vacationButton.Click += new System.EventHandler(this.vacationButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(93, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 80);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add new employee";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(174, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(83, 80);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete employee";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AdministratorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 104);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.vacationButton);
            this.Name = "AdministratorMenu";
            this.Text = "AdministratorMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vacationButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
    }
}