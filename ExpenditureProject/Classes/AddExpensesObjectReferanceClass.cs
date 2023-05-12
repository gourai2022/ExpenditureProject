using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data.OleDb;
using ExpenditureProject;
using ExpenditureProject.Expenses;

namespace ExpenditureProject
{
    class AddExpensesObjectReferanceClass
    {
        public AddExpensesObjectReferanceClass(Object sender)
        {
            sender = sender.ToString();
        }

        frmMainExpences ofrmMainExpenses;
        frmAddExpenses ofrmAddExpenses;
        frmWaterRent oWaterRent;

        public string CheckAddExpensesFrmButtonClick(Object sender)
        {
            ofrmAddExpenses = new frmAddExpenses();
            string CKAddFrmBtn = "";

            if (ofrmAddExpenses.btnAbbButtonClicked(sender))
                CKAddFrmBtn = "Add";

            if (ofrmAddExpenses.btnUpdateButtonClicked(sender))
                CKAddFrmBtn = "Update";

            if (ofrmAddExpenses.btnDeleteButtonClicked(sender))
                CKAddFrmBtn = "Delete";

            if (ofrmAddExpenses.btnResetButtonClicked(sender))
                CKAddFrmBtn = "Reset";

            return CKAddFrmBtn;
        }
    }
}
