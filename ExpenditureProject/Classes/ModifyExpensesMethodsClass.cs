using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using ExpenditureProject;
using ExpenditureProject.Expenses;

namespace ExpenditureProject
{
    class ModifyExpensesMethodsClass
    {
        CheckValidationCallMethodClass oCheckValidationCallMethodClass;

        public void ModifyWaterRent(string BtnName)
        {
            oCheckValidationCallMethodClass = new CheckValidationCallMethodClass();

            if (BtnName == "Add")
                oCheckValidationCallMethodClass.AddWaterRentCheckValidation();
            if (BtnName == "Update")
                oCheckValidationCallMethodClass.UpdateWaterRentCheckValidation();
            if (BtnName == "Delete")
                oCheckValidationCallMethodClass.DeleteWaterRentCheckValidation();
            if (BtnName == "Reset")
                oCheckValidationCallMethodClass.ResetWaterRentCheckValidation();

        }
    }
}
