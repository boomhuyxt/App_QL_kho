using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using App_QL_kho.Data;

namespace App_QL_kho.Forms
{
    public partial class FormDangNhap_DangKy : Form
    {
        public FormDangNhap_DangKy()
        {
            InitializeComponent();
            GanSuKienPlaceholder();

            btn_login.Click += btn_login_Click;
            btn_register.Click += btn_register_Click;
        }

        private void FormDangNhap_DangKy_Load(object sender, EventArgs e)
        {
            HienThiPanelDangNhap();
        }

        #region GIAO DIỆN + PLACEHOLDER

        private void HienThiPanelDangNhap()
        {
            pnl_login.Visible = true;
            pnl_register.Visible = false;
            pnl_login.BringToFront();
            ResetFields();
        }

        private void HienThiPanelDangKy()
        {
            pnl_login.Visible = false;
            pnl_register.Visible = true;
            pnl_register.BringToFront();
            ResetFields();
        }

        private void ResetFields()
        {
            CaiDatPlaceholder(txt_usernameLogin, "Tên đăng nhập");
            CaiDatPlaceholder(txt_loginPassword, "Mật khẩu", true);

            CaiDatPlaceholder(txt_emailRegister, "Email");
            CaiDatPlaceholder(txt_usernameRegister, "Tên đăng nhập");
            CaiDatPlaceholder(txt_passwordRegister, "Mật khẩu", true);
            CaiDatPlaceholder(txt_confirmPasswordRegister, "Xác nhận mật khẩu", true);
        }

        private void CaiDatPlaceholder(TextBox txt, string text, bool isPassword = false)
        {
            txt.Text = text;
            txt.ForeColor = Color.Gray;
            if (isPassword) txt.UseSystemPasswordChar = false;
        }

        private void XyLyEnter(TextBox txt, string placeholder, bool isPass = false)
        {
            if (txt.Text == placeholder)
            {
                txt.Text = "";
            }

            txt.ForeColor = Color.White; // CHỮ NHẬP MÀU TRẮNG
            if (isPass) txt.UseSystemPasswordChar = true;
        }

        private void XyLyLeave(TextBox txt, string placeholder, bool isPass = false)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = placeholder;
                txt.ForeColor = Color.Gray;
                if (isPass) txt.UseSystemPasswordChar = false;
            }
        }

        private void GanSuKienPlaceholder()
        {
            // LOGIN
            txt_usernameLogin.Enter += (s, e) => XyLyEnter(txt_usernameLogin, "Tên đăng nhập");
            txt_usernameLogin.Leave += (s, e) => XyLyLeave(txt_usernameLogin, "Tên đăng nhập");

            txt_loginPassword.Enter += (s, e) => XyLyEnter(txt_loginPassword, "Mật khẩu", true);
            txt_loginPassword.Leave += (s, e) => XyLyLeave(txt_loginPassword, "Mật khẩu", true);

            // REGISTER
            txt_emailRegister.Enter += (s, e) => XyLyEnter(txt_emailRegister, "Email");
            txt_emailRegister.Leave += (s, e) => XyLyLeave(txt_emailRegister, "Email");

            txt_usernameRegister.Enter += (s, e) => XyLyEnter(txt_usernameRegister, "Tên đăng nhập");
            txt_usernameRegister.Leave += (s, e) => XyLyLeave(txt_usernameRegister, "Tên đăng nhập");

            txt_passwordRegister.Enter += (s, e) => XyLyEnter(txt_passwordRegister, "Mật khẩu", true);
            txt_passwordRegister.Leave += (s, e) => XyLyLeave(txt_passwordRegister, "Mật khẩu", true);

            txt_confirmPasswordRegister.Enter += (s, e) => XyLyEnter(txt_confirmPasswordRegister, "Xác nhận mật khẩu", true);
            txt_confirmPasswordRegister.Leave += (s, e) => XyLyLeave(txt_confirmPasswordRegister, "Xác nhận mật khẩu", true);
        }

        private void link_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HienThiPanelDangKy();
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HienThiPanelDangNhap();
        }

        #endregion

        #region LOGIC SQL

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string email = txt_emailRegister.Text == "Email" ? "" : txt_emailRegister.Text.Trim();
            string username = txt_usernameRegister.Text == "Tên đăng nhập" ? "" : txt_usernameRegister.Text.Trim();
            string pass = txt_passwordRegister.Text == "Mật khẩu" ? "" : txt_passwordRegister.Text;
            string confirm = txt_confirmPasswordRegister.Text == "Xác nhận mật khẩu" ? "" : txt_confirmPasswordRegister.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                return;
            }

            if (pass != confirm)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi");
                return;
            }

            using (var db = new Model1())
            {
                if (db.NguoiDungs.Any(u => u.TenDangNhap == username))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi");
                    return;
                }

                var nd = new NguoiDung
                {
                    TenDangNhap = username,
                    Email = email,
                    MatKhauHash = HashPassword(pass),
                    TrangThai = true,
                    NgayTao = DateTime.Now
                };

                db.NguoiDungs.Add(nd);
                db.SaveChanges();

                MessageBox.Show("Đăng ký thành công!", "Thông báo");
                HienThiPanelDangNhap();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_usernameLogin.Text == "Tên đăng nhập" ? "" : txt_usernameLogin.Text.Trim();
            string pass = txt_loginPassword.Text == "Mật khẩu" ? "" : txt_loginPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo");
                return;
            }

            using (var db = new Model1())
            {
                string hashed = HashPassword(pass);
                var user = db.NguoiDungs
                    .FirstOrDefault(u => u.TenDangNhap == username && u.MatKhauHash == hashed);

                if (user == null)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
                    return;
                }

                if (user.TrangThai == false)
                {
                    MessageBox.Show("Tài khoản đang bị khóa!", "Lỗi");
                    return;
                }

                FormAdmin frm = new FormAdmin();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        #endregion

        private void link_forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgotPassword frm = new FormForgotPassword();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
