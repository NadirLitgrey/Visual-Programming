using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_Tac_Toe
{
    public partial class Form1 : Form
    {
        public TicTacToe obj = new TicTacToe();
        public Form1()
        {
            InitializeComponent();
        }
        static int btnNumber=0;
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (obj.getTogglevalue())
            {

                btnOne.Text = obj.getUserOne();
                obj.setToggleValue(false);
            }
            else
            {
                btnOne.Text = obj.getUserTwo();
                obj.setToggleValue(true);
            }
            btnOne.Enabled = false;
            checkForWinner();
            btnNumber++;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (obj.getTogglevalue())
            {

                btnTwo.Text = obj.getUserOne();
                obj.setToggleValue(false);
            }
            else
            {
                btnTwo.Text = obj.getUserTwo();
                obj.setToggleValue(true);
            }
            btnTwo.Enabled = false;
            checkForWinner();
            btnNumber++;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (obj.getTogglevalue())
            {

                btnThree.Text = obj.getUserOne();
                obj.setToggleValue(false);
            }
            else
            {
                btnThree.Text = obj.getUserTwo();
                obj.setToggleValue(true);
            }
            btnThree.Enabled = false;
            checkForWinner();
            btnNumber++;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {

            if (obj.getTogglevalue())
            {

                btnFour.Text = obj.getUserOne();
                obj.setToggleValue(false);
            }
            else
            {
                btnFour.Text = obj.getUserTwo();
                obj.setToggleValue(true);
            }
            btnFour.Enabled = false;
            checkForWinner();
            btnNumber++;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {

            if (obj.getTogglevalue())
            {


                BtnFive.Text = obj.getUserOne();
                obj.setToggleValue(false);
            }
            else
            {
                BtnFive.Text = obj.getUserTwo();
                obj.setToggleValue(true);
            }
            BtnFive.Enabled = false;
            checkForWinner();
            btnNumber++;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {

            if (obj.getTogglevalue())
            {

                BtnSix.Text = obj.getUserOne();
                obj.setToggleValue(false);
            }
            else
            {
                BtnSix.Text = obj.getUserTwo();
                obj.setToggleValue(true);
            }
            BtnSix.Enabled = false;
            checkForWinner();
            btnNumber++;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {

            if (obj.getTogglevalue())
            {

                btnSeven.Text = obj.getUserOne();
                obj.setToggleValue(false);
            }
            else
            {
                btnSeven.Text = obj.getUserTwo();
                obj.setToggleValue(true);
            }
            btnSeven.Enabled = false;
            checkForWinner();
            btnNumber++;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {

            if (obj.getTogglevalue())
            {

                btnEight.Text = obj.getUserOne();
                obj.setToggleValue(false);
            }
            else
            {
                btnEight.Text = obj.getUserTwo();
                obj.setToggleValue(true);
            }
            btnEight.Enabled = false;
            checkForWinner();
            btnNumber++;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {

            if (obj.getTogglevalue())
            {

                btnNine.Text = obj.getUserOne();
                obj.setToggleValue(false);
            }
            else
            {
                btnNine.Text = obj.getUserTwo();
                obj.setToggleValue(true);
            }
            btnNine.Enabled = false;
            checkForWinner();
            btnNumber++;
        }
        public void checkForWinner()
        {
            String[,] box ={
                                                {btnOne.Text,btnTwo.Text, btnThree.Text},
                                                {btnFour.Text, BtnFive.Text, BtnSix.Text},
                                                {btnSeven.Text, btnEight.Text, btnNine.Text}
                                            };

            Boolean won_X = false, won_O = false; ;
            for (int row = 0; row < 3; row++) {

                for (int column = 0; column < 3; column++) {
                    if (box[row, column] == "X")
                    {
                        won_X = checkForX(box, row, column);
                        
                    }
                    else if(box[row,column]=="O"){

                        won_O = checkColumnWiseFor_O(box, row, column);
                    }
                }
            }
            if (won_X)
            {
                MessageBox.Show("Hurrah X Won!\nCongratulations To the winner");
                lblInfo.Text = "X Won";
                DisableAll();
            }
            if (won_O)
            {
                MessageBox.Show("Hurrah O Won!\nCongratulations To the winner");
                lblInfo.Text = "O Won";
                DisableAll();
            }
            else if(btnNumber>=8){
                    MessageBox.Show("Very Close Contest.. Try again!");
                    lblInfo.Text = "Match Tied";
                    DisableAll();
            } 
        }
        public static Boolean checkForX(String[,] box,int row, int col){

            int count1 = 0, count2 = 0, count3=0, count4=0;
            int k = 0, l=2;
            for (int j = 0; j < 3; j++)
            {
                if (box[row, j] == "X")
                {
                    count1++;
                }
                if (box[j, col] == "X")
                {
                    count2++;
                }
                if (k==j && box[j, k] == "X") {
                    k++;
                    count3++;
                }
                if (l+j==2 && box[j, l] == "X")
                {
                    l -= 1;
                    count4++;
                }

            }
            if (count1 == 3 || count2==3 || count3==3 || count4==3) {
                return true;
            }
            return false;
        }
        public static Boolean checkColumnWiseFor_O(String[,] box, int row, int col)
        {

            int count1 = 0, count2 = 0, count3=0, count4=0, k=0, l=2;

            for (int j = 0; j < 3; j++)
            {
                if (box[row, j] == "O")
                {
                    count1++;
                }
                if (box[j, col] == "O")
                {
                    count2++;
                }
                if (k == j && box[j, k] == "O")
                {
                    k++;
                    count3++;
                }
                if (l + j == 2 && box[j, l] == "O")
                {
                    l -= 1;
                    count4++;
                }

            }
            if (count1 == 3 || count2 == 3 || count3 == 3 || count4 == 3)
            {
                return true;
            }
            return false;
        }
        public void DisableAll() {

            btnNine.Enabled = false;
            btnEight.Enabled = false;
            btnSeven.Enabled = false;
            BtnSix.Enabled = false;
            BtnFive.Enabled = false;
            btnFour.Enabled = false;
            btnThree.Enabled = false;
            btnTwo.Enabled = false;
            btnOne.Enabled = false;
            
        }
        public void EnableAll() {


            btnNine.Text = "";
            btnEight.Text = "";
            btnSeven.Text = "";
            BtnSix.Text = "";
            BtnFive.Text = "";
            btnFour.Text = "";
            btnThree.Text = "";
            btnTwo.Text = "";
            btnOne.Text = "";

            btnNine.Enabled = true;
            btnEight.Enabled = true;
            btnSeven.Enabled = true;
            BtnSix.Enabled = true;
            BtnFive.Enabled = true;
            btnFour.Enabled = true;
            btnThree.Enabled = true;
            btnTwo.Enabled = true;
            btnOne.Enabled = true;

            btnNumber = 0;
        }
        private void btnAgain_Click(object sender, EventArgs e)
        {
            EnableAll();
        }
    }
}