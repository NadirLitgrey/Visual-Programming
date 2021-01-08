using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MP3_Media_Player
{
    public partial class Credentials : Form
    {
        public Credentials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String box1 = textBox1.Text;
                String box2 = textBox2.Text;

                FileStream file = null;
                file = File.Open("Credits.txt", FileMode.Append);

                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(box1);
                writer.WriteLine(box2);
                writer.Close();
                writer.Flush();

            }
            catch (Exception ex) { }
            this.Hide();
            CreatePlayList obj = new CreatePlayList();
            obj.Show();
            

        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}