using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data.OleDb;
using ExpenditureProject;
using System.Data;


namespace ExpenditureProject
{
    class CommonClass
    {
        OleDbConnection conn;

        public BindingSource showData(string qry)
        {
           
            conn = ConnClass.getconn();

            BindingSource bSource = new BindingSource();

            OleDbDataAdapter da = new OleDbDataAdapter(qry, conn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            bSource.DataSource = ds.Tables[0];

            return bSource;
        }

        
        //public BindingSource ChartValues(string qry)
        //{
        //    BindingSource bSource = new BindingSource();
        //    try
        //    {
        //        conn = ConnClass.getconn();                

        //        OleDbCommand cmd = new OleDbCommand(qry, conn); ;

        //        //OleDbCommand thisCommand = connection.CreateCommand();

        //        //thisCommand.CommandText = "SELECT MAX(EmployeeID) FROM tblHrEmp";

        //        OleDbDataAdapter da = new OleDbDataAdapter(cmd);

        //        DataSet myDataTable = new DataSet();
        //        //OleDbDataReader thisReader = cmd.ExecuteReader();

        //        bSource.DataSource = da.Fill(myDataTable);
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);

        //    }

        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return bSource;
        //}

        public bool Record(string qry)
        {

            bool bretval = false;

            try
            {

                conn = ConnClass.getconn();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandText = qry;

                cmd.ExecuteNonQuery();

                bretval = true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            finally
            {
                conn.Close();
            }

            return bretval;

        }

        public bool CheckRecord(string qry)
        {

            bool bretval = false;

            try
            {
                conn = ConnClass.getconn();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandText = qry;

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    bretval = true;
                }

                else
                    bretval = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return bretval;

        }

        public int MaxEmpID()
        {
            int c = 0;
            string i;
            try
            {
                conn = ConnClass.getconn();

                OleDbCommand thisCommand = conn.CreateCommand();

                thisCommand.CommandText = "SELECT MAX(EmployeeID) FROM tblHrEmp";

                OleDbDataReader thisReader = thisCommand.ExecuteReader();

                while (thisReader.Read())
                {
                    i = thisReader[0].ToString();
                    if (i != string.Empty)
                        c = Int32.Parse(i) + 1;
                }// end while
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            return c;
        }

        public string SearchByName(string qry)
        {
            string i = "";

            try
            {
                conn = ConnClass.getconn();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = qry; ;
                OleDbDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    i = rdr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return i;
        }
        string _name;

    }
}
