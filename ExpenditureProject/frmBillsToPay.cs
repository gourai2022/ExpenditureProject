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
    public partial class frmBillsToPay : Form
    {
        public frmBillsToPay()
        {
            InitializeComponent();
            this.Opacity = 0.0;
        }

        private void BillsToPay_Load(object sender, EventArgs e)
        {
            //this.Opacity = 0.83;
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);

        }
    }
}
