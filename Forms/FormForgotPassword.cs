using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace App_QL_kho.Forms
{
    public partial class FormForgotPassword : Form
    {
        private const string PLACEHOLDER_EMAIL = "Email";
        private const string PLACEHOLDER_CODE = "Mã xác thực";

        // Biến lưu mã xác thực hệ thống tạo ra để so sánh
        private string randomCode;
        private string toEmail;

        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            // 1. Setup Placeholder
            SetupTextBox(txt_emailForgotPassword, PLACEHOLDER_EMAIL);
            SetupTextBox(txt_MaXacThuc, PLACEHOLDER_CODE);
            txt_MaXacThuc.UseSystemPasswordChar = false;

            // 2. Mặc định ẩn Panel nhập mã (panel6)
            panel6.Visible = false;
        }

        private void SetupTextBox(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;
        }

        // --- Xử lý sự kiện Enter/Leave (Giữ nguyên như cũ) ---
        private void txt_emailForgotPassword_Enter(object sender, EventArgs e)
        {
            if (txt_emailForgotPassword.Text == PLACEHOLDER_EMAIL)
            {
                txt_emailForgotPassword.Text = "";
                txt_emailForgotPassword.ForeColor = Color.White;
            }
        }

        private void txt_emailForgotPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_emailForgotPassword.Text))
            {
                SetupTextBox(txt_emailForgotPassword, PLACEHOLDER_EMAIL);
            }
        }

        private void txt_MaXacThuc_Enter(object sender, EventArgs e)
        {
            if (txt_MaXacThuc.Text == PLACEHOLDER_CODE)
            {
                txt_MaXacThuc.Text = "";
                txt_MaXacThuc.ForeColor = Color.White;
            }
        }

        private void txt_MaXacThuc_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaXacThuc.Text))
            {
                SetupTextBox(txt_MaXacThuc, PLACEHOLDER_CODE);
            }
        }

        // --- LOGIC CHÍNH CỦA NÚT XÁC NHẬN ---
        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            // TRƯỜNG HỢP 1: Chưa gửi mã (Panel nhập mã đang ẩn)
            if (panel6.Visible == false)
            {
                string emailInput = txt_emailForgotPassword.Text.Trim();

                if (emailInput == PLACEHOLDER_EMAIL || string.IsNullOrEmpty(emailInput))
                {
                    MessageBox.Show("Vui lòng nhập Email!");
                    return;
                }

                // Kiểm tra Email tồn tại (Hàm giả lập)
                if (!CheckEmailExistsInDatabase(emailInput))
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống!");
                    return;
                }

                try
                {
                    Random rand = new Random();
                    randomCode = (rand.Next(100000, 999999)).ToString();
                    toEmail = emailInput;

                    SendEmail(toEmail, randomCode);

                    // Hiện panel nhập mã
                    panel6.Visible = true;
                    btn_xacNhan.Text = "Xác nhận mã";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi gửi mail: " + ex.Message);
                }
            }
            // TRƯỜNG HỢP 2: Đang nhập mã xác thực (Panel nhập mã đang hiện)
            else
            {
                if (txt_MaXacThuc.Text == randomCode)
                {
                    MessageBox.Show("Xác thực thành công!", "Thông báo");

                    // --- BƯỚC CHUYỂN FORM ---

                    // 1. Ẩn form Quên mật khẩu hiện tại đi
                    this.Hide();

                    // 2. Khởi tạo Form Đổi Mật Khẩu
                    // Lưu ý: Bạn cần tạo FormDoiMatKhau trong project trước
                    FormDoiMatKhau frmDoiMatKhau = new FormDoiMatKhau(toEmail);

                    // 3. Hiển thị Form Đổi Mật Khẩu
                    frmDoiMatKhau.ShowDialog();

                    // 4. Đóng Form Quên Mật Khẩu sau khi Form kia tắt
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã xác thực không đúng! Vui lòng thử lại.", "Lỗi");
                }
            }
        }

        // --- HÀM GIẢ LẬP KIỂM TRA DATABASE ---
        private bool CheckEmailExistsInDatabase(string email)
        {
          
            return true;
        }

        // --- HÀM GỬI EMAIL (Sử dụng Gmail SMTP) ---

            private void SendEmail(string userEmail, string code)
            {
                try
                {
                    // 1. Điền email GMAIL của bạn (người gửi)
                    string fromEmail = "boomhuyxt@gmail.com"; // <--- SỬA DÒNG NÀY THÀNH EMAIL CỦA BẠN

                    // 2. Điền mật khẩu ứng dụng bạn vừa gửi
                    string passWord = "wjxt ycdi gavz kdbu"; // <--- Đã điền xong

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(fromEmail);
                    message.To.Add(userEmail);
                    message.Subject = "Mã xác thực khôi phục mật khẩu";
                    message.Body = "Mã xác thực của bạn là: " + code + "\n\nVui lòng không chia sẻ mã này.";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(fromEmail, passWord);

                    smtp.Send(message);
                    MessageBox.Show("Đã gửi mã xác thực thành công! Hãy kiểm tra Email.", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi gửi mail: " + ex.Message + "\n\n(Hãy chắc chắn bạn đã nhập đúng Email của mình ở dòng fromEmail)");
                }
            }
        
    }
}