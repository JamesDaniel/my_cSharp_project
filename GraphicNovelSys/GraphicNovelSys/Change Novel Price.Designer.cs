namespace GraphicNovelSys
{
    partial class Change_Novel_Price
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
            this.newPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdNovels = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdNovels)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newPrice
            // 
            this.newPrice.Location = new System.Drawing.Point(351, 253);
            this.newPrice.Name = "newPrice";
            this.newPrice.Size = new System.Drawing.Size(106, 20);
            this.newPrice.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "New Book Price €";
            // 
            // grdNovels
            // 
            this.grdNovels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNovels.Location = new System.Drawing.Point(12, 12);
            this.grdNovels.Name = "grdNovels";
            this.grdNovels.Size = new System.Drawing.Size(445, 233);
            this.grdNovels.TabIndex = 19;
            this.grdNovels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNovels_CellContentClick);
            this.grdNovels.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Change_Novel_Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 286);
            this.Controls.Add(this.grdNovels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPrice);
            this.Controls.Add(this.button1);
            this.Name = "Change_Novel_Price";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Novel_Price";
            this.Load += new System.EventHandler(this.Change_Novel_Price_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNovels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdNovels;
    }
}