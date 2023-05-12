using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenditureProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        frmBillsToPay ofrmBillStoPay;
        frmMyBudget ofrmMyBudget;
        frmMySaving ofrmMySaving;
        private void btnBilltoPay_Click(object sender, EventArgs e)
        {
            Panel runtimePnl = new Panel();
            runtimePnl.Location = new System.Drawing.Point(312, 0);
            runtimePnl.Size = new System.Drawing.Size(962, 593);
            runtimePnl.Name = "SubPanel";
            runtimePnl.BackColor = Color.FromArgb(0, 0, 0, 0);

            runtimePnl.TabIndex = 32;
            Controls.Add(runtimePnl);
            runtimePnl.BringToFront();

            runtimePnl.Controls.Clear();
            ofrmBillStoPay = new frmBillsToPay();
            ofrmBillStoPay.TopLevel = false;
            ofrmBillStoPay.Dock = DockStyle.Fill;
            ofrmBillStoPay.Parent = runtimePnl;
            ofrmBillStoPay.Show();
            
        }

        private void btnMyBdget_Click(object sender, EventArgs e)
        {
            Panel runtimePnl = new Panel();
            runtimePnl.Location = new System.Drawing.Point(312, 0);
            runtimePnl.Size = new System.Drawing.Size(962, 593);
            runtimePnl.Name = "SubPanel";
            runtimePnl.BackColor = Color.FromArgb(0, 0, 0, 0);

            runtimePnl.TabIndex = 32;
            Controls.Add(runtimePnl);
            runtimePnl.BringToFront();

            runtimePnl.Controls.Clear();
            ofrmMyBudget = new frmMyBudget();
            ofrmMyBudget.TopLevel = false;
            ofrmMyBudget.Dock = DockStyle.Fill;
            ofrmMyBudget.Parent = runtimePnl;
            //ofrmMyBudget.Opacity = 100;
            ofrmMyBudget.Show();
        }

        private void btnMySaving_Click(object sender, EventArgs e)
        {
            Panel runtimePnl = new Panel();
            runtimePnl.Location = new System.Drawing.Point(312, 0);
            runtimePnl.Size = new System.Drawing.Size(962, 593);
            runtimePnl.Name = "SubPanel";
            runtimePnl.BackColor = Color.FromArgb(0, 0, 0, 0);

            runtimePnl.TabIndex = 32;
            Controls.Add(runtimePnl);
            runtimePnl.BringToFront();

            runtimePnl.Controls.Clear();
            ofrmMySaving = new frmMySaving();
            ofrmMySaving.TopLevel = false;
            ofrmMySaving.Dock = DockStyle.Fill;
            ofrmMySaving.Parent = runtimePnl;
            //ofrmMySaving.Opacity = 100;
            ofrmMySaving.Show();
        }
    }
}
