using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class splashForm : Form
    {
        Color[] colors = new Color[5];
        static int i = 0;
        public splashForm()
        {
            InitializeComponent();
        }

        private void splashForm_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            colors[0] = Color.Yellow;
            colors[1] = Color.White;
            colors[2] = Color.Black;
            colors[3] = Color.Aqua;
            colors[4] = Color.Pink;
            
            timer1.Start();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                return;
            }
            showProgressText.Text = progressBar1.Value+"%";
            if (progressBar1.Value % 20 == 0) {
                label1.ForeColor = colors[i];
                i++;
            }
            progressBar1.Value++;
        }
    }
}
