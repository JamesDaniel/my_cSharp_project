namespace GraphicNovelSys
{
    partial class Change_Member_Category
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
            this.checkBoxAuthor = new System.Windows.Forms.CheckBox();
            this.checkBoxReader = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxAuthor
            // 
            this.checkBoxAuthor.AutoSize = true;
            this.checkBoxAuthor.Location = new System.Drawing.Point(38, 12);
            this.checkBoxAuthor.Name = "checkBoxAuthor";
            this.checkBoxAuthor.Size = new System.Drawing.Size(57, 17);
            this.checkBoxAuthor.TabIndex = 1;
            this.checkBoxAuthor.Text = "Author";
            this.checkBoxAuthor.UseVisualStyleBackColor = true;
            // 
            // checkBoxReader
            // 
            this.checkBoxReader.AutoSize = true;
            this.checkBoxReader.Location = new System.Drawing.Point(159, 12);
            this.checkBoxReader.Name = "checkBoxReader";
            this.checkBoxReader.Size = new System.Drawing.Size(61, 17);
            this.checkBoxReader.TabIndex = 2;
            this.checkBoxReader.Text = "Reader";
            this.checkBoxReader.UseVisualStyleBackColor = true;
            // 
            // Change_Member_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 75);
            this.Controls.Add(this.checkBoxReader);
            this.Controls.Add(this.checkBoxAuthor);
            this.Controls.Add(this.button1);
            this.Name = "Change_Member_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Member_Category";
            this.Load += new System.EventHandler(this.Change_Member_Category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAuthor;
        private System.Windows.Forms.CheckBox checkBoxReader;
    }
}