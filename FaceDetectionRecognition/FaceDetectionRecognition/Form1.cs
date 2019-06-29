using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetectionRecognition
{
    public partial class Form1 : Form
    {
        //Declear variable
        HaarCascade faceDetected;

        public Form1()
        {
            InitializeComponent();
            faceDetected = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        private void detectionRecognitionBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
