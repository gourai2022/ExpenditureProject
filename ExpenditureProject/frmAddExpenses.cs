using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenditureProject.Expenses;

namespace ExpenditureProject
{
    public partial class frmAddExpenses : Form
    {
        public frmAddExpenses()
        {
            InitializeComponent();
        }
        
        public frmAddExpenses(frmMainExpences ofrmMainExpenses)
        {
            ofrmMainExpenses = this.ofrmMainExpenses;
            InitializeComponent();
        }
        //frmWaterRent oWaterRent = new frmWaterRent();
       
        frmMainExpences ofrmMainExpenses = new frmMainExpences();
        AddExpensesObjectReferanceClass oAddExpensesClass;
        ModifyExpensesMethodsClass oModifyExpensesMethodsClass;

        private void frmAddExpenses_Load(object sender, EventArgs e)
        {
           
        }


        public bool btnAbbButtonClicked(Object sender)
        {
            bool IsClicked = false;
            Button btn = sender as Button;
            if (btn.Text == btnAdd.Text)
            {
                IsClicked = true;
            }
            return IsClicked;
        }

        public bool btnUpdateButtonClicked(Object sender)
        {
            bool IsClicked = false;
            Button btn = sender as Button;
            if (btn.Text == btnUpadate.Text)
            {
                IsClicked = true;
            }
            return IsClicked;
        }
        public bool btnDeleteButtonClicked(Object sender)
        {
            bool IsClicked = false;
            Button btn = sender as Button;
            if (btn.Text == btnDelete.Text)
            {
                IsClicked = true;
            }
            return IsClicked;
        }
        public bool btnResetButtonClicked(Object sender)
        {
            bool IsClicked = false;
            Button btn = sender as Button;
            if (btn.Text == btnReset.Text)
            {
                IsClicked = true;
            }
            return IsClicked;
        }

        public void CheckMainExpensesBtnClick(Object sender)
        {
            oAddExpensesClass = new AddExpensesObjectReferanceClass(sender);
            oModifyExpensesMethodsClass = new ModifyExpensesMethodsClass();
           
            switch (MainButtonText)
            {
                case "Water Rent":
                    string btn = oAddExpensesClass.CheckAddExpensesFrmButtonClick(sender);
                    oModifyExpensesMethodsClass.ModifyWaterRent(btn);
                    break;

                case "Home Rent":
                    btn = oAddExpensesClass.CheckAddExpensesFrmButtonClick(sender);
                    MessageBox.Show("coding not complete");
                    break;

                case "Electric Bill":
                    break;
                
                case "Health Insurance":
                    break;

                case "Car Insurance":
                    break;

                case "Grocery":
                    break;

                case "Fuel":
                    break;

                case "Travel":
                    break;

                case "Outing Food":
                    break;

                case "Gifts":
                    break;

                case "Parking Permits":
                    break;

                case "Internet Bill":
                    break;

                case "Mobile/Landline Bill":
                    break;

                case "Loans":
                    break;

                case "Worker Paiments":
                    break;

                case "Medical":
                    break;

                case "Educational Expenses":
                    break;

                case "":
                    break;
            }

        }
        private string MainButtonText = "";
        public void ReturnMainExpensesButtonText(string Btn)
        {
            MainButtonText = Btn.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckMainExpensesBtnClick(sender);
            //frmWaterRent obj = new frmWaterRent(this);

           
            //AddExpensesObjectReferanceClass obj = new AddExpensesObjectReferanceClass(sender);
            //obj.CheckAddExpensesFrmButtonClick(sender);
            //oAddExpensesClassObj = new AddExpensesClass(sender);
            //oAddExpensesClassObj.CheckAddExpensesFrmButtonClick(sender);

            //obj.ck(sender,e);
            //btnAbbButtonClicked();
        }

        private void btnUpadate_Click(object sender, EventArgs e)
        {
            CheckMainExpensesBtnClick(sender);
            //oAddExpensesClassObj = new AddExpensesClass(sender);
            //oAddExpensesClassObj.CheckAddExpensesFrmButtonClick(sender);
            //obj.ck(sender, e);
            //btnUpdateButtonClicked();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //obj.ck(sender, e);
            //btnDeleteButtonClicked();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //obj.ck(sender, e);
            //btnResetButtonClicked();
        }

    }
}
