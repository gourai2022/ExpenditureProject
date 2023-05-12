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
    
    class MainClass
    {
        frmMainExpences ofrmMainExpenses;
        frmAddExpenses ofrmAddExpenses;
        frmWaterRent oWaterRent;
        //frmWaterRent oWaterRent = new frmWaterRent();

        public MainClass(Object sender)
        {
            sender = sender.ToString();
        }

        private string ButtonText ="";
        public string MainButtonText
        {
            get { return ButtonText; }
            set { ButtonText = value; }

        }

        public void CheckMainExpensesButtonClick(object sender)
        {
            ofrmMainExpenses = new frmMainExpences();
            ofrmAddExpenses = new frmAddExpenses();
            oWaterRent = new frmWaterRent();
            
            AddExpensesObjectReferanceClass obj = new AddExpensesObjectReferanceClass(sender);

            if (ofrmMainExpenses.btnMainWaterRentClicked(sender))
            {
                MainButtonText = "Water Rent";
            }
            if (ofrmMainExpenses.btnMainHomeRentClicked(sender))
            {
                MainButtonText = "Home Rent";
            }

        }

        public string cke()
        {
            string val = MainButtonText;
            return val; 
        }
    }
}
