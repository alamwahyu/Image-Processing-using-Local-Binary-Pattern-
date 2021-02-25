using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LBP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog(this);
            string imageFile = fileDialog.FileName;
            if (imageFile == string.Empty) return;
            initialPicture.Image = Image.FromFile(imageFile);
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            process toBlackWhite = new process();
            Bitmap image = new Bitmap(initialPicture.Image);
            toBlackWhite.blackWhite(image);
            convertedPicture.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(initialPicture.Image);
            int width = image.Width;
            int height = image.Height;

            //color of pixel
            Color p;

            //grayscale
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    p = image.GetPixel(x, y);

                    //extract pixel component ARGB
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //find average
                    int avg = (r + g + b) / 3;

                    //set new pixel value
                    image.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }

            //load grayscale image in picturebox2
            pictureBox1.Image = image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
