namespace GraphicNovelSys
{
    partial class IncomeAnalysis
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxTotalUploads = new System.Windows.Forms.TextBox();
            this.txtBoxAverageCostPerNovel = new System.Windows.Forms.TextBox();
            this.txtBoxTotalCreditEarned = new System.Windows.Forms.TextBox();
            this.txtBoxLeastExpensiveNovelPrice = new System.Windows.Forms.TextBox();
            this.txtBoxMostExpensiveNovelPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtnAllTime = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Total Uploads";
            // 
            // txtBoxTotalUploads
            // 
            this.txtBoxTotalUploads.Location = new System.Drawing.Point(171, 106);
            this.txtBoxTotalUploads.Name = "txtBoxTotalUploads";
            this.txtBoxTotalUploads.Size = new System.Drawing.Size(125, 20);
            this.txtBoxTotalUploads.TabIndex = 25;
            // 
            // txtBoxAverageCostPerNovel
            // 
            this.txtBoxAverageCostPerNovel.Location = new System.Drawing.Point(171, 210);
            this.txtBoxAverageCostPerNovel.Name = "txtBoxAverageCostPerNovel";
            this.txtBoxAverageCostPerNovel.Size = new System.Drawing.Size(125, 20);
            this.txtBoxAverageCostPerNovel.TabIndex = 24;
            // 
            // txtBoxTotalCreditEarned
            // 
            this.txtBoxTotalCreditEarned.Location = new System.Drawing.Point(171, 184);
            this.txtBoxTotalCreditEarned.Name = "txtBoxTotalCreditEarned";
            this.txtBoxTotalCreditEarned.Size = new System.Drawing.Size(125, 20);
            this.txtBoxTotalCreditEarned.TabIndex = 23;
            // 
            // txtBoxLeastExpensiveNovelPrice
            // 
            this.txtBoxLeastExpensiveNovelPrice.Location = new System.Drawing.Point(171, 158);
            this.txtBoxLeastExpensiveNovelPrice.Name = "txtBoxLeastExpensiveNovelPrice";
            this.txtBoxLeastExpensiveNovelPrice.Size = new System.Drawing.Size(125, 20);
            this.txtBoxLeastExpensiveNovelPrice.TabIndex = 22;
            // 
            // txtBoxMostExpensiveNovelPrice
            // 
            this.txtBoxMostExpensiveNovelPrice.Location = new System.Drawing.Point(171, 132);
            this.txtBoxMostExpensiveNovelPrice.Name = "txtBoxMostExpensiveNovelPrice";
            this.txtBoxMostExpensiveNovelPrice.Size = new System.Drawing.Size(125, 20);
            this.txtBoxMostExpensiveNovelPrice.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Average Credit Earned: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total Credit Earned: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Least Expensive Novel: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Most Expensive Novel Price: ";
            // 
            // radioBtnAllTime
            // 
            this.radioBtnAllTime.AutoSize = true;
            this.radioBtnAllTime.Location = new System.Drawing.Point(12, 23);
            this.radioBtnAllTime.Name = "radioBtnAllTime";
            this.radioBtnAllTime.Size = new System.Drawing.Size(62, 17);
            this.radioBtnAllTime.TabIndex = 16;
            this.radioBtnAllTime.TabStop = true;
            this.radioBtnAllTime.Text = "All Time";
            this.radioBtnAllTime.UseVisualStyleBackColor = true;
            this.radioBtnAllTime.CheckedChanged += new System.EventHandler(this.radioBtnAllTime_CheckedChanged);
            // 
            // IncomeAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 244);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxTotalUploads);
            this.Controls.Add(this.txtBoxAverageCostPerNovel);
            this.Controls.Add(this.txtBoxTotalCreditEarned);
            this.Controls.Add(this.txtBoxLeastExpensiveNovelPrice);
            this.Controls.Add(this.txtBoxMostExpensiveNovelPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnAllTime);
            this.Name = "IncomeAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncomeAnalysis";
            this.Load += new System.EventHandler(this.IncomeAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxTotalUploads;
        private System.Windows.Forms.TextBox txtBoxAverageCostPerNovel;
        private System.Windows.Forms.TextBox txtBoxTotalCreditEarned;
        private System.Windows.Forms.TextBox txtBoxLeastExpensiveNovelPrice;
        private System.Windows.Forms.TextBox txtBoxMostExpensiveNovelPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtnAllTime;

    }
}