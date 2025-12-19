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
        private PictureBox pictureBox1;
        private TextBox txt_box;

        public CameraQR(ComboBox cbCamera, PictureBox picBox, TextBox txtBox)
        {
            cb_camera = cbCamera;
            pictureBox1 = picBox;
            txt_box = txtBox;

            LoadCamera();
        }

        public void Start()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
                return;

            if (cb_camera.SelectedIndex < 0) return;

            videoCaptureDevice = new VideoCaptureDevice(
                filterInfoCollection[cb_camera.SelectedIndex].MonikerString);

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
            foreach (FilterInfo camera in filterInfoCollection)
            {
                cb_camera.Items.Add(camera.Name);
            }

            if (cb_camera.Items.Count > 0)
                cb_camera.SelectedIndex = 0;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            pictureBox1.Invoke(new Action(() =>
            {
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = (Bitmap)bitmap.Clone();
            }));

            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null)
            {
                txt_box.Invoke(new Action(() =>
                {
                    txt_box.Text = result.Text;
                }));
            }

            bitmap.Dispose();
        }
    }
}
