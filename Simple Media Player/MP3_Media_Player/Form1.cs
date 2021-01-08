using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Media_Player
{
    public partial class Form1 : Form
    {
        SignInToPlayList signInToPlayList = new SignInToPlayList();
        CreatePlayList createPlayListObject = new CreatePlayList();
        public static Boolean selectedFromList = false;
        public static Boolean openedSong = false;

        public Form1()
        {
            InitializeComponent();
            
        }

        string[] files, path;

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Credentials obj = new Credentials();
            obj.Show();
        }

        //PlayList
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            signInToPlayList.Show();
            if (SignInToPlayList.signedInSuccess==true)
            {
                removeItem.Enabled = true;
                saveItem.Enabled = false;

            }
            else {
                removeItem.Enabled = false;
                saveItem.Enabled = true;

            }
            
        }

        //Save to playList
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
 
        }
        //Remove From Playlist
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            

        }
        //exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //Create playlist
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                files = openFileDialog1.SafeFileNames;

                path = openFileDialog1.FileNames;
                axWindowsMediaPlayer1.URL = path[0];
                
                removeItem.Enabled = false;
                saveItem.Enabled = true;
            }
            
        }

    }
}
