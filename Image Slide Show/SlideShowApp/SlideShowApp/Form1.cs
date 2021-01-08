using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace SlideShowApp
{
    public partial class Form1 : Form
    {
        static String[] imagePath=new string[100];
        static int imageIndex = 0;
        static int index = 0;


        static Boolean previousButtonClicked = false;
        static Boolean nextButtonClicked = false;
        static Boolean flowIsDefault = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo d in drives) {
                drivesBox.Items.Add(d.Name);
            }    
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            showNextImages();

            nextButtonClicked = true;
            previousButtonClicked = false;

        }

        private void showNextImages()
        {
            if (imageIndex < index-1)
            {
                imageIndex++;
                pictureBox1.Image = Image.FromFile(imagePath[imageIndex]);

            }
            else
            {
                imageIndex = 0;
                pictureBox1.Image = Image.FromFile(imagePath[imageIndex]);

            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            showPreviousImages();

            previousButtonClicked = true;
            nextButtonClicked = false;
        }

        private void showPreviousImages()
        {
            imageIndex--;
            if (imageIndex >= 0)
            {
                pictureBox1.Image = Image.FromFile(imagePath[imageIndex]);

            }
            else
            {
                imageIndex = index-1;
                pictureBox1.Image = Image.FromFile(imagePath[imageIndex]);

            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {

            timer1.Start();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            flowIsDefault = false;
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            imageIndex = 0;
            pictureBox1.Image = Image.FromFile(imagePath[imageIndex]);
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            imageIndex = index-1;
            pictureBox1.Image = Image.FromFile(imagePath[imageIndex]);
        }

        private void drivesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imagePath = new string[100];
            imageIndex = 0;
            index = 0;


            previousButtonClicked = false;
            nextButtonClicked = false;
            flowIsDefault = true;

            DirectoryInfo dir = new DirectoryInfo(drivesBox.Text);
            DirectoryInfo[] directories = dir.GetDirectories();
            directoryBox.Items.Clear();
            foreach (DirectoryInfo d in directories) {
                directoryBox.Items.Add(d.Name);
            }
        }

        private void directoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str = directoryBox.SelectedItem.ToString();
            
            FileInfo i = new FileInfo(drivesBox.SelectedItem.ToString()+str+@"\");
            FileInfo[] files = i.Directory.GetFiles();
            int counter = 0;
            
            foreach (FileInfo fi in files)
            {
                if (fi.Name.ToUpper().EndsWith("PNG") || fi.Name.ToUpper().EndsWith("JPG"))
                {
                    counter++;
                }
            }
            
            foreach (FileInfo fi in files)
            {
                if (fi.Name.ToUpper().EndsWith("PNG") || fi.Name.ToUpper().EndsWith("JPG"))
                {
                    imagePath[index]= fi.FullName;
                    index++;
                }
            }
            if (index > 0) {
                pictureBox1.Image = Image.FromFile(imagePath[imageIndex]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextButtonClicked || flowIsDefault)
            {
                showNextImages();

            }
            else
            {
                showPreviousImages();
            }
        }
    }
}
