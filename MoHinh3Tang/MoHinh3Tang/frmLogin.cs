using BAL;
using BEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoHinh3Tang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            string us = txtus.Text;
            string pw = txtpw.Text; 
            BAL_DM_USER xulyuser = new BAL_DM_USER();
            if (xulyuser.login(us,pw))
            {
                frmHome home = new frmHome();
                this.Hide();
                home.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai UserName hoặc PassWord");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
