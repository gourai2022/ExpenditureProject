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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        #region Form Objects

        DashBoard oDashboard;
        frmMainExpences oMainExpenses;
        
        Home oHome;
        Expiry_Of_An_Item oexpiryitem;
        Help ohelp;
        ShowExpenses oshowexpenses;

        #endregion
        private void DashBoard_Load(object sender, EventArgs e)
        {
            
            try
            {
                oDashboard = new DashBoard();
                timer1_Tick(sender, e);
                oHome = new Home();
                oHome.TopLevel = false;
                oHome.Dock = DockStyle.Fill;
                oHome.Parent = panel2;
                oHome.Show();
               
            }
            catch (Exception exe)
            {
                exe.Message.ToString();                
            }
        }
        int ImageNumber= 0;
        private void loadNextImage()
        {
            Image[] Img1 = { Properties.Resources.India_Bazaar, Properties.Resources.target1, Properties.Resources.TomThumb1, Properties.Resources.walmart1 };
            Image[] Img2 = { Properties.Resources.target1, Properties.Resources.TomThumb1, Properties.Resources.walmart1, Properties.Resources.India_Bazaar };

            if (ImageNumber == 4)
            {
                ImageNumber = 0;
            }
            pictureBox1.Image = Img1[ImageNumber];
            pictureBox2.Image = Img2[ImageNumber];
            ImageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }
       

        private void lklbExpiryofItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Controls.Clear();
            oexpiryitem = new  Expiry_Of_An_Item();
            oexpiryitem.TopLevel = false;
            oexpiryitem.Dock = DockStyle.Fill;
            oexpiryitem.Parent = panel2;
            oexpiryitem.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            EventArgs e1 = System.EventArgs.Empty;
            DashBoard_Load(sender, e1);
        }

        private void btnExpensesManager_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            oMainExpenses = new frmMainExpences();
            oMainExpenses.TopLevel = false;
            oMainExpenses.Dock = DockStyle.Fill;
            oMainExpenses.Parent = panel2;
            oMainExpenses.Show();
            // pnlShowShoppingOption.Visible = true;
            //dataGridViewShowShopping.Visible = true;
        }

        private void btnMyExpenses_Click(object sender, EventArgs e)
        {
             panel2.Controls.Clear();
            oshowexpenses = new ShowExpenses();
            oshowexpenses.TopLevel = false;
            oshowexpenses.Dock = DockStyle.Fill;
            oshowexpenses.Parent = panel2;
            oshowexpenses.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ohelp = new Help();
            ohelp.TopLevel = false;
            ohelp.Dock = DockStyle.Fill;
            ohelp.Parent = panel2;
            ohelp.Show();
        }

       

       
    }
}
