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
    public partial class rules : Form
    {
        /*
         * Display is as shown:
         * RULES OF BOWLING
         * A game of bowling consists of ten rounds. In each round, the bowler will have two chances to knock down as many pins as possible
         * with their bowling ball. In this game you will be one player vs another, both will be done when the "Bowl" button is clicked. 
         * 
         * If a bowler is able to knock down all ten pins with their first ball, they are awarded a strike (X). If the bowler is able to knock down
         * all 10 pins with the two balls it is known as a spare (/). Bonus points are awarded for both of these, depending on what is scored in the
         * next 2 balls (for a strike) or 1 ball (for a spare). If the bowler knocks down all 10 pins in the tenth round, the bowler is allowed 
         * to throw 3 balls for that round. This allows for a potential of 12 strikes in a single game, and a maximum score of 300 points!
         * A perfect game.
         * 
         * SCORING EXAMPLE                           Two strikes in a row example:       Spare example:
         * Strike example:                           Round 1, ball 1: 10 pins (strike)   Round 1, ball 1: 7 pins
         * Round 1, ball 1: 10 pins (strike)         Round 2, ball 1: 10 pins (strike)   Round 1, ball 2: 3 pins (spare)
         * Round 2, ball 1: 3 pins                   Round 3, ball 1: 4 pins             Round 2, ball 1: 4 pins
         * Round 2, ball 2: 6 pins                   Round 3, ball 2: 2 pins             Round 2, ball 2: 2 pins
         * 
         * The total score from these throws is:     The score from these throws are:    The total score from these throws is:
         * Round one: 10 + (3 + 6) = 19              Round one: 10 + (10 + 4) = 24       Round one: 7 + 3 + 4 (bonus) = 14
         * Round two: 3 + 6 = 9                      Round two: 10 + (4 + 2) = 16        Round two: 4 + 2 = 6
         * TOTAL = 28                                Round three: 4 + 2 = 6              TOTAL = 20
         *                                           TOTAL = 46
         */

        public rules()
        {
            InitializeComponent();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            mainMenu openMain = new mainMenu();
            this.Close();
            openMain.Show();
            //Sends user back to the main menu
        }
    }
}
