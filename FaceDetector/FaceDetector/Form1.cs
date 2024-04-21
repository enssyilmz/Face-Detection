using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace FaceDetector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FaceRec faceRec=new FaceRec();
        bool camcontrol;

        private void opencambtn_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(camerapbx, capturepbx);
            camcontrol = true;
        }

        private void saveimgbtn_Click(object sender, EventArgs e)
        {

            if (camcontrol)
            {
                if (string.IsNullOrWhiteSpace(nametbx.Text))
                {
                    MessageBox.Show("Please enter a name!");
                }
                else
                {
                    try
                    {
                        faceRec.Save_IMAGE(nametbx.Text.ToUpper());
                        MessageBox.Show("Image saved..!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please open the camera first!");
            }

        }

        private void detectfacebtn_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
        }
    }
}
