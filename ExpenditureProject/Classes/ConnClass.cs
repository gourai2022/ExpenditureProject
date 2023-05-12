using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data.OleDb;
using ExpenditureProject;

namespace ExpenditureProject
{
    class ConnClass
    {
        public static OleDbConnection getconn()
        {
            OleDbConnection connection = new OleDbConnection("Provider= Microsoft.Jet.OLEDB.4.0; Data source =" + System.Windows.Forms.Application.StartupPath + @"\ExpenseDatabase.mdb");
            try
            {
                connection.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection;

        }
    }
}
