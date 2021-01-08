using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Task3_PuzzleGame
{
    public partial class FormPuzzle : Form
    {

        String[] images= new String[16];
        static String originalPicPath = "";
        static int chances = 1;
        static Button[] buttonArray= new Button[16];
        public FormPuzzle()
        {
            InitializeComponent();
            
        }

        private void FormPuzzle_Load(object sender, EventArgs e)
        {
            LoadImages();
        }
        private void infoBtn_Click(object sender, EventArgs e)
        {

        }
        public void LoadImages()
        {

            /*
             Place random pic at original place
             */
            
            Random random = new Random();
            int randomNumber1 = random.Next(1, 17);
            
            originalPicPath = @"F:\5th Semester\Visual Programming\Labs\Lab_04\Task3_PuzzleGame\Task3_PuzzleGame\puzzle-pictures\candy" + randomNumber1 + ".jpg";
            this.picBtn.Image = Image.FromFile(originalPicPath);

            LoadButtons();

            //Initialize String array objects

            for (int i = 0; i < 16; i++) {
                images[i] = "";
            }
            
            SetOriginalPicAtRandomPositions();
            SetRestOfPics();

        }
        public void LoadButtons() {
            
            int i = 15;            
            foreach (Control c in this.Controls) {

                if (c is Button && c.Tag== "SubPics") {
                    buttonArray[i] = (Button)c;
                    buttonArray[i].Text = ""+i;

                    i--;
                }
            }
        }
        public void SetOriginalPicAtRandomPositions() {
            
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int randomNumber2 = random.Next(0, 15);
                if (images[randomNumber2].Length == 0)
                {
                    images[randomNumber2] = originalPicPath;
                }
                else
                {
                    i--;
                }
            }
        }
        public void SetRestOfPics() {

            
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                int randomNumber1 = random.Next(1, 17);
                int randomNumber2 = random.Next(0, 16);
                String path= @"F:\5th Semester\Visual Programming\Labs\Lab_04\Task3_PuzzleGame\Task3_PuzzleGame\puzzle-pictures\candy" + randomNumber1 + ".jpg";
                if (images[randomNumber2].Length == 0 && path!=originalPicPath)
                {
                    images[randomNumber2] = path;
                }
                else
                {
                    i--;
                }
            }
        }
        public void SetOnButtons(int index) {

                buttonArray[index].Image =Image.FromFile(images[index]);
            if (chances < 3)
            {
                if (images[index] == originalPicPath)
                {
                    DialogResult result = MessageBox.Show("You Won The Game", "Game Over", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        ReplayGame();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else {
                DialogResult result = MessageBox.Show("Do you want to play again?", "Game Over", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ReplayGame();
                }
                else {
                    Application.Exit();
                }
            }
            chances++;
        }
        public void ReplayGame() {


            foreach (Button b in buttonArray) {

                b.Text = "";
                b.Image = null;
            }
            this.picBtn.Image = null;
            

            this.Load += FormPuzzle_Load;
            chances = 0;
            originalPicPath = "";

            Random random = new Random();
            int randomNumber1 = random.Next(1, 17);
            originalPicPath = @"F:\5th Semester\Visual Programming\Labs\Lab_04\Task3_PuzzleGame\Task3_PuzzleGame\puzzle-pictures\candy" + randomNumber1 + ".jpg";
            this.picBtn.Image = Image.FromFile(originalPicPath);

        }


        private void btn1_Click(object sender, EventArgs e)
        {
            SetOnButtons(0);   
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            SetOnButtons(1);
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            SetOnButtons(2);
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            SetOnButtons(3);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SetOnButtons(7);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            SetOnButtons(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            SetOnButtons(5);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            SetOnButtons(4);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SetOnButtons(11);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            SetOnButtons(10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            SetOnButtons(9);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            SetOnButtons(8);
        }

        private void btn13_Click(object sender, EventArgs e)
        {

            SetOnButtons(15);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            SetOnButtons(14);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            SetOnButtons(13);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            SetOnButtons(12);
        }

    }
}