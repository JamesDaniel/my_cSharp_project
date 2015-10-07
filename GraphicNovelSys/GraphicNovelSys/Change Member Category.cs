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
    public partial class Change_Member_Category : Form
    {
        private Hybrid_Controls parent1;
        private Author_Controls parent2;
        private Reader_Controls parent3;
        public Change_Member_Category(Hybrid_Controls Parent1, Author_Controls Parent2, Reader_Controls Parent3)
        {
            parent1 = Parent1;
            parent2 = Parent2;
            parent3 = Parent3;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parent1 != null)
            {
                parent1.Visible = true;
                if (checkBoxAuthor.Checked == true && checkBoxReader.Checked == true)
                {
                    MessageBox.Show("No changes made. You are already an Author and Reader.");
                }
                else if (checkBoxAuthor.Checked)
                {
                    Utilities.QueryDatabase("DELETE FROM Categories WHERE MemID = " + currentUser.GetMemId());
                    Utilities.QueryDatabase("INSERT INTO Categories (MemID, CATCODE, Description) VALUES (" + currentUser.GetMemId() +
                                                                                                          ",'A','This is an author')");
                    MessageBox.Show("Changes made. You are now an Author");
                    Author_Controls ns = new Author_Controls(parent1.getFirstParent());
                    ns.Show();
                    this.Close();
                }
                else if (checkBoxReader.Checked)
                {
                    Utilities.QueryDatabase("DELETE FROM Categories WHERE MemID = " + currentUser.GetMemId());
                    Utilities.QueryDatabase("INSERT INTO Categories (MemID, CATCODE, Description) VALUES (" + currentUser.GetMemId() +
                                                                                                          ",'R','This is a reader')");
                    MessageBox.Show("Changes made. You are now a Reader");
                }
                else
                    MessageBox.Show("No changes Made");
            }
            if (parent2 != null)
            {
                parent2.Visible = true;
                if (checkBoxAuthor.Checked == true && checkBoxReader.Checked == true)
                {
                    Utilities.QueryDatabase("DELETE FROM Categories WHERE MemID = " + currentUser.GetMemId());
                    Utilities.QueryDatabase("INSERT INTO Categories (MemID, CATCODE, Description) VALUES (" + currentUser.GetMemId() +
                                                                                                          ",'A','This is an author')");
                    Utilities.QueryDatabase("INSERT INTO Categories (MemID, CATCODE, Description) VALUES (" + currentUser.GetMemId() +
                                                                                                         ",'R','This is a reader')");
                    MessageBox.Show("Changes made. You are now an Author and a Reader.");
                }
                else if (checkBoxAuthor.Checked)
                {
                    MessageBox.Show("No changes made. You are already an Author.");
                }
                else if (checkBoxReader.Checked)
                {
                    Utilities.QueryDatabase("DELETE FROM Categories WHERE MemID = " + currentUser.GetMemId());
                    Utilities.QueryDatabase("INSERT INTO Categories (MemID, CATCODE, Description) VALUES (" + currentUser.GetMemId() +
                                                                                                          ",'R','This is a reader')");
                    MessageBox.Show("Changes made. You are now a Reader.");
                }
                else
                    MessageBox.Show("No changes Made");
            }
            if (parent3 != null)
            {
                parent3.Visible = true;
                if (checkBoxAuthor.Checked == true && checkBoxReader.Checked == true)
                {
                    Utilities.QueryDatabase("DELETE FROM Categories WHERE MemID = " + currentUser.GetMemId());
                    Utilities.QueryDatabase("INSERT INTO Categories (MemID, CATCODE, Description) VALUES (" + currentUser.GetMemId() +
                                                                                                          ",'A','This is an author')");
                    Utilities.QueryDatabase("INSERT INTO Categories (MemID, CATCODE, Description) VALUES (" + currentUser.GetMemId() +
                                                                                                         ",'R','This is a reader')");
                    MessageBox.Show("Changes made. You are now an Author and Reader");
                }
                else if (checkBoxAuthor.Checked)
                {
                    Utilities.QueryDatabase("DELETE FROM Categories WHERE MemID = " + currentUser.GetMemId());
                    Utilities.QueryDatabase("INSERT INTO Categories (MemID, CATCODE, Description) VALUES (" + currentUser.GetMemId() +
                                                                                                          ",'A','This is an author')");
                    MessageBox.Show("Changes made. You are now an Author.");
                }
                else if (checkBoxReader.Checked)
                {
                    MessageBox.Show("No changes made. You are already a Reader.");
                }
                else
                    MessageBox.Show("No changes Made");
            }

            this.Close();
        }

        private void Change_Member_Category_Load(object sender, EventArgs e)
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
    }
}
