using ExpenditureProject.Expenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenditureProject.Expenses
{
    public partial class frmWaterRent : Form
    {
        frmAddExpenses ofrmAddExpenses = new frmAddExpenses();
        public frmWaterRent()
        {
            
            InitializeComponent();
        }
        CommonClass obj;
        private void frmWaterRent_Load(object sender, EventArgs e)
        {
            string DueDateMonth = System.DateTime.Now.ToString("MMM");
            string DueDateYear = System.DateTime.Now.ToString("yyyy");
            dtpDueDate.Text = DueDateMonth + "-08-" + DueDateYear;
            txtAmount.Focus();
            DisplyChart();
            //WaterRntAmount = txtAmount.Text.ToString();
        }
        static string WaterRntAmount = "";
        static string DueDate ="";
        static string Paydate ="";

        public bool CheckWaterRentValidation()
        {
            bool isValid = false;
            if (WaterRntAmount == "")
            {
                MessageBox.Show("Enter water Rent Amount");
                isValid = false;
            }
            else
                isValid = true;

            return isValid;
        }

        
        public void AddWaterRent()
        {
            if (CheckWaterRentValidation())
            {
                string qry = "insert into tblWaterRent (PayDate,Amount,DueDate) values('" + Paydate + "','" + WaterRntAmount + "','" + DueDate + "')";
                obj = new CommonClass();
                bool res = obj.Record(qry);
                if (res)
                {
                    chart1.Controls.Clear();
                    DisplyChart();
                    MessageBox.Show("sucessfully inserted");
                }
            }
        }

        public void DeleteWaterRent()
        {
            if (CheckWaterRentValidation())
            {
                MessageBox.Show("You can delete waterRent");
            }
            
        }

        public void UpdateWaterRent()
        {
            if (CheckWaterRentValidation())
            {
                MessageBox.Show("You can Update waterRent");
            }
            
        }

        public void ResetWaterRent()
        {
            if (CheckWaterRentValidation())
            {
                MessageBox.Show("You can reset waterRent");
            }
           
        }

        private void llblChangeDueDate_Click(object sender, EventArgs e)
        {
            dtpDueDate.Enabled = true;
        }

        private void frmWaterRent_Leave(object sender, EventArgs e)
        {
            WaterRntAmount = txtAmount.Text.ToString();
            Paydate = dtpPayDate.Text.ToString();
            DueDate = dtpPayDate.Text.ToString();
        }

        private void DisplyChart()
        {
            OleDbConnection conn = ConnClass.getconn();
            try
            {
                string qry = "select * from tblWaterRent "; 
                

                OleDbCommand cmd = new OleDbCommand(qry, conn);
                
                DataSet ds = new DataSet();
                cmd.ExecuteNonQuery();

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds, "PremiumData");

                if (ds.Tables["PremiumData"].Rows.Count > 0)
                {

                    chart1.DataSource = ds.Tables["PremiumData"];

                    chart1.Series["Count"].XValueMember = "PayDate";

                    chart1.Series["Count"].YValueMembers = "Amount";

                    chart1.Series["Count"].IsValueShownAsLabel = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeSocity_Click(object sender, EventArgs e)
        {

        }
       

       
    }
}
