using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowlingspelet
{
    public partial class game : Form
    {
        string player1Name, player2Name;
        int player1Score = 0, player2Score = 0;
        bool player1Spare = false, player1Strike = false,
            player2Spare = false, player2Strike = false;

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
            player1SBLbl.Text = player1Name + " Scoreboard";
            player2SBLbl.Text = player2Name + " Scoreboard";
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
    }
}
