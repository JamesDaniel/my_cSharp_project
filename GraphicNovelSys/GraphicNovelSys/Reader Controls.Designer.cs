namespace GraphicNovelSys
{
    partial class Reader_Controls
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnTopUp = new System.Windows.Forms.Button();
            this.txtBxCredit = new System.Windows.Forms.TextBox();
            this.BtnPurchaseAnalysis = new System.Windows.Forms.Button();
            this.btnIncomeAnalysis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change My Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "List Members";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Change My Category";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "List all Novels";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(155, 252);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Log Out";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // deleteAccount
            // 
            this.deleteAccount.Location = new System.Drawing.Point(12, 252);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(137, 23);
            this.deleteAccount.TabIndex = 10;
            this.deleteAccount.Text = "Delete My Account";
            this.deleteAccount.UseVisualStyleBackColor = true;
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(13, 129);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(259, 23);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download a Novel";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnTopUp
            // 
            this.btnTopUp.Location = new System.Drawing.Point(13, 223);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(136, 23);
            this.btnTopUp.TabIndex = 12;
            this.btnTopUp.Text = "Top Up Credit";
            this.btnTopUp.UseVisualStyleBackColor = true;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // txtBxCredit
            // 
            this.txtBxCredit.Enabled = false;
            this.txtBxCredit.Location = new System.Drawing.Point(155, 226);
            this.txtBxCredit.Name = "txtBxCredit";
            this.txtBxCredit.Size = new System.Drawing.Size(117, 20);
            this.txtBxCredit.TabIndex = 13;
            // 
            // BtnPurchaseAnalysis
            // 
            this.BtnPurchaseAnalysis.Location = new System.Drawing.Point(13, 159);
            this.BtnPurchaseAnalysis.Name = "BtnPurchaseAnalysis";
            this.BtnPurchaseAnalysis.Size = new System.Drawing.Size(259, 23);
            this.BtnPurchaseAnalysis.TabIndex = 14;
            this.BtnPurchaseAnalysis.Text = "Show Reader Purchase Analysis";
            this.BtnPurchaseAnalysis.UseVisualStyleBackColor = true;
            this.BtnPurchaseAnalysis.Click += new System.EventHandler(this.BtnPurchaseAnalysis_Click);
            // 
            // btnIncomeAnalysis
            // 
            this.btnIncomeAnalysis.Location = new System.Drawing.Point(13, 189);
            this.btnIncomeAnalysis.Name = "btnIncomeAnalysis";
            this.btnIncomeAnalysis.Size = new System.Drawing.Size(259, 23);
            this.btnIncomeAnalysis.TabIndex = 15;
            this.btnIncomeAnalysis.Text = "Show Author Income Analysis";
            this.btnIncomeAnalysis.UseVisualStyleBackColor = true;
            this.btnIncomeAnalysis.Click += new System.EventHandler(this.btnIncomeAnalysis_Click);
            // 
            // Reader_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Controls.Add(this.btnIncomeAnalysis);
            this.Controls.Add(this.BtnPurchaseAnalysis);
            this.Controls.Add(this.txtBxCredit);
            this.Controls.Add(this.btnTopUp);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.deleteAccount);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Reader_Controls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader_Controls";
            this.Load += new System.EventHandler(this.Reader_Controls_Load);
            this.VisibleChanged += new System.EventHandler(this.Reader_Controls_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button deleteAccount;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.TextBox txtBxCredit;
        private System.Windows.Forms.Button BtnPurchaseAnalysis;
        private System.Windows.Forms.Button btnIncomeAnalysis;
    }
}