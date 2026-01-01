using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;

namespace App_QL_kho.Services
{
    public class CameraQR
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        private ComboBox cb_camera;
        private PictureBox pictureBoxPreview;
        private FormXuat parentForm;

        // TỐI ƯU 1: Khởi tạo Reader một lần duy nhất để dùng lại, tiết kiệm tài nguyên CPU
        private readonly BarcodeReader reader;

        public CameraQR(ComboBox cb, PictureBox pic, FormXuat parent)
        {
            this.cb_camera = cb;
            this.pictureBoxPreview = pic;
            this.parentForm = parent;

            // Cấu hình Reader tối ưu cho cả QR và Barcode
            reader = new BarcodeReader
            {
                AutoRotate = true, // Tự động xoay ảnh để tìm mã
                Options = new DecodingOptions
                {
                    // TỐI ƯU 2: Chỉ định rõ các định dạng cần quét để máy tập trung xử lý nhanh hơn
                    PossibleFormats = new List<BarcodeFormat>
                    {
                        BarcodeFormat.QR_CODE,     
                        BarcodeFormat.CODE_128,    
                        BarcodeFormat.EAN_13,      
                        BarcodeFormat.CODE_39     
                    },
                    TryHarder = true,      
                    PureBarcode = false    
                }
            };

            LoadCamera();
        }

        // ... Các hàm LoadCamera, Start, Stop giữ nguyên từ code cũ của bạn ...

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (parentForm == null || parentForm.IsDisposed) return;

            // TỐI ƯU 3: Sử dụng ảnh gốc trực tiếp để giải mã trước khi Clone cho hiển thị
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            // Hiển thị Preview lên PictureBox
            if (pictureBoxPreview.IsHandleCreated && !pictureBoxPreview.IsDisposed)
            {
                try
                {
                    pictureBoxPreview.Invoke(new Action(() =>
                    {
                        if (pictureBoxPreview.IsDisposed) return;
                        pictureBoxPreview.Image?.Dispose();
                        pictureBoxPreview.Image = (Bitmap)bitmap.Clone();
                    }));
                }
                catch { }
            }

            // Thực hiện giải mã
            var result = reader.Decode(bitmap);

            if (result != null && !parentForm.IsDisposed)
            {
                try
                {
                    parentForm.Invoke(new Action(() =>
                    {
                        // Kiểm tra mã vừa quét có khác mã trước đó không để tránh lặp lại liên tục (Debounce)
                        if (!parentForm.IsDisposed && parentForm.lastScannedCode != result.Text)
                        {
                            parentForm.lastScannedCode = result.Text;

                            // Phản hồi rung hoặc tiếng bip có thể thêm ở đây
                            parentForm.HandleScannedResult(result.Text);
                        }
                    }));
                }
                catch { }
            }

            // Giải phóng bộ nhớ ảnh
            bitmap.Dispose();
        }

        // Bổ sung thêm các phương thức LoadCamera, Start, Stop nếu bị thiếu trong file đính kèm
        private void LoadCamera()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cb_camera.Items.Clear();
            foreach (FilterInfo camera in filterInfoCollection) cb_camera.Items.Add(camera.Name);
            if (cb_camera.Items.Count > 0) cb_camera.SelectedIndex = 0;
        }

        public void Start()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning) return;
            if (cb_camera.SelectedIndex < 0) return;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cb_camera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        public void Stop()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
                videoCaptureDevice = null;
            }
        }
    }
}