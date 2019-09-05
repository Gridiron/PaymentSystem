namespace PaymentSystem
{
    partial class removeMenu
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
            this.rmBt = new System.Windows.Forms.Button();
            this.fioTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "FIO";
            // 
            // rmBt
            // 
            this.rmBt.Location = new System.Drawing.Point(123, 212);
            this.rmBt.Name = "rmBt";
            this.rmBt.Size = new System.Drawing.Size(75, 23);
            this.rmBt.TabIndex = 2;
            this.rmBt.Text = "Remove";
            this.rmBt.UseVisualStyleBackColor = true;
            this.rmBt.Click += new System.EventHandler(this.rmBt_Click);
            // 
            // fioTB
            // 
            this.fioTB.Location = new System.Drawing.Point(114, 126);
            this.fioTB.Name = "fioTB";
            this.fioTB.Size = new System.Drawing.Size(100, 22);
            this.fioTB.TabIndex = 3;
            // 
            // removeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 292);
            this.Controls.Add(this.fioTB);
            this.Controls.Add(this.rmBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "removeMenu";
            this.Text = "removeMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rmBt;
        private System.Windows.Forms.TextBox fioTB;
    }
}