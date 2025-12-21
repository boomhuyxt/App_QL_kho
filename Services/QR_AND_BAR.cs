using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using Zen.Barcode;

namespace App_QL_kho.Services
{
    internal class QR_AND_BAR
    {
        // ======================
        // XỬ LÝ TIẾNG VIỆT
        // ======================
        public string RemoveVietnameseDiacritics(string text)
        {
            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalized)
            {
                if (Char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        // ======================
        // TẠO QR CODE
        // ======================
        public Bitmap GenerateQRCode(string content)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData =
                qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.H);

            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(10);
        }

        // ======================
        // TẠO BARCODE
        // ======================
        public Bitmap GenerateBarcode(string content)
        {
            string barcodeText = RemoveVietnameseDiacritics(content);
            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;

            return (Bitmap)barcode.Draw(barcodeText, 60);
        }

        public void SaveImage(Bitmap image, string fileName)
        {
            try
            {

                string folderPath = "C:\\QR_AND_BAR_Images";
                if (!System.IO.Directory.Exists(folderPath))
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }

                string fullPath = System.IO.Path.Combine(folderPath, fileName + ".png");

                image.Save(fullPath, ImageFormat.Png);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi lưu hình ảnh: " + ex.Message);
            }
        }
    }
}   

