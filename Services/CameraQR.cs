using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace App_QL_kho.Services
{
    public class CameraQR
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

        private ComboBox cb_camera;
        private PictureBox pictureBoxPreview;
        private FormXuat parentForm;

        public CameraQR(ComboBox cb, PictureBox pic, FormXuat parent)
        {
            this.cb_camera = cb;
            this.pictureBoxPreview = pic;
            this.parentForm = parent;
            LoadCamera();
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
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.SignalToStop();
                    videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
                }
                videoCaptureDevice = null;
            }
        }

        private void LoadCamera()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cb_camera.Items.Clear();
            foreach (FilterInfo camera in filterInfoCollection) cb_camera.Items.Add(camera.Name);
            if (cb_camera.Items.Count > 0) cb_camera.SelectedIndex = 0;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Kiểm tra FormXuat còn tồn tại hay không trước khi xử lý (Sửa lỗi hình image_33d0ce)
            if (parentForm == null || parentForm.IsDisposed) return;

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            // Cập nhật giao diện an toàn (Sửa lỗi hình image_7778e1)
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
                catch { /* Bỏ qua nếu Form đang đóng */ }
            }

            // Giải mã Barcode/QR
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null && !parentForm.IsDisposed)
            {
                try
                {
                    parentForm.Invoke(new Action(() =>
                    {
                        if (!parentForm.IsDisposed && parentForm.lastScannedCode != result.Text)
                        {
                            parentForm.lastScannedCode = result.Text;
                            parentForm.HandleScannedResult(result.Text);
                        }
                    }));
                }
                catch { /* Bỏ qua nếu Form đang đóng */ }
            }
            bitmap.Dispose();
        }
    }
}