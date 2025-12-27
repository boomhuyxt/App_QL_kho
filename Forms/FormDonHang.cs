using App_QL_kho.Data;
using App_QL_kho.Models;
using App_QL_kho.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace App_QL_kho.Forms
{
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
            // Đăng ký sự kiện
            this.Load += FormDonHang_Load;
            this.txt_sanPham.TextChanged += (s, e) => FilterData();
            this.cmb_nhomSP.SelectedIndexChanged += (s, e) => FilterData();
            this.dtp_thoiGian.ValueChanged += (s, e) => FilterData();
            this.cb_XuatFile.SelectedIndexChanged += cb_XuatFile_SelectedIndexChanged;
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadComboboxNhom();
            FilterData();
        }

        private void SetupDataGridView()
        {
            dgv_trangchu.AutoGenerateColumns = false;
            Column1.DataPropertyName = "Stt";
            Column2.DataPropertyName = "TenNhom";
            Column3.DataPropertyName = "TenSP";
            Column4.DataPropertyName = "TonKho";
            Column5.DataPropertyName = "GiaBan";
        }

        private void LoadComboboxNhom()
        {
            try
            {
                using (var db = new Model1())
                {
                    var listNhom = db.NhomSanPhams.ToList();
                    listNhom.Insert(0, new NhomSanPham { MaNhom = -1, TenNhom = "Tất cả nhóm" });
                    cmb_nhomSP.DataSource = listNhom;
                    cmb_nhomSP.DisplayMember = "TenNhom";
                    cmb_nhomSP.ValueMember = "MaNhom";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void FilterData()
        {
            try
            {
                using (var db = new Model1())
                {
                    DateTime selectedDate = dtp_thoiGian.Value.Date;
                    var query = from sp in db.SanPhams
                                join nhom in db.NhomSanPhams on sp.MaNhom equals nhom.MaNhom
                                select new
                                {
                                    MaSP = sp.MaSP,
                                    TenNhom = nhom.TenNhom,
                                    TenSP = sp.TenSP,
                                    TonKho = sp.SoLuong,
                                    GiaBan = sp.GiaXuat,
                                    NgayNhap = db.CT_PhieuNhap.Where(ct => ct.MaSP == sp.MaSP).Max(ct => (DateTime?)ct.PhieuNhap.NgayNhap)
                                };

                    if (!string.IsNullOrWhiteSpace(txt_sanPham.Text))
                        query = query.Where(x => x.TenSP.ToLower().Contains(txt_sanPham.Text.ToLower()));

                    if (cmb_nhomSP.SelectedValue != null && (int)cmb_nhomSP.SelectedValue != -1)
                        query = query.Where(x => x.TenNhom == cmb_nhomSP.Text);

                    query = query.Where(x => x.NgayNhap >= selectedDate);

                    dgv_trangchu.DataSource = query.ToList().Select((x, index) => new Model_TrangChu
                    {
                        Stt = index + 1,
                        MaSP = x.MaSP,
                        TenNhom = x.TenNhom,
                        TenSP = x.TenSP,
                        TonKho = x.TonKho,
                        GiaBan = x.GiaBan,
                        NgayNhapGanNhat = x.NgayNhap
                    }).ToList();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        // --- XỬ LÝ XUẤT FILE ---
        private void cb_XuatFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu trước khi xuất
            if (cb_XuatFile.SelectedIndex <= 0) return;

            if (dgv_trangchu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                cb_XuatFile.SelectedIndex = 0;
                return;
            }

            string selectedType = cb_XuatFile.SelectedItem.ToString().ToUpper();

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Chọn nơi lưu file báo cáo";

                // Cấu hình Filter
                if (selectedType.Contains("EXCEL")) sfd.Filter = "Excel Workbook|*.xlsx";
                else if (selectedType.Contains("PDF")) sfd.Filter = "PDF File|*.pdf";
                else if (selectedType.Contains("WORD")) sfd.Filter = "Word Document|*.docx";
                else sfd.Filter = "All Files|*.*";

                sfd.FileName = "BaoCao_DonHang_" + DateTime.Now.ToString("yyyyMMdd_HHmm");

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    this.Cursor = Cursors.WaitCursor;

                    try
                    {
                        // Thực thi xuất file
                        if (selectedType == "TẤT CẢ")
                        {
                            string dir = Path.GetDirectoryName(path);
                            string name = Path.GetFileNameWithoutExtension(path);

                            ExportService.ExportToExcel(dgv_trangchu, Path.Combine(dir, name + ".xlsx"));
                            ExportService.ExportToPDF(dgv_trangchu, Path.Combine(dir, name + ".pdf"));
                            ExportService.ExportToWord(dgv_trangchu, Path.Combine(dir, name + ".docx"));
                        }
                        else
                        {
                            if (selectedType.Contains("EXCEL")) ExportService.ExportToExcel(dgv_trangchu, path);
                            else if (selectedType.Contains("PDF")) ExportService.ExportToPDF(dgv_trangchu, path);
                            else if (selectedType.Contains("WORD")) ExportService.ExportToWord(dgv_trangchu, path);
                        }

                        MessageBox.Show("Đã lưu file thành công tại:\n" + path, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thực thi: " + ex.Message, "Lỗi Hệ Thống");
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                        // Ngắt sự kiện để reset mà không bị lặp loop
                        this.cb_XuatFile.SelectedIndexChanged -= cb_XuatFile_SelectedIndexChanged;
                        cb_XuatFile.SelectedIndex = 0;
                        this.cb_XuatFile.SelectedIndexChanged += cb_XuatFile_SelectedIndexChanged;
                    }
                }
                else
                {
                    cb_XuatFile.SelectedIndex = 0;
                }
            }
        }
    }
}