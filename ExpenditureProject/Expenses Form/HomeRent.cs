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
    public partial class HomeRent : Form
    {
        public HomeRent()
        {
            InitializeComponent();
        }

        private void HomeRent_Load(object sender, EventArgs e)
        {
            txtAmount.Focus();
        }
        private void llblChangeDueDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnChangeSocity_Click(object sender, EventArgs e)
        {
            btnChangeSocity.Text = "OK";
            panelSocity.Enabled = true;
            
            //if (btnChangeSocity.Text == "OK")
            //{
            //    btnChangeSocity.Text = "Change Socity";
            //}
        }
    }
}
