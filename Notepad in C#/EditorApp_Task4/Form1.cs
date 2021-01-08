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

namespace EditorApp_Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\";
            open.Title = "Open Text Files";
            open.Filter = "Text|*.txt";

            if (open.ShowDialog() == DialogResult.OK) {

                String[] file = File.ReadAllLines(open.FileName);

                foreach (String line in file) {

                    textArea.Text += line+"\n";
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save= new SaveFileDialog();
            save.InitialDirectory = @"C:\";
            save.Title = "Open Text Files";
            save.Filter = "Text|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                String[] content = { this.textArea.Text };
                File.WriteAllLines(save.FileName,content);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textArea.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textArea.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textArea.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textArea.Copy();
        }

        private void pasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textArea.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textArea.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = false;

            if (font.ShowDialog() == DialogResult.OK) {
                this.textArea.Font = font.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.Color = this.textArea.ForeColor;
            color.ShowHelp = false;
            
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.textArea.ForeColor = color.Color;
            }
        }
    }
}
