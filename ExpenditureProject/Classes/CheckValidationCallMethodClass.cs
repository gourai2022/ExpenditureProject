using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using ExpenditureProject;
using ExpenditureProject.Expenses;
using System.Windows.Forms;
namespace ExpenditureProject
{
    class CheckValidationCallMethodClass
    {
        frmWaterRent oWaterRent;
        frmAddExpenses ofrmAddExpenses = new frmAddExpenses();
        public void AddWaterRentCheckValidation()
        {
            oWaterRent = new frmWaterRent();
           
            //oWaterRent.CheckWaterRentValidation();
            oWaterRent.AddWaterRent();
        }
        public void UpdateWaterRentCheckValidation()
        {
            oWaterRent = new frmWaterRent();
            //oWaterRent.CheckWaterRentValidation();
            oWaterRent.UpdateWaterRent();
        }

        public void DeleteWaterRentCheckValidation()
        {
            oWaterRent = new frmWaterRent();
            //oWaterRent.CheckWaterRentValidation();
            oWaterRent.DeleteWaterRent();
        }
        public void ResetWaterRentCheckValidation()
        {
            oWaterRent = new frmWaterRent();
            //oWaterRent.CheckWaterRentValidation();
            oWaterRent.ResetWaterRent();
        }
    }
}
