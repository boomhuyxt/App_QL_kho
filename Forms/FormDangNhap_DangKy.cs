using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using App_QL_kho.Data;
using System.Data.Entity;

namespace App_QL_kho.Forms
{
    public partial class FormDangNhap_DangKy : Form
    {
        public FormDangNhap_DangKy()
        {
            InitializeComponent();
            GanSuKienPlaceholder();

            // Gán sự kiện cho các nút chính
            btn_login.Click += btn_login_Click;
            btn_register.Click += btn_register_Click;

            // --- GÁN SỰ KIỆN NÚT MẮT (LOGIN) ---
            if (An != null) An.Click += An_Click;
            if (hien != null) hien.Click += hien_Click;

            // --- GÁN SỰ KIỆN NÚT MẮT (REGISTER) --- 
            if (AnRegister != null) AnRegister.Click += AnRegister_Click;
            if (hienRegister != null) hienRegister.Click += hienRegister_Click;
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

            // Setup nút mắt Login
            if (hien != null && An != null)
            {
                hien.Visible = true;
                An.Visible = false;
            }

            // Đặt ẩn mật khẩu
            if (txt_loginPassword.Text != "Mật khẩu")
                txt_loginPassword.UseSystemPasswordChar = true;
        }

        private void HienThiPanelDangKy()
        {
            pnl_login.Visible = false;
            pnl_register.Visible = true;
            pnl_register.BringToFront();
            ResetFields();

            // Setup nút mắt Register
            if (hienRegister != null && AnRegister != null)
            {
                hienRegister.Visible = true;
                AnRegister.Visible = false;
            }

            // Đảm bảo xóa sạch ký tự che mặc định của Designer
            txt_passwordRegister.PasswordChar = '\0';
            txt_confirmPasswordRegister.PasswordChar = '\0';
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
            // Nếu là placeholder thì luôn hiện chữ (không ẩn *)
            if (isPassword)
            {
                txt.UseSystemPasswordChar = false;
                txt.PasswordChar = '\0'; // Đảm bảo hiện chữ hướng dẫn
            }
        }

        // --- HÀM XỬ LÝ ENTER ---
        private void XyLyEnter(TextBox txt, string placeholder, bool isPass = false)
        {
            if (txt.Text == placeholder)
            {
                txt.Text = "";
            }

            txt.ForeColor = Color.White;

            if (isPass)
            {
                // 1. LOGIC CHO LOGIN
                if (txt == txt_loginPassword)
                {
                    if (hien != null && hien.Visible == false) // Đang xem pass
                    {
                        txt.UseSystemPasswordChar = false;
                        txt.PasswordChar = '\0';
                    }
                    else
                    {
                        txt.UseSystemPasswordChar = true;
                    }
                }
                // 2. LOGIC CHO REGISTER (Áp dụng cho cả 2 ô)
                else if (txt == txt_passwordRegister || txt == txt_confirmPasswordRegister)
                {
                    if (hienRegister != null && hienRegister.Visible == false) // Đang xem pass
                    {
                        txt.UseSystemPasswordChar = false;
                        txt.PasswordChar = '\0';
                    }
                    else
                    {
                        txt.UseSystemPasswordChar = true;
                    }
                }
            }
        }

        private void XyLyLeave(TextBox txt, string placeholder, bool isPass = false)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = placeholder;
                txt.ForeColor = Color.Gray;
                if (isPass)
                {
                    txt.UseSystemPasswordChar = false;
                    txt.PasswordChar = '\0';
                }
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

        // --- SỰ KIỆN NÚT ẨN / HIỆN MẬT KHẨU (LOGIN) ---
        private void An_Click(object sender, EventArgs e)
        {
            if (txt_loginPassword.Text != "Mật khẩu")
            {
                txt_loginPassword.UseSystemPasswordChar = true;
                An.Visible = false;
                hien.Visible = true;
            }
        }

        private void hien_Click(object sender, EventArgs e)
        {
            if (txt_loginPassword.Text != "Mật khẩu")
            {
                // Sửa lỗi: Phải gán PasswordChar về rỗng thì mới hiện chữ được
                txt_loginPassword.PasswordChar = '\0';
                txt_loginPassword.UseSystemPasswordChar = false;

                hien.Visible = false;
                An.Visible = true;
            }
        }

        // --- SỰ KIỆN NÚT ẨN / HIỆN MẬT KHẨU (REGISTER) ---
        private void AnRegister_Click(object sender, EventArgs e)
        {
            // 1. Chỉ ẩn nếu đó là mật khẩu thật (màu không phải xám)

            if (txt_passwordRegister.ForeColor != Color.Gray)
            {
                txt_passwordRegister.UseSystemPasswordChar = true;
            }

            if (txt_confirmPasswordRegister.ForeColor != Color.Gray)
            {
                txt_confirmPasswordRegister.UseSystemPasswordChar = true;
            }

            // 2. Đổi trạng thái nút
            AnRegister.Visible = false;
            hienRegister.Visible = true;
        }

        private void hienRegister_Click(object sender, EventArgs e)
        {
            // 1. Xóa ký tự che (BẮT BUỘC)
            txt_passwordRegister.PasswordChar = '\0';
            txt_confirmPasswordRegister.PasswordChar = '\0';

            // 2. Kiểm tra dựa trên MÀU SẮC (Chính xác hơn so sánh chữ)
            // Nếu màu chữ KHÁC màu xám (tức là người dùng đã nhập) thì cho hiện ra

            if (txt_passwordRegister.ForeColor != Color.Gray)
            {
                txt_passwordRegister.UseSystemPasswordChar = false;
            }

            if (txt_confirmPasswordRegister.ForeColor != Color.Gray)
            {
                txt_confirmPasswordRegister.UseSystemPasswordChar = false;
            }

            // 3. Đổi trạng thái nút
            hienRegister.Visible = false;
            AnRegister.Visible = true;
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

            try
            {
                using (var db = new Model1())
                {
                    string hashed = HashPassword(pass);

                    var user = db.NguoiDungs
                        .Include(u => u.VaiTroes)
                        .FirstOrDefault(u => u.TenDangNhap == username && u.MatKhauHash == hashed);

                    if (user == null)
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập");
                        return;
                    }

                    if (user.TrangThai == false)
                    {
                        MessageBox.Show("Tài khoản này hiện đang bị khóa!", "Thông báo");
                        return;
                    }

                    var danhSachVaiTro = user.VaiTroes.Select(v => v.TenVaiTro).ToList();

                    if (danhSachVaiTro.Count == 0)
                    {
                        MessageBox.Show("Tài khoản chưa được cấp quyền truy cập hệ thống!", "Thông báo");
                        return;
                    }

                    FormAdmin frm = new FormAdmin(danhSachVaiTro);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
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