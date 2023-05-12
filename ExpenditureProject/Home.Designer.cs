namespace ExpenditureProject
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBilltoPay = new System.Windows.Forms.Button();
            this.btnMySaving = new System.Windows.Forms.Button();
            this.btnMyBdget = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnBilltoPay);
            this.panel1.Controls.Add(this.btnMySaving);
            this.panel1.Controls.Add(this.btnMyBdget);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 594);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(0, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 149);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBilltoPay
            // 
            this.btnBilltoPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBilltoPay.BackgroundImage")));
            this.btnBilltoPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBilltoPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBilltoPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilltoPay.Location = new System.Drawing.Point(0, 0);
            this.btnBilltoPay.Name = "btnBilltoPay";
            this.btnBilltoPay.Size = new System.Drawing.Size(306, 149);
            this.btnBilltoPay.TabIndex = 1;
            this.btnBilltoPay.Text = "Bills To Pay";
            this.btnBilltoPay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBilltoPay.UseVisualStyleBackColor = true;
            this.btnBilltoPay.Click += new System.EventHandler(this.btnBilltoPay_Click);
            // 
            // btnMySaving
            // 
            this.btnMySaving.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMySaving.BackgroundImage")));
            this.btnMySaving.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMySaving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMySaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMySaving.Location = new System.Drawing.Point(0, 296);
            this.btnMySaving.Name = "btnMySaving";
            this.btnMySaving.Size = new System.Drawing.Size(306, 149);
            this.btnMySaving.TabIndex = 3;
            this.btnMySaving.Text = "My Saving";
            this.btnMySaving.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMySaving.UseVisualStyleBackColor = true;
            this.btnMySaving.Click += new System.EventHandler(this.btnMySaving_Click);
            // 
            // btnMyBdget
            // 
            this.btnMyBdget.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMyBdget.BackgroundImage")));
            this.btnMyBdget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyBdget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyBdget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyBdget.Location = new System.Drawing.Point(0, 148);
            this.btnMyBdget.Name = "btnMyBdget";
            this.btnMyBdget.Size = new System.Drawing.Size(306, 149);
            this.btnMyBdget.TabIndex = 2;
            this.btnMyBdget.Text = "My Budget";
            this.btnMyBdget.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMyBdget.UseVisualStyleBackColor = true;
            this.btnMyBdget.Click += new System.EventHandler(this.btnMyBdget_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackgroundImage = global::ExpenditureProject.Properties.Resources.expensesimg1;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelHome.Location = new System.Drawing.Point(312, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(962, 593);
            this.panelHome.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1278, 596);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMySaving;
        private System.Windows.Forms.Button btnMyBdget;
        private System.Windows.Forms.Button btnBilltoPay;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button button1;



    }
}