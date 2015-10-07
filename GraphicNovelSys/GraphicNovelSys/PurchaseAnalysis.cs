using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GraphicNovelSys
{
    public partial class PurchaseAnalysis : Form
    {
        private Form parent;
        public PurchaseAnalysis(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
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
                value1 = Utilities.QueryDatabase("SELECT COUNT(*) FROM PURCHASES WHERE MemID = " + currentUser.GetMemId());
                txtBoxTotalDownloads.Text = value1.Tables[0].Rows[0][0].ToString();


                Thread.Sleep(100);
                DataSet value2 = Utilities.QueryDatabase("SELECT MAX(price) " + 
                                                "FROM Novels " +
                                                "WHERE NovelID IN (SELECT NovelID " +
                                                                  "From Purchases " +
                                                                  "WHERE MemID = " + currentUser.GetMemId() + ")");
                txtBoxMostExpensiveNovel.Text = "€" + value2.Tables[0].Rows[0][0].ToString();


                Thread.Sleep(100);
                DataSet value3 = Utilities.QueryDatabase("SELECT MIN(price) " +
                                                "FROM Novels " +
                                                "WHERE NovelID IN (SELECT NovelID " +
                                                                  "From Purchases " +
                                                                  "WHERE MemID = " + currentUser.GetMemId() + ")");
                txtBoxLeastExpensiveNovel.Text = "€" + value3.Tables[0].Rows[0][0].ToString();


                Thread.Sleep(100);
                DataSet value4 = Utilities.QueryDatabase("SELECT SUM(price) " +
                                                "FROM Novels " +
                                                "WHERE NovelID IN (SELECT NovelID " +
                                                                  "From Purchases " +
                                                                  "WHERE MemID = " + currentUser.GetMemId() + ")");
                txtBoxTotalCreditSpent.Text = "€" + value4.Tables[0].Rows[0][0].ToString();
                

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
                



                /*  I'm trying to select this members favourite author.
                 * SELECT uName
                 * FROM Members
                 * WHERE MemID IN (SELECT MemID
                 *                 FROM Novels
                 *                 WHERE NovelID IN (SELECT NovelID
                 *                                   FROM (SELECT COUNT(NovelID) AS Freq
                 *                                         FROM Purchases
                 *                                         WHERE MemID = 1
                 *                                         ORDER BY Freq DESC)))
                 *                         AND
                 *       ROWNUM = 1;
                 */


                /*value = Utilities.QueryDatabase("SELECT uName " +
                                                "FROM Members " +
                                                "WHERE NovelID IN (SELECT NovelID " +
                                                                  "From Purchases " +
                                                                  "WHERE MemID = " + currentUser.GetMemId() + ")");
                txtBoxMostNovelsDownloadedFrom.Text = "€" + value.Tables[0].Rows[0][0].ToString();*/
            }
        }

        private void PurchaseAnalysis_Load(object sender, EventArgs e)
        {

        }
    }
}
