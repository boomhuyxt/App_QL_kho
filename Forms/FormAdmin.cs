using System;
using System.Windows.Forms;

namespace App_QL_kho.Forms
{
    public partial class FormAdmin : Form
    {
        // Biến lưu trữ Form đang hiển thị hiện tại
        private Form activeForm = null;

        public FormAdmin()
        {
            InitializeComponent();

            tsb_trangchu.Click += tsb_trangchu_Click;
            tsb_nhap.Click += tsb_nhap_Click;
            tsb_xuat.Click += tsb_xuat_Click;
            tsb_baocao.Click += tsb_baocao_Click;
            tsb_nguoidung.Click += tsb_nguoidung_Click;
            // Mở mặc định trang chủ khi vừa load Admin
            OpenChildForm(new FormTrangChu());
        }

        private void OpenChildForm(Form childForm)
        {
            // 1. Đóng Form cũ
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;

            // 2. Thiết lập Form con
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 3. XÓA tableLayoutPanel1 (vùng chứa GridView mặc định) ra khỏi Cột 2 để nhường chỗ
            // Cột 2 của tlp_home nằm ở vị trí (1, 0)
            Control oldControl = tlp_home.GetControlFromPosition(1, 0);
            if (oldControl != null && oldControl != childForm)
            {
                tlp_home.Controls.Remove(oldControl);
            }

            // 4. Thêm Form con vào đúng Cột 2 của TableLayoutPanel
            tlp_home.Controls.Add(childForm, 1, 0);

            childForm.Show();
        }

        // --- CÁC SỰ KIỆN CLICK ---

        private void tsb_trangchu_Click(object sender, EventArgs e) => OpenChildForm(new FormTrangChu());
        private void tsl_trangchu_Click(object sender, EventArgs e) => OpenChildForm(new FormTrangChu());

        private void tsb_nhap_Click(object sender, EventArgs e) => OpenChildForm(new FormNhap());
        private void tsl_nhap_Click(object sender, EventArgs e) => OpenChildForm(new FormNhap());

        private void tsb_xuat_Click(object sender, EventArgs e) => OpenChildForm(new FormXuat());
        private void tsl_xuat_Click(object sender, EventArgs e) => OpenChildForm(new FormXuat());

        private void tsb_baocao_Click(object sender, EventArgs e) => OpenChildForm(new FormBaoCao());
        private void tsl_baocao_Click(object sender, EventArgs e) => OpenChildForm(new FormBaoCao());

        private void tsb_nguoidung_Click(object sender, EventArgs e) => OpenChildForm(new FormNguoiDung());
        private void tsl_nguoidung_Click(object sender, EventArgs e) => OpenChildForm(new FormNguoiDung());

        private void tsb_donhang_Click(object sender, EventArgs e)
        {
            // Ví dụ: OpenChildForm(new FormDonHang());
        }
    }
}