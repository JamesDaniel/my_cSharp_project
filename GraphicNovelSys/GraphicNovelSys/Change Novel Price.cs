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
    public partial class Change_Novel_Price : Form
    {
        private Hybrid_Controls parent1;
        private Author_Controls parent2;
        private Reader_Controls parent3;
        private static string a;
        public Change_Novel_Price(Hybrid_Controls Parent1, Author_Controls Parent2, Reader_Controls Parent3)
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
                DialogResult result = MessageBox.Show("Are you sure you want to change this price?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Utilities.QueryDatabase("UPDATE Novels SET Price = '" + newPrice.Text + "' WHERE NovelID = " + a);  // change novel price of selected novel.

                    MessageBox.Show("Price changed");

                    grdNovels.DataSource = Utilities.QueryDatabase("SELECT novelid,title,price FROM Novels WHERE MemId = " + currentUser.GetMemId()).Tables["ss"]; // refresh data grid view
                }
                else
                {
                    MessageBox.Show("This novel's price will not be changed.");
                }
            }
            else
                MessageBox.Show("Please select a novel to be removed first");


            /*
            if (parent1 != null)
                parent1.Visible = true;
            else if (parent2 != null)
                parent2.Visible = true;
            else if (parent2 != null)
                parent2.Visible = true;

            this.Close();*/
        }

        private void Change_Novel_Price_Load(object sender, EventArgs e)
        {
            grdNovels.DataSource = Utilities.QueryDatabase("SELECT novelid,title,price FROM Novels WHERE MemId = " + currentUser.GetMemId()).Tables["ss"];
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

        private void grdNovels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
