using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWordForm
{
    public partial class LearnLabelTextbox : Form
    {
        public LearnLabelTextbox()
        {
            InitializeComponent();
        }

        private void btnLoginClicked(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            var correctUsername = "hao@.com";
            var correctPassword = "12345";
            if(username.CompareTo(correctUsername) == 0 && password.CompareTo(correctPassword) == 0)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }

        private void btnCancelClicked(object sender, EventArgs e)
        {
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
        }
    }
}
