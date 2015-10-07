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

namespace GraphicNovelSys
{
    public partial class List_Members : Form
    {
        private Hybrid_Controls parent1;
        private Author_Controls parent2;
        private Reader_Controls parent3;
        public List_Members(Hybrid_Controls Parent1, Author_Controls Parent2, Reader_Controls Parent3)
        {
            parent1 = Parent1;
            parent2 = Parent2;
            parent3 = Parent3;
            InitializeComponent();

        }

        private void List_Members_Load(object sender, EventArgs e)
        {
            GetMembers();
            
            
            
            
            /*        I wanted this code to execute only when the close button is clicked
             *        but its no longer neccesary.
            if (parent1 != null)
                parent1.Visible = true;
            else if (parent2 != null)
                parent2.Visible = true;
            else if (parent2 != null)
                parent2.Visible = true;

            this.Close();*/
        }

        private void grdMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void GetMembers()
        {
            try
            {
                String query = "SELECT Members.MemID, Members.uName, Categories.catcode " +
                               "FROM Members, Categories " +
                               "WHERE Members.MemID = Categories.MemID ";
                grdMembers.DataSource = Utilities.QueryDatabase(query).Tables["ss"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed " + ex.ToString());
            }
            
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
