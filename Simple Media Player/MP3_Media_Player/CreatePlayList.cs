using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MP3_Media_Player
{
    public partial class CreatePlayList : Form
    {
        public CreatePlayList()
        {
            InitializeComponent();
        }
        string [] files, path;

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G40JEGJ;Initial Catalog=store;Integrated Security=True;");
            
            SqlCommand command = new SqlCommand();
            
            command.Connection = con;
            con.Open();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                files = openFileDialog1.SafeFileNames;
                path = openFileDialog1.FileNames;
                for (int i = 0; i < files.Length; i++) {
                    listBox1.Items.Add(files[i]);
                    
                    command.CommandText = "Insert Into List Values(@file_name, @content)";
                    command.Parameters.AddWithValue("file_name",files[i]);
                    command.Parameters.AddWithValue("content",SqlDbType.VarBinary).Value=File.ReadAllBytes(files[i]);
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
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

        public string listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.selectedFromList = true;
            return path[listBox1.SelectedIndex];
            
        }
    }
}
