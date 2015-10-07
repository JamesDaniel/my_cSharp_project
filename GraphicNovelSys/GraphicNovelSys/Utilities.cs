using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace GraphicNovelSys
{
    class Utilities
    {
        public static DataSet QueryDatabase(string query)
        {
            
            string oracleDB = "Data Source=xe;User Id=t00126681;Password=hello;";
            //string oracleDB = "Data Source=Oracle;User Id=t00126681;Password=not telling;";
            try
            {
                OracleConnection conn = new OracleConnection(oracleDB);
                string strSQL = query;
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                conn.Close(); 
                return ds;
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Something went wrong when accessing the database.");
                MessageBox.Show("sql error");
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static void deleteAccount(Form form1)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Utilities.QueryDatabase("UPDATE Members SET UNAME = '" + currentUser.GetUName() + "', FNAME ='DELETED', LNAME = 'DELETED', PASSWORD = 'DELETED', status = 'I' WHERE MemID = " + currentUser.GetMemId());
                MessageBox.Show("Account Deleted");
                form1.Close();

                // maybe add validation to login so members can't enter empty strings to log in
            }
            else
            {
                MessageBox.Show("Account Deletion Canceled");
            }
        }
    }
}
