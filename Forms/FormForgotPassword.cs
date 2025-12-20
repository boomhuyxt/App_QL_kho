using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QL_kho.Forms
{
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            txt_emailForgotPassword.Text = "Email";
            txt_emailForgotPassword.ForeColor = Color.Gray;

            txt_passwordForgotPassword.Text = "Mật khẩu mới";
            txt_passwordForgotPassword.ForeColor = Color.Gray;

            txt_confirmPasswordForgotPassword.Text = "Xác nhận mật khẩu";
            txt_confirmPasswordForgotPassword.ForeColor = Color.Gray;

            txt_passwordForgotPassword.UseSystemPasswordChar = false;
            txt_confirmPasswordForgotPassword.UseSystemPasswordChar = false;
        }

        private void txt_emailForgotPassword_Enter(object sender, EventArgs e)
        {
            if(txt_emailForgotPassword.Text == "Email")
            {
                txt_emailForgotPassword.Text = "";
                txt_emailForgotPassword.ForeColor = Color.Black;
            }
        }

        private void txt_passwordForgotPassword_Enter(object sender, EventArgs e)
        {
            if (txt_passwordForgotPassword.Text == "Mật khẩu mới")
            {
                txt_passwordForgotPassword.Text = "";
                txt_passwordForgotPassword.ForeColor = Color.Black;
                txt_passwordForgotPassword.UseSystemPasswordChar = true;
            }
        }

        private void txt_confirmPasswordForgotPassword_Enter(object sender, EventArgs e)
        {
            if (txt_confirmPasswordForgotPassword.Text == "Xác nhận mật khẩu")
            {
                txt_confirmPasswordForgotPassword.UseSystemPasswordChar = true;
                txt_confirmPasswordForgotPassword.Text = "";
                txt_confirmPasswordForgotPassword.ForeColor = Color.Black;
            }
        }

        private void txt_emailForgotPassword_Leave(object sender, EventArgs e)
        {
            txt_emailForgotPassword.Text = "Email";
            txt_emailForgotPassword.ForeColor = Color.Gray;
        }

        private void txt_passwordForgotPassword_Leave(object sender, EventArgs e)
        {
            txt_passwordForgotPassword.Text = "Mật khẩu mới";
            txt_passwordForgotPassword.ForeColor = Color.Gray;
            txt_passwordForgotPassword.UseSystemPasswordChar = false;
        }

        private void txt_confirmPasswordForgotPassword_Leave(object sender, EventArgs e)
        {
            txt_confirmPasswordForgotPassword.Text = "Xác nhận mật khẩu";
            txt_confirmPasswordForgotPassword.ForeColor = Color.Gray;
            txt_confirmPasswordForgotPassword.UseSystemPasswordChar = false;
        }
    }
}
