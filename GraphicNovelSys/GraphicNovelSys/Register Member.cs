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
    public partial class Register_Member : Form
    {
        Form1 parent;
        public Register_Member(Form1 Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet value = Utilities.QueryDatabase("SELECT MAX(MemID) FROM Members");
            string oldID = value.Tables[0].Rows[0][0].ToString();
            int newIDint = Convert.ToInt32(oldID) + 1;
            string newIDstring = Convert.ToString(newIDint);   //http://stackoverflow.com/questions/8035502/what-is-the-best-way-to-get-a-single-value-out-of-a-dataset
            //MessageBox.Show(Convert.ToString(newID));
            
        
            if (capatchField.Text.Equals(""))
            {
                MessageBox.Show("invalid capatch!");
            }
            else if (capatchField.Text.Equals("branded"))
            {
                //MessageBox.Show(inUname.Text + "\n" + inFname.Text + "\n" + inLname.Text);
                Utilities.QueryDatabase("INSERT INTO Members (MEMID,UNAME,FNAME,LNAME,EMAIL,PASSWORD,credit) VALUES (" + newIDstring + ",'" + inUname.Text + "','" + inFname.Text + "','" + inLname.Text + "','" + inEmail.Text + "','" + inPassword2.Text + "',5)");

                

                
                if (String.Compare(checkReader.Checked.ToString(),"True") == 0)
                {
                    //MessageBox.Show("you checked the reader box");
                    Utilities.QueryDatabase("INSERT INTO Categories VALUES (" + newIDstring + ",'R','This is a reader')");
                }
                if (String.Compare(checkAuthor.Checked.ToString(),"True") == 0)
                {
                    //MessageBox.Show("you checked the author box");
                    Utilities.QueryDatabase("INSERT INTO Categories VALUES (" + newIDstring + ",'A','This is a reader')");
                }
                

                parent.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("invalid capatch!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void Register_Member_Load(object sender, EventArgs e)
        {

        }




    }
}