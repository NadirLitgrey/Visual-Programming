using System;
using System.Windows.Forms;

namespace TrexEndless
{
    public partial class Form1 : Form
    {
        int obstacle_move_left_distance = 10;
        int bird_jump=0;
        static int score_count = 0, count_jumps=0;
        int bird_distance_from_left = 110, interval=0;
        static Boolean  completed = false, grounded=true;
        static int speed = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
         //   timer2.Start();

        }
        private void moveObstacles() {
            
            obstacle1.Left -= obstacle_move_left_distance+10;
            obstacle2.Left -= obstacle_move_left_distance+10;
            Random rand = new Random();
            
            if (obstacle1.Left <= (0 - obstacle1.Width)) {
                int number = rand.Next(bird_distance_from_left + 200, this.Width);
                obstacle1.Left = number;
                score_count++;
            }
            if (obstacle2.Left <= (0 - obstacle2.Width))
            {
                int number = rand.Next(bird_distance_from_left + 200, this.Width);
                obstacle2.Left = number;
                score_count++;
            }
            
            if (obstacle1.Bounds.IntersectsWith(obstacle2.Bounds)) {
                obstacle2.Left += obstacle1.Width*4;
            }
            
            if (bird.Bounds.IntersectsWith(obstacle1.Bounds) || bird.Bounds.IntersectsWith(obstacle2.Bounds))
            {
                bird.Image = TrexEndless.Properties.Resources.dead;
                timer1.Stop();
                MessageBox.Show("Game Over (:");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score.Text = "Score: " + score_count;
            moveObstacles();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && grounded==true) {
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (interval <= 6 && completed == false/* && bird.Top >= 250*/)
            {
                bird.Top -= 40;
                interval++;
                if (interval == 6)
                {
                    completed = true;
                }
                count_jumps++;
                grounded = false;
            }
            if (interval > 0 && completed)
            {

                bird.Top += 40;
                interval--;
                if (interval == 0)
                {
                    completed = false;
                }
                count_jumps++;
                grounded = false;
            }
            if (count_jumps >= 14)
            {

                timer2.Stop();
                grounded = true;
                count_jumps = 0;
                bird.Top = 389;
                interval = 0;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                //timer1.Tick += Timer1_Tick1; ;
            }
            if (e.KeyCode == Keys.R) {
                
                score.Text = "Score: ";
                obstacle1.Left = 600;
                obstacle2.Left = 750;
                score_count = 0;
                bird.Image = TrexEndless.Properties.Resources.running;

                grounded = true;
                timer1.Start();
            }
        }
        private void Timer1_Tick1(object sender, EventArgs e)
        {
            if (bird.Top <ground.Top)
            {
                bird.Top += 40;
            }
        }
    }
}