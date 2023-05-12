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
    public partial class frmMainExpences : Form
    {
        public frmMainExpences()
        {
            InitializeComponent();
        }

        public Control runtimePnl { get; set; }
        DashBoard oDashboard;
        frmMainExpences ofrmMainExpenses;
        frmAddExpenses ofrmAddExpenses;
        frmWaterRent ofrmWaterRent;
        HomeRent ofrmHomeRent;
        MainClass obj;

        private void frmMainExpences_Load(object sender, EventArgs e)
        {
            string day = System.DateTime.Now.DayOfWeek.ToString();
            string DateMonth = System.DateTime.Now.ToString("MMMM");
            string DateYear = System.DateTime.Now.ToString("yyyy");
            string DateDay = System.DateTime.Now.ToString("dd");
            label2.Text = day + ", " + DateDay + " " + DateMonth + " " + DateYear;
            
        }

        private void CreateRuntimePanel(Panel runtimePnl)
        {
            runtimePnl.Location = new System.Drawing.Point(0,0);
            runtimePnl.Size = new System.Drawing.Size(1277, 595);
            runtimePnl.Name = "SubPanel";
            runtimePnl.BackColor = Color.LightBlue;

            runtimePnl.TabIndex = 32;
            frmMainExpensesPanel1.Hide();
            Controls.Add(runtimePnl);
            runtimePnl.BringToFront();
        }

        public bool btnMainWaterRentClicked(Object sender)
        {
            bool IsClicked = false;
            Button btn = sender as Button;
            if (btn.Text == btnWaterRent.Text)
            {
                IsClicked = true;
            }
            
            return IsClicked;
        }

        public bool btnMainHomeRentClicked(Object sender)
        {
            bool IsClicked = false;
            Button btn = sender as Button;
            if (btn.Text == btnHomeRent.Text)
            {
                IsClicked = true;
            }
            return IsClicked;
        }

        
        private void btnWaterRent_Click(object sender, EventArgs e)
        {
            try
            {
                Panel runtimePnl = new Panel();
                CreateRuntimePanel(runtimePnl);
                            
                ofrmAddExpenses = new frmAddExpenses();

                ofrmAddExpenses.TopLevel = false;
                ofrmAddExpenses.Dock = DockStyle.Fill;
                ofrmAddExpenses.Parent = runtimePnl;
                ofrmAddExpenses.Show();

                ofrmWaterRent = new frmWaterRent();
                ofrmWaterRent.TopLevel = false;
                ofrmWaterRent.Dock = DockStyle.Fill;
                ofrmWaterRent.Parent = ofrmAddExpenses.frmAddExpensespanel1;                
                ofrmWaterRent.Show();
                ofrmAddExpenses.ReturnMainExpensesButtonText(btnWaterRent.Text);
            }
            catch (StackOverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
       
        private void btnHomeRent_Click(object sender, EventArgs e)
        {
            try
            {               
                Panel runtimePnl = new Panel();
                CreateRuntimePanel(runtimePnl);
               
                ofrmAddExpenses = new frmAddExpenses();
                ofrmAddExpenses.TopLevel = false;
                ofrmAddExpenses.Dock = DockStyle.Fill;
                ofrmAddExpenses.Parent = runtimePnl;
                ofrmAddExpenses.Show();
                
                ofrmHomeRent = new HomeRent();
                ofrmHomeRent.TopLevel = false;
                ofrmHomeRent.Dock = DockStyle.Fill;
                ofrmHomeRent.Parent = ofrmAddExpenses.frmAddExpensespanel1;
                ofrmHomeRent.Show();
                ofrmAddExpenses.ReturnMainExpensesButtonText(btnHomeRent.Text);
            }
            catch (StackOverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
