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
    public partial class Change_Member_Details : Form
    {
        private Hybrid_Controls parent1;
        private Author_Controls parent2;
        private Reader_Controls parent3;
        public Change_Member_Details(Hybrid_Controls Parent1, Author_Controls Parent2, Reader_Controls Parent3)
        {
            parent1 = Parent1;
            parent2 = Parent2;
            parent3 = Parent3;
            InitializeComponent();
        }

        private void Change_Member_Details_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataSet val = Utilities.QueryDatabase("SELECT MAX(MemID) FROM Members");
            //string oldID = value.Tables[0].Rows[0][0].ToString();
            //int newIDint = Convert.ToInt32(oldID) + 1;
            int ID = currentUser.GetMemId();
            //string newIDstring = Convert.ToString(newIDint);   //http://stackoverflow.com/questions/8035502/what-is-the-best-way-to-get-a-single-value-out-of-a-dataset
            string IDstring = Convert.ToString(ID);
            //MessageBox.Show(Convert.ToString(newID));


            if (capatchField.Text.Equals(""))
            {
                MessageBox.Show("invalid capatch! first");
            }
            else if (capatchField.Text.Equals("branded"))
            {
                //MessageBox.Show(inUname.Text + "\n" + inFname.Text + "\n" + inLname.Text);
                //Utilities.QueryDatabase("UPDATE Members SET UNAME = '" + inUname.Text + /*"', FNAME ='" + inFname.Text + "', LNAME = '" + inLname.Text + "', EMAIL = '" + inEmail.Text + "', PASSWORD = '" + inPassword.Text +*/ "' WHERE MemID = " + currentUser.GetMemId());
                Utilities.QueryDatabase("UPDATE Members SET UNAME = '" + inUname.Text + "', FNAME ='" + inFname.Text + "', LNAME = '" + inLname.Text + "', EMAIL = '" + inEmail.Text + "', PASSWORD = '" + inPassword.Text + "' WHERE MemID = " + currentUser.GetMemId());
                Utilities.QueryDatabase("DELETE FROM Categories WHERE MemID = " + currentUser.GetMemId());



                //DELETE FROM table_name
                //WHERE some_column=some_value; 
                
                MessageBox.Show("User Member Details Updated");

                if (checkReader.Checked)
                    Utilities.QueryDatabase("INSERT INTO Categories (MemID, CATCODE, Description) VALUES (" + currentUser.GetMemId() +
                                                                                                          ",'R','This is a reader')");
                if (checkAuthor.Checked)
                    Utilities.QueryDatabase("INSERT INTO Categories (MemID, CATCODE, Description) VALUES (" + currentUser.GetMemId() +
                                                                                                          ",'A','This is an author')");



                /*
                if (String.Compare(checkReader.Checked.ToString(), "True") == 0)
                {
                    //MessageBox.Show("you checked the reader box");
                    Utilities.QueryDatabase("UPDATE Categories SET (" + newIDstring + ",'R','This is a reader')");
                }
                if (String.Compare(checkAuthor.Checked.ToString(), "True") == 0)
                {
                    //MessageBox.Show("you checked the author box");
                    Utilities.QueryDatabase("INSERT INTO Categories VALUES (" + newIDstring + ",'A','This is a reader')");
                }
                */

                if (parent1 != null)
                    parent1.Visible = true;
                else if (parent2 != null)
                    parent2.Visible = true;
                else
                    parent3.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("invalid capatch! middle");
            }









            capatchField.Text = "branded";   // ########################################################


            if (capatchField.Text.Equals(""))
            {
                MessageBox.Show("invalid capatch! last");
            }
            else if (capatchField.Text.Equals("branded"))
            {
                if (parent1 != null)
                    parent1.Visible = true;
                else if (parent2 != null)
                    parent2.Visible = true;
                else if (parent3 != null)
                    parent3.Visible = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("invalid capatch!");
            }
        }

        private void capatchField_TextChanged(object sender, EventArgs e)
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
