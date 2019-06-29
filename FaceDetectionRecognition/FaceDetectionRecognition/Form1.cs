using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Image<Bgr, byte> frame;
        Capture camera;
        Image<Gray, byte> result;
        Image<Gray, byte> trainedFace = null;
        Image<Gray, byte> grayFace = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> user = new List<string>();
        int count, numLabels, t;
        string name, names = null;

        public Form1()
        {
            InitializeComponent();

            //HaarCascade is for face detection
            faceDetected = new HaarCascade("haarcascade_frontalface_default.xml");

            try
            {
                string labelsInfo = File.ReadAllText(Application.StartupPath + "/Faces/Faces.txt");
            }
            catch
            {
                MessageBox.Show("Nothing in show Database");
            }
        }

        private void detectionRecognitionBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
