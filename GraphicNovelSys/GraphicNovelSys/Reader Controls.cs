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
    public partial class Reader_Controls : Form
    {
        private Form1 parent;
        public Reader_Controls(Form1 Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List_Members ns2 = new List_Members(null, null, this);  //  these constructors let the created object know what opened them
            ns2.Show();                                             //  this is only done like this in case I want the new objects to display
        }                                                           //  slightly differently depending on who's accessing them.

        private void button4_Click(object sender, EventArgs e)
        {
            List_Novels ns2 = new List_Novels(null, null, this);
            ns2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change_Member_Category ns = new Change_Member_Category(null, null, this);
            ns.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change_Member_Details ns = new Change_Member_Details(null, null, this);
            ns.Show();
            this.Hide();
        }

        private void Reader_Controls_Load(object sender, EventArgs e)
        {
            txtBxCredit.Text = "€" + Convert.ToString(currentUser.GetCredit());
        }
        public Form1 getFirstParent()
        {
            return parent;
        }

        private void deleteAccount_Click(object sender, EventArgs e)
        {
            Utilities.deleteAccount(this);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //REFERENCE http://stackoverflow.com/questions/1669318/override-standard-close-x-button-in-a-windows-form
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (Form1.getSuperParent().Visible == false)
            {
                Form1.getSuperParent().Visible = true;
                new currentUser(-1, null, null, null, null, 0, null, '\0');
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Download_Novel ns = new Download_Novel(null, null, this);
            ns.Show();
            this.Hide();
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            Top_Up_Credit ns = new Top_Up_Credit(null, null, this);
            ns.Show();
            this.Hide();
        }

        private void Reader_Controls_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                txtBxCredit.Text = "€" + Convert.ToString(currentUser.GetCredit());
            }
        }

        private void BtnPurchaseAnalysis_Click(object sender, EventArgs e)
        {
            PurchaseAnalysis ns = new PurchaseAnalysis(this);
            ns.Show();
            this.Hide();
        }

        private void btnIncomeAnalysis_Click(object sender, EventArgs e)
        {
            IncomeAnalysis ns = new IncomeAnalysis(this);
            ns.Show();
            this.Hide();
        }


    }
}
