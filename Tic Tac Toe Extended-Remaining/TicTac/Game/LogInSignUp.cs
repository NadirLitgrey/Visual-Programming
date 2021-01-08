using System;
using System.IO;
using System.Windows.Forms;

namespace Game
{
    public partial class logInSignUp : Form
    {
        public logInSignUp()
        {
            InitializeComponent();
        }

        private void shutDownbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            try
            {

                string name = userNameBox.Text;
                string pass = passWordBox.Text;

                // Read a text file line by line.  
                string[] lines = File.ReadAllLines("Record.txt");
                int name_Line = 0, pass_line = 1, count_lines = 0;
                Console.WriteLine("Comes");
                foreach (string line in lines)
                {
                    count_lines++;
                }
                for (int i = 0; i < count_lines; i++)
                {
                    string getName = lines[name_Line];
                    name_Line += 3;
                    string getPass = lines[pass_line];
                    pass_line += 3;

                    if (getName.Equals(name) && getPass.Equals(pass))
                    {
                        AppLauncher launch=new AppLauncher();
                        launch.Show();
                        return;
                    }
                }

                MessageBox.Show("Invalid User name or Password\nTry Again");
                userNameBox.Text = "";
                passWordBox.Text = "";

            }
            catch (Exception ex) { }   
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {

            String filePath = "Record.txt";
            StreamWriter writer = new StreamWriter(filePath, true);

            writer.WriteLine(userNameBox.Text);
            writer.WriteLine(passWordBox.Text);
            writer.WriteLine("-------------");
            writer.Flush();
            writer.Close();
        }
    }
}
