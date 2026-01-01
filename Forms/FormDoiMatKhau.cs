using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using App_QL_kho.Data;

namespace App_QL_kho.Forms
{
    public partial class FormDoiMatKhau : Form
    {
        private string emailCanDoiMatKhau;
        private Model1 db = new Model1();

        public FormDoiMatKhau(string email)
        {
            InitializeComponent();
            this.emailCanDoiMatKhau = email;

            // Thiết lập ẩn mật khẩu ban đầu
            txt_matkhaumoi.UseSystemPasswordChar = true;
            txt_nhaplaimatkhau.UseSystemPasswordChar = true;

            // Thiết lập trạng thái nút mắt ban đầu (Nếu đã kéo nút vào Form)
            if (hien != null && An != null)
            {
                hien.Visible = true; // Mặc định hiện nút mắt mở
                An.Visible = false;
            }
        }

        // Hàm Hash đồng bộ với Form Đăng nhập
        private string CalculateSHA256(string plainText)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                return Convert.ToBase64String(bytes);
            }
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            string matKhauMoi = txt_matkhaumoi.Text.Trim();
            string xacNhanMatKhau = txt_nhaplaimatkhau.Text.Trim();

            // 1. KIỂM TRA DỮ LIỆU
            if (string.IsNullOrEmpty(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // (Đã bỏ kiểm tra độ dài theo yêu cầu của bạn)

            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 2. CẬP NHẬT DATABASE
                var user = db.NguoiDungs.FirstOrDefault(u => u.Email == emailCanDoiMatKhau);

                if (user != null)
                {
                    user.MatKhauHash = CalculateSHA256(matKhauMoi);
                    db.SaveChanges();

                    MessageBox.Show("Đổi mật khẩu thành công! Quay lại màn hình đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 3. QUAY VỀ FORM CŨ
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi: Không tìm thấy tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- SỬA LỖI Ở ĐÂY ---

        // Khi bấm nút ẨN (Mắt gạch chéo)
        private void An_Click(object sender, EventArgs e)
        {
            // Ẩn mật khẩu cho CẢ 2 Ô
            txt_matkhaumoi.UseSystemPasswordChar = true;
            txt_nhaplaimatkhau.UseSystemPasswordChar = true;

            An.Visible = false;
            hien.Visible = true;
        }

        // Khi bấm nút HIỆN (Con mắt mở)
        private void hien_Click(object sender, EventArgs e)
        {
            // Hiện mật khẩu cho CẢ 2 Ô
            txt_matkhaumoi.UseSystemPasswordChar = false;
            txt_nhaplaimatkhau.UseSystemPasswordChar = false;

            hien.Visible = false;
            An.Visible = true;
        }
    }
}