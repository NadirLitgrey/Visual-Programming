using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class AppLauncher : Form
    {
        public static Tic_Tac_Toe_Form ticTacToeControl;
        public static HomeControl homeControl;
        public static TwoPlayerGame twoPlayerControl;
        public static Pc_Tic_Tac_Toe pc_ticTacToeControl;
        public AppLauncher()
        {
            InitializeComponent();

            ticTacToeControl = tic_Tac_Toe_Form1;
            homeControl = homeControl1;
            twoPlayerControl = twoPlayerGame1;
            pc_ticTacToeControl = pc_Tic_Tac_Toe1;
        }

        private void shutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void twoPlayerGame_Click(object sender, EventArgs e)
        {

            //When started twoPlayer mode: make sure all field are empty
            erasePreviousDataOfTwoPlayer();
            
            twoPlayerControl.BringToFront();
            homeControl.SendToBack();
            ticTacToeControl.SendToBack();
            pc_ticTacToeControl.SendToBack();
        }

        private void pcGame_Click(object sender, EventArgs e)
        {
            erasePreviousDataPcGame();

            twoPlayerControl.SendToBack();
            homeControl.SendToBack();
            ticTacToeControl.SendToBack();
            pc_ticTacToeControl.BringToFront();
        }

        private void onlineGame_Click(object sender, EventArgs e)
        {
            twoPlayerControl.SendToBack();
            homeControl.BringToFront();
            ticTacToeControl.SendToBack();
            pc_ticTacToeControl.SendToBack();
        }

        private void AppLauncher_Load(object sender, EventArgs e)
        {
            homeControl.BringToFront();
        }
        public static void erasePreviousDataOfTwoPlayer() {
            TwoPlayerGame.player1.Text = "";
            TwoPlayerGame.player2.Text = "";
            Tic_Tac_Toe_Form.restartTheGame(Tic_Tac_Toe_Form.ticTacToeForm);

        }
        public static void erasePreviousDataPcGame()
        {
            
            Pc_Tic_Tac_Toe.restartTheGame(Pc_Tic_Tac_Toe.pc_Tic_Tac_Toe);

        }

    }
}
