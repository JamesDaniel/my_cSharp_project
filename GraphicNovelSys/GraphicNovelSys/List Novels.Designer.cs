namespace GraphicNovelSys
{
    partial class List_Novels
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
            this.grdNovels = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdNovels)).BeginInit();
            this.SuspendLayout();
            // 
            // grdNovels
            // 
            this.grdNovels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNovels.Location = new System.Drawing.Point(36, 32);
            this.grdNovels.Name = "grdNovels";
            this.grdNovels.Size = new System.Drawing.Size(518, 274);
            this.grdNovels.TabIndex = 0;
            this.grdNovels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNovels_CellContentClick);
            // 
            // List_Novels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 341);
            this.Controls.Add(this.grdNovels);
            this.Name = "List_Novels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Novels";
            this.Load += new System.EventHandler(this.List_Novels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNovels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdNovels;

    }
}