namespace PaymentSystem
{
    partial class fillFormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fioTB = new System.Windows.Forms.TextBox();
            this.hoursTB = new System.Windows.Forms.TextBox();
            this.goodsTB = new System.Windows.Forms.TextBox();
            this.daysTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours worked";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Days worked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Goods sold";
            // 
            // fioTB
            // 
            this.fioTB.Location = new System.Drawing.Point(113, 72);
            this.fioTB.Name = "fioTB";
            this.fioTB.Size = new System.Drawing.Size(100, 22);
            this.fioTB.TabIndex = 4;
            // 
            // hoursTB
            // 
            this.hoursTB.Location = new System.Drawing.Point(113, 133);
            this.hoursTB.Name = "hoursTB";
            this.hoursTB.Size = new System.Drawing.Size(100, 22);
            this.hoursTB.TabIndex = 5;
            // 
            // goodsTB
            // 
            this.goodsTB.Location = new System.Drawing.Point(113, 205);
            this.goodsTB.Name = "goodsTB";
            this.goodsTB.Size = new System.Drawing.Size(100, 22);
            this.goodsTB.TabIndex = 6;
            // 
            // daysTB
            // 
            this.daysTB.Location = new System.Drawing.Point(113, 295);
            this.daysTB.Name = "daysTB";
            this.daysTB.Size = new System.Drawing.Size(100, 22);
            this.daysTB.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportTB
            // 
            this.reportTB.Location = new System.Drawing.Point(380, 69);
            this.reportTB.Multiline = true;
            this.reportTB.Name = "reportTB";
            this.reportTB.Size = new System.Drawing.Size(289, 357);
            this.reportTB.TabIndex = 9;
            this.reportTB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fill the form";
            // 
            // fillFormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 423);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.daysTB);
            this.Controls.Add(this.goodsTB);
            this.Controls.Add(this.hoursTB);
            this.Controls.Add(this.fioTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fillFormMenu";
            this.Text = "fillFormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fioTB;
        private System.Windows.Forms.TextBox hoursTB;
        private System.Windows.Forms.TextBox goodsTB;
        private System.Windows.Forms.TextBox daysTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox reportTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}