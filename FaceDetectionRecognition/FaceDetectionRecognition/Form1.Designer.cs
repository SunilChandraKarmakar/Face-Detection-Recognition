namespace FaceDetectionRecognition
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.detectionRecognitionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(12, 12);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(592, 383);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            // 
            // detectionRecognitionBtn
            // 
            this.detectionRecognitionBtn.Location = new System.Drawing.Point(167, 413);
            this.detectionRecognitionBtn.Name = "detectionRecognitionBtn";
            this.detectionRecognitionBtn.Size = new System.Drawing.Size(247, 35);
            this.detectionRecognitionBtn.TabIndex = 3;
            this.detectionRecognitionBtn.Text = "Start Detection And Recognition";
            this.detectionRecognitionBtn.UseVisualStyleBackColor = true;
            this.detectionRecognitionBtn.Click += new System.EventHandler(this.detectionRecognitionBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 500);
            this.Controls.Add(this.detectionRecognitionBtn);
            this.Controls.Add(this.cameraBox);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Face Detection Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button detectionRecognitionBtn;
    }
}

