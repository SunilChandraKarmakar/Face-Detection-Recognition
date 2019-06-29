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
        MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
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
                string[] Labels = labelsInfo.Split(',');

                //The first lables before, will be the number of face saved.
                numLabels = Convert.ToInt16(Labels[0]);
                count = numLabels;
                string FacesLoad;

                for (int i = 1; i < numLabels + 1; i++)
                {
                    FacesLoad = "face" + i + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/Faces/Faces.txt"));
                    labels.Add(Labels[i]);
                }
            }
            catch
            {
                MessageBox.Show("Nothing in show Database");
            }
        }

        private void detectionRecognitionBtn_Click(object sender, EventArgs e)
        {
            camera = new Capture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(FrameProcudere);
        }

        private void FrameProcudere(object sender, EventArgs e)
        {
            user.Add("");
            frame = camera.QueryFrame().Resize(500, 400, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            grayFace = frame.Convert<Gray, byte>();
            MCvAvgComp[][] facesDetectedNow = grayFace.DetectHaarCascade(faceDetected, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20,20));

            foreach (MCvAvgComp f in facesDetectedNow[0])
            {
                result = frame.Copy(f.rect).Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                frame.Draw(f.rect, new Bgr(Color.Green), 2);

                if (trainingImages.ToArray().Length != 0)
                {
                    MCvTermCriteria termCritera = new MCvTermCriteria(count, 0.001);
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 1500, ref termCritera);
                    name = recognizer.Recognize(result);
                    frame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                }

                //user[t - 1] = name;
                user.Add("");
            }

            cameraBox.Image = frame;
            name = "";
            user.Clear();
        }
    }
}
