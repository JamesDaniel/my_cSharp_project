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
    public partial class IncomeAnalysis : Form
    {
        private Form parent;
        public IncomeAnalysis(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void IncomeAnalysis_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            parent.Visible = true;
        }

        private void radioBtnAllTime_CheckedChanged(object sender, EventArgs e)
        {

            if (radioBtnAllTime.Checked == true)
            {
                DataSet value1;
                value1 = Utilities.QueryDatabase("SELECT COUNT(*) FROM Novels WHERE MemID = " + currentUser.GetMemId());
                txtBoxTotalUploads.Text = value1.Tables[0].Rows[0][0].ToString();

                
                DataSet value2 = Utilities.QueryDatabase("SELECT MAX(price) " +
                                                         "FROM Novels " +
                                                         "WHERE MemID = " + currentUser.GetMemId());
                txtBoxMostExpensiveNovelPrice.Text = "€" + value2.Tables[0].Rows[0][0].ToString();
                

                DataSet value3 = Utilities.QueryDatabase("SELECT MIN(price) " +
                                                "FROM Novels " +
                                                "WHERE MemID = " + currentUser.GetMemId());
                txtBoxLeastExpensiveNovelPrice.Text = "€" + value3.Tables[0].Rows[0][0].ToString();

                
                DataSet value4 = Utilities.QueryDatabase("SELECT SUM(Novels.price) " +
                                                         "FROM Novels, Purchases " +
                                                         "WHERE Novels.NovelID = Purchases.NovelID AND " +
                                                         "      Novels.MemID = " + currentUser.GetMemId());
                txtBoxTotalCreditEarned.Text = "€" + value4.Tables[0].Rows[0][0].ToString();
                

                /*
                // there's something wrong with this query. I'm getting an overflow error
                // it can't deal with a result of 0.3333333333333. This works in sql developer though.
                DataSet value5 = Utilities.QueryDatabase("SELECT AVG(price) " +
                                                "FROM Novels " +
                                                "WHERE NovelID IN (SELECT NovelID " +
                                                                  "From Purchases " +
                                                                  "WHERE MemID = " + currentUser.GetMemId() + ")");
                 */
                float total = float.Parse(value4.Tables[0].Rows[0][0].ToString().Trim());
                float count = float.Parse(value1.Tables[0].Rows[0][0].ToString().Trim());
                txtBoxAverageCostPerNovel.Text = "€" + Convert.ToString(total / count);


            }
        }

    }
}
