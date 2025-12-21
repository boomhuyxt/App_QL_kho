using System;
using System.Linq;
using System.Windows.Forms;
using App_QL_kho.Forms;

namespace App_QL_kho.Services
{
    internal class Menu
    {
        // Đây phải là Panel (khung chứa), không phải ToolStrip
        private Panel pnl_display;
        private Form _activeForm = null;

        // Constructor nhận vào Panel hiển thị nội dung
        public Menu(Panel pnl_display)
        {
            this.pnl_display = pnl_display;
        }

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null && _activeForm.GetType() == childForm.GetType())
                return;

            if (_activeForm != null)
                _activeForm.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Xóa nội dung cũ trong Panel và thêm Form mới vào
            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(childForm);
            pnl_display.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        // --- CÁC SỰ KIỆN CLICK ---
        public void tsb_trangchu_Click(object sender, EventArgs e) => OpenChildForm(new FormTrangChu());
        public void tsl_trangchu_Click(object sender, EventArgs e) => OpenChildForm(new FormTrangChu());

        public void tsb_nhap_Click(object sender, EventArgs e) => OpenChildForm(new FormNhap());
        public void tsl_nhap_Click(object sender, EventArgs e) => OpenChildForm(new FormNhap());

        public void tsb_xuat_Click(object sender, EventArgs e) => OpenChildForm(new FormXuat());
        public void tsl_xuat_Click(object sender, EventArgs e) => OpenChildForm(new FormXuat());

        public void tsb_baocao_Click(object sender, EventArgs e) => OpenChildForm(new FormBaoCao());
        public void tsl_baocao_Click(object sender, EventArgs e) => OpenChildForm(new FormBaoCao());

        public void tsb_nguoidung_Click(object sender, EventArgs e) => OpenChildForm(new FormNguoiDung());
        public void tsl_nguoidung_Click(object sender, EventArgs e) => OpenChildForm(new FormNguoiDung());
    }
}