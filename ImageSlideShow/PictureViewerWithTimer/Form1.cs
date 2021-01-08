using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewerWithTimer
{
    public partial class Form1 : Form
    {
        String[] images;
        static int imageNumber = 0;
        static Boolean previousButtonClicked = false;
        static Boolean nextButtonClicked = false;
        static Boolean flowIsDefault=true;
        public Form1()
        {
            InitializeComponent();
            images = new String[7];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            char ch = 'A';
            for (int i = 0; i < 6; i++)
            {
                images[i] = @"Resources\" + ch + ".jpg";
                ch++;
            }
            pictureBox1.Image = Image.FromFile(images[imageNumber]);

        }


        private void showNextImages()
        {
            if (imageNumber < images.Length - 2)
            {
                imageNumber++;
                pictureBox1.Image = Image.FromFile(images[imageNumber]);
                
            }
            else
            {
                imageNumber = 0;
                pictureBox1.Image = Image.FromFile(images[imageNumber]);
                
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            showPreviousImage();
            previousButtonClicked = true;
            nextButtonClicked = false;
        }

        private void showPreviousImage()
        {
            imageNumber--;
            if (imageNumber >= 0)
            {

                pictureBox1.Image = Image.FromFile(images[imageNumber]);

            }
            else
            {
                imageNumber = 5;
                pictureBox1.Image = Image.FromFile(images[imageNumber]);

            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            showNextImages();
            nextButtonClicked = true;
            previousButtonClicked = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void play_Click(object sender, EventArgs e)
        {

            timer1.Start();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            flowIsDefault = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextButtonClicked || flowIsDefault)
            {
                showNextImages();
                
            }
            else{
                showPreviousImage();
            }

        }
    }
}
