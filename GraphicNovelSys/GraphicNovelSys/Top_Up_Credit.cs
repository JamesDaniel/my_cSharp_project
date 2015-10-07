using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace GraphicNovelSys
{
    public partial class Top_Up_Credit : Form
    {
        private Hybrid_Controls parent1;
        private Author_Controls parent2;
        private Reader_Controls parent3;
        private static String newCreditAmountForDatabase;
        public Top_Up_Credit(Hybrid_Controls Parent1, Author_Controls Parent2, Reader_Controls Parent3)
        {
            parent1 = Parent1;
            parent2 = Parent2;
            parent3 = Parent3;
            newCreditAmountForDatabase = "";
            InitializeComponent();
        }

        private void Top_Up_Credit_Load(object sender, EventArgs e)
        {
            txtBoxCurrentCredit.Text = "€" + Convert.ToString(currentUser.GetCredit());
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

        private void txtBoxTopUpAmount_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!txtBoxTopUpAmount.Text.Equals(""))
                {
                    float newCreditAmount = currentUser.GetCredit() + float.Parse(txtBoxTopUpAmount.Text, CultureInfo.InvariantCulture);
                    newCreditAmountForDatabase = Convert.ToString(newCreditAmount);
                    txtBoxCreditAfterTopUp.Text = "€" + newCreditAmountForDatabase;
                }
            }
            catch (FormatException ex)
            {
                btnCancel.Focus();   // I had to change focus otherwise the KeyUp event keeps triggering.
                MessageBox.Show("Only a number will be accepted.");
            }
        }

        private void btnCancel_KeyUp(object sender, KeyEventArgs e)
        {
            txtBoxTopUpAmount.Focus();    // This is where I change focus back after the user confirms the error message.
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtBoxTopUpAmount.Text.Equals("") &&
                float.Parse(txtBoxTopUpAmount.Text) > 0)
            {
                switch (MessageBox.Show(this, "Are you sure you want to top up?", "Topping Up", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        Utilities.QueryDatabase("UPDATE Members SET credit = '" + newCreditAmountForDatabase + "' WHERE MemID = " + currentUser.GetMemId());
                        currentUser.SetCredit(float.Parse(newCreditAmountForDatabase));
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("Top Up Credit Aborted!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("You must enter a positive number to top up.");
            }
        }

    }
}
