using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Threading;

namespace GraphicNovelSys
{
    public partial class Form1 : Form
    {
        private static Form1 superReference;
        public Form1()
        {
            InitializeComponent();
            superReference = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register_Member rm = new Register_Member(this);
            rm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtBxUserName.Text.Trim();
            string userpass = txtBxUserPass.Text.Trim();
            string query1 = "SELECT *                                                             "      +
                            "FROM Members, Categories                                             "      +
                            "WHERE Members.Uname  =                  '"+    username    +"'       "      +
                            "AND Members.password =                  '"+    userpass    +"'       "      +
                            "AND Members.MemID    =                     Categories.MemID          ";

            DataSet da1 = null;
            int numOfMembersCategories = 0;
            try
            {
                da1                    =                    Utilities.QueryDatabase(query1);
                


                currentUser.SetMemId(           Convert.ToInt32(    da1.Tables[0].Rows[0][0].ToString())          );
                currentUser.SetUName(                               da1.Tables[0].Rows[0][1].ToString().Trim()    );
                currentUser.SetFName(                               da1.Tables[0].Rows[0][2].ToString().Trim()    );
                currentUser.SetLName(                               da1.Tables[0].Rows[0][3].ToString().Trim()    );
                currentUser.SetEmail(                               da1.Tables[0].Rows[0][4].ToString().Trim()    );
                currentUser.SetCredit(          float.Parse(        da1.Tables[0].Rows[0][5].ToString().Trim())   );
                currentUser.SetPassword(                            da1.Tables[0].Rows[0][7].ToString().Trim()    );
                currentUser.SetCategoryCode(    Convert.ToChar(     da1.Tables[0].Rows[0][9].ToString())          );     // I could use the constructor like I did in the CATCH but
                                                                                                                         // this make it easier to read since I'm converting types.
                



                string query2 = "SELECT COUNT(*)                                                      " +
                                "FROM Categories                                                      " +
                                "WHERE MemID          =                  '" + currentUser.GetMemId() + "' ";
                //Thread.Sleep(2000);
                numOfMembersCategories = Convert.ToInt32(Utilities.QueryDatabase(query2).Tables[0].Rows[0][0].ToString());
                

                    // return;   to jump to end of method


                //int RowCount = da1.Rows.Count;
                
                
            }   
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());

                MessageBox.Show("Invalid username password combination.\n");
                new currentUser(-1, null, null, null, null, 0 ,null, '\0'); 

                da1 = null;
                numOfMembersCategories = 0;
            }

            if (numOfMembersCategories != 0 || da1 != null)
            {

                
                int MemId = currentUser.GetMemId();
                
                if (numOfMembersCategories == 2)
                {
                    currentUser.SetCategoryCode('H');
                    //MessageBox.Show("hello author and reader");
                    MessageBox.Show("Welcome " + currentUser.GetFName() + " " + currentUser.GetLName());
                    Hybrid_Controls ns = new Hybrid_Controls(this);
                    ns.Show();
                    this.Hide();
                }
                else
                {
                    
                    if (currentUser.GetCategoryCode() == 'R')
                    {
                        //MessageBox.Show("hello world");
                        MessageBox.Show("Welcome " + currentUser.GetFName() + " " + currentUser.GetLName());
                        Reader_Controls ns = new Reader_Controls(this);
                        ns.Show();
                        this.Hide();
                    }
                    else if (currentUser.GetCategoryCode() == 'A')
                    {
                        MessageBox.Show("Welcome " + currentUser.GetFName() + " " + currentUser.GetLName());
                        Author_Controls ns = new Author_Controls(this);
                        ns.Show();
                        this.Hide();
                    }
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBxUserPass.PasswordChar = '●';       //      this changes the symbol used in the password field
        }
        public static Form1 getSuperParent()
        {
            return superReference;
        }



    }
}


/*   use DirectorySearcher for retrieving novels
     use MailMessage message = new MailMessage(
     https://msdn.microsoft.com/en-us/library/56wesadc(v=vs.110).aspx

*/