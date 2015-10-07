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
    public partial class Hybrid_Controls : Form
    {
        private Form1 parent;
        public Hybrid_Controls(Form1 Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Change_Novel_Price ns = new Change_Novel_Price(this, null, null);      //  these constructors let the created object know what opened them
            ns.Show();                                                             //  this is only done like this in case I want the new objects to display
            this.Hide();                                                           //  slightly differently depending on who's accessing them.
        }

        private void Hybrid_Controls_Load(object sender, EventArgs e)
        {
            txtBxCredit.Text = "€" + Convert.ToString(currentUser.GetCredit());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change_Member_Details ns = new Change_Member_Details(this, null, null);
            ns.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List_Members ns2 = new List_Members(this, null, null);
            ns2.Show();
        //    this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change_Member_Category ns = new Change_Member_Category(this, null, null);
            ns.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Upload_Novel ns = new Upload_Novel(this, null, null);
            ns.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List_Novels ns = new List_Novels(this, null, null);
            ns.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Remove_Novel ns = new Remove_Novel(this, null, null);
            ns.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Download_Novel ns = new Download_Novel(this, null, null);
            ns.Show();
            this.Hide();
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

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            Top_Up_Credit ns = new Top_Up_Credit(this, null, null);
            ns.Show();
            this.Hide();
        }

        private void btnTopUp_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                txtBxCredit.Text = "€" + Convert.ToString(currentUser.GetCredit());
            }
        }

        private void Hybrid_Controls_VisibleChanged(object sender, EventArgs e)
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
