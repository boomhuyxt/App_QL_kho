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
        private TextBox txt_result;
        private FormXuat parentForm; 

        public CameraQR(ComboBox cb, PictureBox pic, TextBox txt, FormXuat parent)
        {
            this.cb_camera = cb;
            this.pictureBoxPreview = pic;
            this.txt_result = txt;
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
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
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
            if (parentForm == null || parentForm.IsDisposed) return; // Kiểm tra Form cha còn tồn tại không

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            // Hiển thị camera lên PictureBox an toàn
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
                catch { /* Bỏ qua nếu form đang đóng */ }
            }

            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null && !parentForm.IsDisposed)
            {
                try
                {
                    parentForm.Invoke(new Action(() =>
                    {
                        if (!parentForm.IsDisposed && txt_result.Text != result.Text)
                        {
                            parentForm.HandleScannedResult(result.Text);
                        }
                    }));
                }
                catch { /* Bỏ qua nếu form đang đóng */ }
            }
            bitmap.Dispose();
        }
    }
}