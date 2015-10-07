namespace GraphicNovelSys
{
    partial class Top_Up_Credit
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCurrentCredit = new System.Windows.Forms.TextBox();
            this.txtBoxTopUpAmount = new System.Windows.Forms.TextBox();
            this.txtBoxCreditAfterTopUp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Top Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(151, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnCancel_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Credit: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top Up Amount: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credit After Top Up";
            // 
            // txtBoxCurrentCredit
            // 
            this.txtBoxCurrentCredit.Enabled = false;
            this.txtBoxCurrentCredit.Location = new System.Drawing.Point(151, 6);
            this.txtBoxCurrentCredit.Name = "txtBoxCurrentCredit";
            this.txtBoxCurrentCredit.Size = new System.Drawing.Size(121, 20);
            this.txtBoxCurrentCredit.TabIndex = 5;
            // 
            // txtBoxTopUpAmount
            // 
            this.txtBoxTopUpAmount.Location = new System.Drawing.Point(151, 29);
            this.txtBoxTopUpAmount.Name = "txtBoxTopUpAmount";
            this.txtBoxTopUpAmount.Size = new System.Drawing.Size(121, 20);
            this.txtBoxTopUpAmount.TabIndex = 6;
            this.txtBoxTopUpAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxTopUpAmount_KeyUp);
            // 
            // txtBoxCreditAfterTopUp
            // 
            this.txtBoxCreditAfterTopUp.Enabled = false;
            this.txtBoxCreditAfterTopUp.Location = new System.Drawing.Point(151, 55);
            this.txtBoxCreditAfterTopUp.Name = "txtBoxCreditAfterTopUp";
            this.txtBoxCreditAfterTopUp.Size = new System.Drawing.Size(121, 20);
            this.txtBoxCreditAfterTopUp.TabIndex = 7;
            // 
            // Top_Up_Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.txtBoxCreditAfterTopUp);
            this.Controls.Add(this.txtBoxTopUpAmount);
            this.Controls.Add(this.txtBoxCurrentCredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Name = "Top_Up_Credit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top_Up_Credit";
            this.Load += new System.EventHandler(this.Top_Up_Credit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCurrentCredit;
        private System.Windows.Forms.TextBox txtBoxTopUpAmount;
        private System.Windows.Forms.TextBox txtBoxCreditAfterTopUp;
    }
}