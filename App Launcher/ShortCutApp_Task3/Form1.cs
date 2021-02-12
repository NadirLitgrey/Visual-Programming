//I am adding this to copy branch
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCutApp_Task3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button notepad = new Button();
            notepad.SetBounds(120,50,200,30);
            notepad.Text = "Notepad";
            notepad.Click += Notepad_Click;
           
            Button paint = new Button();
            paint.SetBounds(120, 100, 200, 30);
            paint.Text = "MS Paint";
            paint.Click += Paint_Click;

            Button powerpnt = new Button();
            powerpnt.SetBounds(120, 170, 200, 30);
            powerpnt.Text = "MS Power Point";
            powerpnt.Click += Powerpnt_Click;

            this.Controls.Add(notepad);
            this.Controls.Add(paint);
            this.Controls.Add(powerpnt);
        }

        private void Powerpnt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powerpnt.exe");
        }

        private void Paint_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");

        }

        private void Notepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
