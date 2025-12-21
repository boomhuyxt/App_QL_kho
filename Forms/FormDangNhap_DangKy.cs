using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_QL_kho.Data;

namespace App_QL_kho.Forms
{
    public partial class FormDangNhap_DangKy : Form
    {
        public FormDangNhap_DangKy()
        {
            InitializeComponent();

            // wire up button events
            btn_register.Click += btn_register_Click;
            btn_login.Click += btn_login_Click;
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

        // Helper: compute salted SHA-256 hash
        private string HashPassword(string password)
        {
            // simple hashing using SHA256. In production use stronger algorithm (PBKDF2, bcrypt, Argon2)
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            var email = txt_emailRegister.Text?.Trim();
            var username = txt_usernameRegister.Text?.Trim();
            var password = txt_passwordRegister.Text;
            var confirm = txt_confirmPasswordRegister.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new Model1())
            {
                // check existing username or email
                var existsUser = db.NguoiDungs.FirstOrDefault(u => u.TenDangNhap == username);
                if (existsUser != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existsEmail = db.NguoiDungs.FirstOrDefault(u => u.Email == email);
                if (existsEmail != null)
                {
                    MessageBox.Show("Email đã được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nd = new NguoiDung
                {
                    TenDangNhap = username,
                    Email = email,
                    MatKhauHash = HashPassword(password),
                    HoTen = null,
                    TrangThai = true,
                    NgayTao = DateTime.Now
                };

                db.NguoiDungs.Add(nd);
                db.SaveChanges();
            }

            MessageBox.Show("Đăng ký thành công. Bạn có thể đăng nhập.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // switch to login
            pnl_register.Visible = false;
            pnl_login.Visible = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var username = txt_usernameLogin.Text?.Trim();
            var password = txt_loginPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new Model1())
            {
                var user = db.NguoiDungs.FirstOrDefault(u => u.TenDangNhap == username);
                if (user == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var hash = HashPassword(password);
                if (user.MatKhauHash != hash)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (user.TrangThai == false)
                {
                    MessageBox.Show("Tài khoản đã bị vô hiệu hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // success: open admin form
                var frm = new Forms.FormAdmin();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }
    }
}
