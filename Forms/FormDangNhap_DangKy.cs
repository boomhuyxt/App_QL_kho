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
    public partial class FormDangNhap_DangKy : Form
    {
        public FormDangNhap_DangKy()
        {
            InitializeComponent();
        }

        private void FormDangNhap_DangKy_Load(object sender, EventArgs e)
        {
            pnl_login.Visible = true;
            pnl_register.Visible = false;

            //Đăng nhập
            txt_usernameLogin.Text = "Tên đăng nhập";
            txt_usernameLogin.ForeColor = Color.Gray;

            txt_loginPassword.Text = "Mật khẩu";
            txt_loginPassword.ForeColor = Color.Gray;

            //Đăng ký
            txt_emailRegister.Text = "Email";
            txt_emailRegister.ForeColor = Color.Gray;

            txt_usernameRegister.Text = "Tên đăng nhập";
            txt_usernameRegister.ForeColor = Color.Gray;

            txt_passwordRegister.Text = "Mật khẩu";
            txt_passwordRegister.ForeColor = Color.Gray;

            txt_confirmPasswordRegister.Text = "Xác nhận mật khẩu";
            txt_confirmPasswordRegister.ForeColor = Color.Gray;


            txt_loginPassword.UseSystemPasswordChar = false;
            txt_passwordRegister.UseSystemPasswordChar = false;
            txt_confirmPasswordRegister.UseSystemPasswordChar = false;
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_login.Visible = true;
            pnl_register.Visible = false;
        }

        private void link_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_login.Visible = false;
            pnl_register.Visible = true;
        }

        private void txt_usernameLogin_Enter(object sender, EventArgs e)
        {
            if(txt_usernameLogin.Text == "Tên đăng nhập")
            {
                txt_usernameLogin.Text = "";
                txt_usernameLogin.ForeColor = Color.Black;
            }
        }

        private void txt_loginPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_emailRegister_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_usernameRegister_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_passwordRegister_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_confirmPasswordRegister_Enter(object sender, EventArgs e)
        {
            if (txt_confirmPasswordRegister.Text == "Xác nhận mật khẩu")
            {
                txt_confirmPasswordRegister.UseSystemPasswordChar = true;
                txt_confirmPasswordRegister.Text = "";
                txt_confirmPasswordRegister.ForeColor = Color.Black;
            }
        }

        private void txt_passwordRegister_Enter(object sender, EventArgs e)
        {
            if (txt_passwordRegister.Text == "Mật khẩu")
            {
                txt_passwordRegister.UseSystemPasswordChar = true;
                txt_passwordRegister.Text = "";
                txt_passwordRegister.ForeColor = Color.Black;
            }
        }

        private void txt_usernameRegister_Enter(object sender, EventArgs e)
        {
            if (txt_usernameRegister.Text == "Tên đăng nhập")
            {
                txt_usernameRegister.Text = "";
                txt_usernameRegister.ForeColor = Color.Black;
            }
        }

        private void txt_emailRegister_Enter(object sender, EventArgs e)
        {
            if (txt_emailRegister.Text == "Email")
            {
                txt_emailRegister.Text = "";
                txt_emailRegister.ForeColor = Color.Black;
            }
        }

        private void link_forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.FormForgotPassword frm = new Forms.FormForgotPassword();
            frm.ShowDialog();
        }

        private void txt_loginPassword_Enter(object sender, EventArgs e)
        {
            if (txt_loginPassword.Text == "Mật khẩu")
            {
                txt_loginPassword.Text = "";
                txt_loginPassword.ForeColor = Color.Black;
                txt_loginPassword.UseSystemPasswordChar = true;
            }
        }

        private void txt_usernameLogin_Leave(object sender, EventArgs e)
        {
            txt_usernameLogin.Text = "Tên đăng nhập";
            txt_usernameLogin.ForeColor = Color.Gray;
        }

        private void txt_loginPassword_Leave(object sender, EventArgs e)
        {
            txt_loginPassword.Text = "Mật khẩu";
            txt_loginPassword.ForeColor = Color.Gray;
            txt_loginPassword.UseSystemPasswordChar = false;
        }

        private void txt_emailRegister_Leave(object sender, EventArgs e)
        {
            txt_emailRegister.Text = "Email";
            txt_emailRegister.ForeColor = Color.Gray;
        }

        private void txt_usernameRegister_Leave(object sender, EventArgs e)
        {
            txt_usernameRegister.Text = "Tên đăng nhập";
            txt_usernameRegister.ForeColor = Color.Gray;
        }

        private void txt_passwordRegister_Leave(object sender, EventArgs e)
        {
            txt_passwordRegister.Text = "Mật khẩu";
            txt_passwordRegister.ForeColor = Color.Gray;
            txt_passwordRegister.UseSystemPasswordChar = false;
        }

        private void txt_confirmPasswordRegister_Leave(object sender, EventArgs e)
        {
            txt_confirmPasswordRegister.Text = "Xác nhận mật khẩu";
            txt_confirmPasswordRegister.ForeColor = Color.Gray;
            txt_confirmPasswordRegister.UseSystemPasswordChar = false;
        }
    }
}
