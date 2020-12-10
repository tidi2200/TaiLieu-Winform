using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "admin")
            {
                if (txtPw.Text == "123")
                {
                    MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu ! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu ! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
