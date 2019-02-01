using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bowlingspelet
{
    public partial class game : Form
    {
        string player1Name, player2Name;
        int player1Score = 0, player2Score = 0, roundCounter = 1, beat1 = 0, beat2 = 0;
        bool player1Spare = false, player1Strike = false,
            player2Spare = false, player2Strike = false;

        private void bowlBtn_Click(object sender, EventArgs e)
        {
            switch(roundCounter)
            {
                case 1:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    p1B1R1Lbl.Text = beat1.ToString();
                    p1B2R1Lbl.Text = beat2.ToString();
                    //update scoreboard player 1

                    Thread.Sleep(50);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    p2B1R1Lbl.Text = beat1.ToString();
                    p2B2R1Lbl.Text = beat2.ToString();
                    //update scoreboard player2

                    //roundCounter++;
                    break;
                case 2:

                    roundCounter++;
                    break;
                case 3:

                    roundCounter++;
                    break;
                case 4:

                    roundCounter++;
                    break;
                case 5:

                    roundCounter++;
                    break;
                case 6:

                    roundCounter++;
                    break;
                case 7:

                    roundCounter++;
                    break;
                case 8:

                    roundCounter++;
                    break;
                case 9:

                    roundCounter++;
                    break;
                case 10:
                    break;
            }

        }

        public game()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            mainMenu openMain = new mainMenu();
            this.Close();
            openMain.Show();
            //Takes user back to the main menu
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            gamePnl.Hide();
            //hiding panel
            player1Name = player1NameTxt.Text;
            player2Name = player2NameTxt.Text;
            //setting names into variables
            player1SBLbl.Text = player1Name;
            player2SBLbl.Text = player2Name;
            //setting scoreboard display names
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            mainMenu openMain = new mainMenu();
            this.Close();
            openMain.Show();
            //Takes user back to the main menu
        }

        private void game_Load(object sender, EventArgs e)
        {
            
        }

        private int bowling(int score)
        {
            Random random = new Random();
            score = random.Next(0, (11 - score));
            return score;
        }
    }
}
