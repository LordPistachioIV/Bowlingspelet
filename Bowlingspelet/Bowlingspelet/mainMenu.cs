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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Closes full program
        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            rules Rules = new rules();
            Rules.Show();
            this.Hide();
            //Sends user to Rules form
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            game Game = new game();
            Game.Show();
            this.Hide();
            //Sends user to Game form
        }
    }
}
