using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GraphicNovelSys
{
    public partial class Download_Novel : Form
    {
        private Hybrid_Controls parent1;
        private Author_Controls parent2;
        private Reader_Controls parent3;
        private static string a;

        // this query will only select novels which the reader or reader&author has yet to purchase. the reader&author members can buy their own work which will cost them money. 
        // It is assumed that they will not buy work that they should have already on their own computer.
        

        public Download_Novel(Hybrid_Controls Parent1, Author_Controls Parent2, Reader_Controls Parent3)
        {
            parent1 = Parent1;
            parent2 = Parent2;
            parent3 = Parent3;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (a != null && !a.Equals("") && Convert.ToInt32(a) > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to buy this novel?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string newIDstring = GetNewIdForPurchases();
                    String currentDate = DateTime.Now.ToString("d/MMM/yyyy");
                    //MessageBox.Show(newIDstring);

                    float oldCreditFloat = GetUsersCredit();
                    float novelPriceFloat = GetSelectedNovelPrice(a);

                    try
                    {
                        float newCredit = calcNewCredit(oldCreditFloat, novelPriceFloat); // subtract novel price from members credit
                        string newCreditString = Convert.ToString(newCredit);


                        string pathToNovel = GetPathToSelectedNovel();

                        // http://stackoverflow.com/questions/13227255/select-a-folder-with-the-savefiledialog
                        DialogResult r = folderBrowserDialog1.ShowDialog();
                        if (r == DialogResult.OK)
                        {
                            #region SELECT WHERE TO SAVE THE NOVEL
                                string folderName = folderBrowserDialog1.SelectedPath;
                            #endregion

                            #region COPY THE NOVEL FROM WHERE THE DATABASE SAYS IT IS, TO WHERE THE USER WANTS
                                if (File.Exists(Path.Combine(folderName, Path.GetFileName(pathToNovel))))
                                {
                                    MessageBox.Show("A file with the same name already exists at that location.");
                                    return;
                                }
                                else
                                {
                                    File.Copy(pathToNovel, Path.Combine(folderName, Path.GetFileName(pathToNovel)));
                                }
                            #endregion

                            #region REDUCE USERS CREDIT BY THE NOVELS PRICE
                                Utilities.QueryDatabase("UPDATE Members SET credit = '" + newCreditString + "' WHERE MemID = " + currentUser.GetMemId());  // update members credit with new credit
                            #endregion

                            #region ADD PURCHASE RECORD
                                Utilities.QueryDatabase("INSERT INTO Purchases (PurchaseID,pDate,MemID,NovelID) VALUES(" + newIDstring + ",'" + currentDate + "'," + currentUser.GetMemId() + "," + a + ")");
                            #endregion

                            #region GET AUTHORS CREDIT
                                float authorOfNovelsCredit = GetAuthorOfNovelsCredit();
                            #endregion
                            
                            #region ADD NOVEL PRICE TO AUTHORS CREDIT
                                float newAuthorOfNovelsCredit = authorOfNovelsCredit + novelPriceFloat;
                            #endregion
                            
                            #region UPDATE AUTHORS CREDIT IN DATABASE
                                Utilities.QueryDatabase("  UPDATE Members SET credit ='" + newAuthorOfNovelsCredit + 
                                                        "' WHERE MemId = " + getIdOfAuthorOfNovel());
                            #endregion

                            MessageBox.Show("Novel Purchased");
                        }
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        MessageBox.Show("You do not have enough credit to buy this novel.");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show("We're afraid that this novel cannot be found at this moment. Transaction canceled!");
                    }






                    //LoadTable(); //refresh data grid view
                }
                else
                {
                    MessageBox.Show("This novel will not be downloaded.");
                }
            }
            else
                MessageBox.Show("Please select a novel to be downloaded first");

        }
        #region GET THE PATH TO THE SELECTED NOVEL
        /// <summary>
        /// get the path to the currently selected novel
        /// </summary>
        /// <returns>path to novel</returns>
        public string GetPathToSelectedNovel()
        {
            DataSet pathToNovelValue = Utilities.QueryDatabase("SELECT path FROM Novels WHERE NovelID = " + a);
            return pathToNovelValue.Tables[0].Rows[0][0].ToString();
        }
        #endregion
        #region GET PRICE OF SELECTED NOVEL
        /// <summary>
        /// gets the price of a novel taking the novel id
        /// </summary>
        /// <param name="NovelID">the novels id</param>
        /// <returns>the price of a novel</returns>
        private float GetSelectedNovelPrice(string NovelID)
        {
            DataSet novelPriceValue = Utilities.QueryDatabase("SELECT price FROM Novels WHERE NovelID = " + NovelID);
            string novelPrice = novelPriceValue.Tables[0].Rows[0][0].ToString();
            return float.Parse(novelPrice);
        }
        #endregion
        #region GET USERS CREDIT BALANCE
        /// <summary>
        /// get the users credit
        /// </summary>
        /// <returns>users credit</returns>
        public static float GetUsersCredit()
        {
            DataSet creditValue = Utilities.QueryDatabase("SELECT credit FROM members WHERE MemID = " + currentUser.GetMemId());
            string oldCredit = creditValue.Tables[0].Rows[0][0].ToString();
            return float.Parse(oldCredit);
        }
        #endregion
        #region GET CREDIT OF AUTHOR OF SELECTED NOVEL
        /// <summary>
        /// get author of selected novels credit
        /// </summary>
        /// <returns>credit of author of novel</returns>
        public float GetAuthorOfNovelsCredit()
        {
            DataSet creditValue = Utilities.QueryDatabase("SELECT credit " +
                                                          "FROM Members " +
                                                          "WHERE MemId = " + getIdOfAuthorOfNovel());
            string oldCredit = creditValue.Tables[0].Rows[0][0].ToString();
            return float.Parse(oldCredit);
        }
        #endregion
        #region GET ID OF SELECTED NOVEL FROM THE TABLE
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)  // when an item is selected on the data grid view
        {  //REFERENCE http://stackoverflow.com/questions/7657137/c-sharp-datagridview-full-row-selection-but-get-single-cell-value
            if (grdNovels.SelectedCells.Count > 0 &&
                   (
                       (parent1 != null && parent1.Visible == false) ||
                       (parent2 != null && parent2.Visible == false) ||
                       (parent3 != null && parent3.Visible == false)    // this event will trigger when the data grid is being created
                   )                                                    // so a test needs to be done to ensure that a novel will be 
               )                                                        // selected only after the parent view has been hidden.
            {
                int selectedrowindex = grdNovels.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = grdNovels.Rows[selectedrowindex];

                a = Convert.ToString(selectedRow.Cells["NOVELID"].Value);  // store selected novel id when clicked

                //MessageBox.Show(a);
            }
        }
        #endregion
        #region GET AUTHOR OF NOVELS ID
        /// <summary>
        /// get the authors id of the selected novel
        /// </summary>
        /// <returns>authors id</returns>
        public int getIdOfAuthorOfNovel()
        {
            DataSet value = Utilities.QueryDatabase("SELECT MemID FROM Novels WHERE NovelID = " + a);
            string authorsIdAsString = value.Tables[0].Rows[0][0].ToString();
            return Convert.ToInt32(authorsIdAsString);
        }
        #endregion
        #region GET NEW PURCHASE ID
        /// <summary>
        /// gets a new purchase ID
        /// </summary>
        /// <returns>new purchase ID</returns>
        private static string GetNewIdForPurchases()
        {
            DataSet value = Utilities.QueryDatabase("SELECT MAX(PurchaseID) FROM Purchases");
            string oldID = value.Tables[0].Rows[0][0].ToString();
            int newIDint = Convert.ToInt32(oldID) + 1;
            return Convert.ToString(newIDint);   //http://stackoverflow.com/questions/8035502/what-is-the-best-way-to-get-a-single-value-out-of-a-dataset
        }
        #endregion
        #region SET LOAD BEHAVIOUR
        /// <summary>
        /// set the load behaviour of this page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Download_Novel_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        #endregion
        #region SET CLOSE BEHAVIOUR
        /// <summary>
        /// overide the Object.Close() method
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (parent1 != null)
                parent1.Visible = true;
            else if (parent2 != null)
                parent2.Visible = true;
            else if (parent3 != null)
                parent3.Visible = true;
        }
        #endregion
        #region CALCULATE USERS NEW CREDIT AFTER PURCHASE
        /// <summary>
        /// calculate the new credit balance of the user
        /// </summary>
        /// <param name="credit">users current credit</param>
        /// <param name="novelPrice"></param>
        /// <returns>the users new credit</returns>
        private float calcNewCredit(float credit, float novelPrice)
        {
            float newCredit = credit - novelPrice; // subtract novel price from members credit
            if (newCredit < 0) throw new ArgumentOutOfRangeException("You do not have enough credit to buy this novel.");
            return newCredit;
        }
        #endregion
        #region LOAD TABLE FROM DATABASE
        /// <summary>
        /// load or reload datagridview from database.
        /// </summary>
        public void LoadTable()
        {
            string query = "SELECT novelid,title,price                             " +
                           "FROM Novels                                            " +
                           "WHERE NovelID NOT IN (SELECT NovelID                   " +
                           "FROM Novels                                            " +
                           "WHERE (NovelID IN (SELECT NovelID FROM Purchases)) AND " +
                           "      (" + currentUser.GetMemId() +
                           "                                   IN (SELECT MemID FROM Purchases  )))";
            grdNovels.DataSource = Utilities.QueryDatabase(query).Tables["ss"]; //populate data grid view
        }
        #endregion
    }
}
