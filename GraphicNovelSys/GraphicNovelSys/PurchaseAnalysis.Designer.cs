namespace GraphicNovelSys
{
    partial class PurchaseAnalysis
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
            this.radioBtnAllTime = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMostExpensiveNovel = new System.Windows.Forms.TextBox();
            this.txtBoxLeastExpensiveNovel = new System.Windows.Forms.TextBox();
            this.txtBoxTotalCreditSpent = new System.Windows.Forms.TextBox();
            this.txtBoxAverageCostPerNovel = new System.Windows.Forms.TextBox();
            this.txtBoxTotalDownloads = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioBtnAllTime
            // 
            this.radioBtnAllTime.AutoSize = true;
            this.radioBtnAllTime.Location = new System.Drawing.Point(13, 13);
            this.radioBtnAllTime.Name = "radioBtnAllTime";
            this.radioBtnAllTime.Size = new System.Drawing.Size(62, 17);
            this.radioBtnAllTime.TabIndex = 1;
            this.radioBtnAllTime.TabStop = true;
            this.radioBtnAllTime.Text = "All Time";
            this.radioBtnAllTime.UseVisualStyleBackColor = true;
            this.radioBtnAllTime.CheckedChanged += new System.EventHandler(this.radioBtnAllTime_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Most Expensive Novel: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Least Expensive Novel: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Credit Spent: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Average Cost Per Novel: ";
            // 
            // txtBoxMostExpensiveNovel
            // 
            this.txtBoxMostExpensiveNovel.Location = new System.Drawing.Point(172, 122);
            this.txtBoxMostExpensiveNovel.Name = "txtBoxMostExpensiveNovel";
            this.txtBoxMostExpensiveNovel.Size = new System.Drawing.Size(125, 20);
            this.txtBoxMostExpensiveNovel.TabIndex = 9;
            // 
            // txtBoxLeastExpensiveNovel
            // 
            this.txtBoxLeastExpensiveNovel.Location = new System.Drawing.Point(172, 148);
            this.txtBoxLeastExpensiveNovel.Name = "txtBoxLeastExpensiveNovel";
            this.txtBoxLeastExpensiveNovel.Size = new System.Drawing.Size(125, 20);
            this.txtBoxLeastExpensiveNovel.TabIndex = 10;
            // 
            // txtBoxTotalCreditSpent
            // 
            this.txtBoxTotalCreditSpent.Location = new System.Drawing.Point(172, 174);
            this.txtBoxTotalCreditSpent.Name = "txtBoxTotalCreditSpent";
            this.txtBoxTotalCreditSpent.Size = new System.Drawing.Size(125, 20);
            this.txtBoxTotalCreditSpent.TabIndex = 11;
            // 
            // txtBoxAverageCostPerNovel
            // 
            this.txtBoxAverageCostPerNovel.Location = new System.Drawing.Point(172, 200);
            this.txtBoxAverageCostPerNovel.Name = "txtBoxAverageCostPerNovel";
            this.txtBoxAverageCostPerNovel.Size = new System.Drawing.Size(125, 20);
            this.txtBoxAverageCostPerNovel.TabIndex = 12;
            // 
            // txtBoxTotalDownloads
            // 
            this.txtBoxTotalDownloads.Location = new System.Drawing.Point(172, 96);
            this.txtBoxTotalDownloads.Name = "txtBoxTotalDownloads";
            this.txtBoxTotalDownloads.Size = new System.Drawing.Size(125, 20);
            this.txtBoxTotalDownloads.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Downloads";
            // 
            // PurchaseAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 231);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxTotalDownloads);
            this.Controls.Add(this.txtBoxAverageCostPerNovel);
            this.Controls.Add(this.txtBoxTotalCreditSpent);
            this.Controls.Add(this.txtBoxLeastExpensiveNovel);
            this.Controls.Add(this.txtBoxMostExpensiveNovel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnAllTime);
            this.Name = "PurchaseAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseAnalysis";
            this.Load += new System.EventHandler(this.PurchaseAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnAllTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMostExpensiveNovel;
        private System.Windows.Forms.TextBox txtBoxLeastExpensiveNovel;
        private System.Windows.Forms.TextBox txtBoxTotalCreditSpent;
        private System.Windows.Forms.TextBox txtBoxAverageCostPerNovel;
        private System.Windows.Forms.TextBox txtBoxTotalDownloads;
        private System.Windows.Forms.Label label6;
    }
}