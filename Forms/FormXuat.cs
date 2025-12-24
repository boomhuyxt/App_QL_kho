using App_QL_kho.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_QL_kho
{
    public partial class FormXuat : Form
    {
        private CameraQR camera;
        public FormXuat()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            camera = new CameraQR(cb_camera, pictureBox, txt_box);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            camera.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            camera.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            camera.Stop();
        }
    }
}
