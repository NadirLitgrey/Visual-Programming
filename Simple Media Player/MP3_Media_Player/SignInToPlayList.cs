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
    public partial class SignInToPlayList : Form
    {
        public static Boolean signedInSuccess = false;
        public SignInToPlayList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string name = textBox1.Text;
                string pass = textBox2.Text;

                // Read a text file line by line.  
                string[] lines = File.ReadAllLines("Credits.txt");
                int name_Line = 0, pass_line = 1, count_lines=0;
                
                foreach (string line in lines)
                {
                    count_lines++;
                    
                }
                for(int i=0;i<count_lines;i++)
                {
                    string getName=lines[name_Line];
                    name_Line += 2;
                    string getPass = lines[pass_line];
                    pass_line += 2;

                    if (getName.Equals(name) && getPass.Equals(pass))
                    {

                        MessageBox.Show("Logged In");
                        pass_line += 2;
                        name_Line += 2;
                        count_lines++;
                        signedInSuccess = true;
                        return;
                    }
                    
                }
                
            }
            catch (Exception ex) { }
            if (!signedInSuccess)
            {
                MessageBox.Show("Invalid User name or Password\nTry Again");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
