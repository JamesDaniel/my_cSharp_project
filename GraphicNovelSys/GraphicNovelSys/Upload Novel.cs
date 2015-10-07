using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicNovelSys
{
    public partial class Upload_Novel : Form
    {
        private Hybrid_Controls parent1;
        private Author_Controls parent2;
        private Reader_Controls parent3;
        public Upload_Novel(Hybrid_Controls Parent1, Author_Controls Parent2, Reader_Controls Parent3)
        {
            parent1 = Parent1;
            parent2 = Parent2;
            parent3 = Parent3;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            DataSet value = Utilities.QueryDatabase("SELECT MAX(NOVELID) FROM Novels");
            string oldID = value.Tables[0].Rows[0][0].ToString();
            int newIDint = Convert.ToInt32(oldID) + 1;
            string newIDstring = Convert.ToString(newIDint);

            String currentDate = DateTime.Now.ToString("d/MMM/yyyy");
            Utilities.QueryDatabase("INSERT INTO Novels (novelid,creationdate,title,genre,price,path,memid) VALUES (" + newIDstring + ",'" + currentDate + "','" + title.Text + "','" + genre.Text + "','" + price.Text + "','" + fileLocation.Text + "'," + currentUser.GetMemId() + ")");
            
            
            // maybe change genre input so only certain genres can be entered (3 chars)
            

            if (parent1 != null)
                parent1.Visible = true;
            else if (parent2 != null)
                parent2.Visible = true;
            else if (parent2 != null)
                parent2.Visible = true;

            this.Close();
        }

        private void Upload_Novel_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (parent1 != null)
                parent1.Visible = true;
            else if (parent2 != null)
                parent2.Visible = true;
            else if (parent3 != null)
                parent3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            fileLocation.Text = openFileDialog1.FileName;
            openFileDialog1.Reset();

        }

    }
}
