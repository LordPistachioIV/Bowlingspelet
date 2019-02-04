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
        int player1Score = 0, player2Score = 0, roundCounter = 1, beat1 = 0, beat2 = 0,
            beat3 = 0, player1Spare=0, player1Strike=0, player2Spare=0, player2Strike=0,
            loopCounter = 1;
        /*
         * RUN DOWN OF VARIABLES AND USAGE
         * string player1Name & player2Name | Used to retain the name of player 1 & 2 respectively
         * int player1Score & player2Score | Used to retain the total score of player 1 and 2 respectively
         * int roundCounter | Used to keep track of the round through out the game
         * int beat1 & beat2 & beat3 | Used to retain the score of each beat for each round (beat 3  only used in round 10)
         * int player1Spare & player2Spare | Used to retain if either player 1 or 2 (respectively) have achieved a spare
         * int player1Strike & player2Strike | Used to retain if either player 1 or 2 (respectively) have achieved a strike
         * int loopCounter | Used to retain the amount of times the do while loop has gone in round 10.
         */

        private void bowlBtn_Click(object sender, EventArgs e)
        {
            switch(roundCounter)
            {
                case 1:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 1

                    if (beat1 == 10)
                    {
                        p1B1R1Lbl.Text = "X";
                        player1Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p1B1R1Lbl.Text = beat1.ToString();
                        p1B2R1Lbl.Text = "/";
                        player1Spare++;
                    }
                    else
                    {
                        p1B1R1Lbl.Text = beat1.ToString();
                        p1B2R1Lbl.Text = beat2.ToString();
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round1ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(100);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 2

                    if (beat1 == 10)
                    {
                        p2B1R1Lbl.Text = "X";
                        player2Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p2B1R1Lbl.Text = beat1.ToString();
                        p2B2R1Lbl.Text = "/";
                        player2Spare++;
                    }
                    else
                    {
                        p2B1R1Lbl.Text = beat1.ToString();
                        p2B2R1Lbl.Text = beat2.ToString();
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round1ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 2:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 1

                    if (beat1 == 10)
                    {
                        p1B1R2Lbl.Text = "X";
                        if(player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round1ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        //if (player1Strike > 1)
                        /* 
                         * No check for strike here as if there are 2 strikes in a row
                         * then nothing will be done as only 2 scores have been taken
                         */
                        player1Strike++;
                        //Increase strike counter by 1 as a strike has been achieved.
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p1B1R2Lbl.Text = beat1.ToString();
                        p1B2R2Lbl.Text = "/";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round1ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                            /*
                             * If spare is active take the score of 10 from previous round
                             * Add on the score from the first beat in the current round
                             * Set total as score for previous round.
                             * Reduce spare counter by 1.
                             */
                        }
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round1ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                            /*
                             * If strike is active by 1 take the score of 10 from previous round
                             * Add on the two scores from the current round 
                             * Set total as score for previous round.
                             * Reduce strike counter by 1.
                             */
                        }
                        player1Spare++;
                        //Increase p1 spare counter by one as a spare has been achieved
                    }
                    else
                    {
                        p1B1R2Lbl.Text = beat1.ToString();
                        p1B2R2Lbl.Text = beat2.ToString();
                        //randomly generating the beats for player 1

                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round1ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                            /*
                             * If spare is active take the score of 10 from previous round
                             * Add on the score from the first beat in the current round
                             * Set total as score for previous round.
                             * Reduce spare counter by 1.
                             */
                        }
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round1ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                            /*
                             * If strike is active by 1 take the score of 10 from previous round
                             * Add on the two scores from the current round 
                             * Set total as score for previous round.
                             * Reduce strike counter by 1.
                             */
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round2ScoreLbl.Text = player1Score.ToString();
                        //Set score for this round.
                    }
                    //update scoreboard player 1

                    Thread.Sleep(100);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 2

                    if (beat1 == 10)
                    {
                        p2B1R2Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round1ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        player2Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p2B1R2Lbl.Text = beat1.ToString();
                        p2B2R2Lbl.Text = "/";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round1ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                            /*
                             * If spare is active take the score of 10 from previous round
                             * Add on the score from the first beat in the current round
                             * Set total as score for previous round.
                             * Reduce spare counter by 1.
                             */
                        }
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round1ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                            /*
                             * If strike is active by 1 take the score of 10 from previous round
                             * Add on the two scores from the current round 
                             * Set total as score for previous round.
                             * Reduce strike counter by 1.
                             */
                        }
                        player2Spare++;
                    }
                    else
                    {
                        p2B1R2Lbl.Text = beat1.ToString();
                        p2B2R2Lbl.Text = beat2.ToString();
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round1ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                            /*
                             * If spare is active take the score of 10 from previous round
                             * Add on the score from the first beat in the current round
                             * Set total as score for previous round.
                             * Reduce spare counter by 1.
                             */
                        }
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round1ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                            /*
                             * If strike is active by 1 take the score of 10 from previous round
                             * Add on the two scores from the current round 
                             * Set total as score for previous round.
                             * Reduce strike counter by 1.
                             */
                        }
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round2ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 3:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 1

                    if (beat1 == 10)
                    {
                        p1B1R3Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        //No need for a if(player1Strike == 1) as with two strikes in a row nothing happens
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round1ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                            /*
                             * If the player gets 3 strikes in a row then the strike counter
                             * will be at 2, meaning the score for round 1 will be 10+10+10 = 30
                             * This is changing round 1s score and removing 1 from the strike counter
                             * This will be incremented up to round 9
                             * There is no use for this code in rounds 1&2.
                             */
                        }
                        player1Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p1B1R3Lbl.Text = beat1.ToString();
                        p1B2R3Lbl.Text = "/";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round1ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                            /*
                             * If the player gets 2 strikes then a spare then the strike counter
                             * will be at 2, meaning the score for round 1 will be 10+10+beat = X
                             * This is changing round 1s score and removing 1 from the strike counter
                             * This will be incremented up to round 9
                             * There is no use for this code in rounds 1&2.
                             */
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        /*
                         * Format has to go: Check for 2 strikes, seperate if statement check for 1 strike 
                         * Otherwise the single strike will be left behind and not filled.
                         */
                        player1Spare++;
                    }
                    else
                    {
                        p1B1R3Lbl.Text = beat1.ToString();
                        p1B2R3Lbl.Text = beat2.ToString();
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round1ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                            /*
                             * If the player gets 2 strikes but not a spare or strike then the
                             * strike counter will be at 2, meaning the score for round 1 will be
                             * 10+10+beat1 = X
                             * This is changing round 1s score and removing 1 from the strike counter
                             * This will be incremented up to round 9
                             * There is no use for this code in rounds 1&2.
                             */
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        /*
                         * Format has to go: Check for 2 strikes, seperate if statement check for 1 strike 
                         * Otherwise the single strike will be left behind and not filled.
                         */
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round3ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(100);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 2

                    if (beat1 == 10)
                    {
                        p2B1R3Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round2ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round1ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p2B1R3Lbl.Text = beat1.ToString();
                        p2B2R3Lbl.Text = "/";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round2ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round1ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round2ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Spare++;
                    }
                    else
                    {
                        p2B1R3Lbl.Text = beat1.ToString();
                        p2B2R3Lbl.Text = beat2.ToString();
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round2ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round1ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round2ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round3ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 4:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 1

                    if (beat1 == 10)
                    {
                        p1B1R4Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p1B1R4Lbl.Text = beat1.ToString();
                        p1B2R4Lbl.Text = "/";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Spare++;
                    }
                    else
                    {
                        p1B1R4Lbl.Text = beat1.ToString();
                        p1B2R4Lbl.Text = beat2.ToString();
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round4ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(100);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 2

                    if (beat1 == 10)
                    {
                        p2B1R4Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round2ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p2B1R4Lbl.Text = beat1.ToString();
                        p2B2R4Lbl.Text = "/";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round2ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Spare++;
                    }
                    else
                    {
                        p2B1R4Lbl.Text = beat1.ToString();
                        p2B2R4Lbl.Text = beat2.ToString();
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round2ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round4ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 5:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 1

                    if (beat1 == 10)
                    {
                        p1B1R5Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p1B1R5Lbl.Text = beat1.ToString();
                        p1B2R5Lbl.Text = "/";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Spare++;
                    }
                    else
                    {
                        p1B1R5Lbl.Text = beat1.ToString();
                        p1B2R5Lbl.Text = beat2.ToString();
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round5ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(100);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 2

                    if (beat1 == 10)
                    {
                        p2B1R5Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p2B1R5Lbl.Text = beat1.ToString();
                        p2B2R5Lbl.Text = "/";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Spare++;
                    }
                    else
                    {
                        p2B1R5Lbl.Text = beat1.ToString();
                        p2B2R5Lbl.Text = beat2.ToString();
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round5ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 6:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 1

                    if (beat1 == 10)
                    {
                        p1B1R6Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Strike++;

                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p1B1R6Lbl.Text = beat1.ToString();
                        p1B2R6Lbl.Text = "/";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Spare++;
                    }
                    else
                    {
                        p1B1R6Lbl.Text = beat1.ToString();
                        p1B2R6Lbl.Text = beat2.ToString();
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round6ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(100);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 2

                    if (beat1 == 10)
                    {
                        p2B1R6Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p2B1R6Lbl.Text = beat1.ToString();
                        p2B2R6Lbl.Text = "/";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Spare++;
                    }
                    else
                    {
                        p2B1R6Lbl.Text = beat1.ToString();
                        p2B2R6Lbl.Text = beat2.ToString();
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round6ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 7:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 1

                    if (beat1 == 10)
                    {
                        p1B1R7Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p1B1R7Lbl.Text = beat1.ToString();
                        p1B2R7Lbl.Text = "/";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Spare++;
                    }
                    else
                    {
                        p1B1R7Lbl.Text = beat1.ToString();
                        p1B2R7Lbl.Text = beat2.ToString();
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round7ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(100);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 2

                    if (beat1 == 10)
                    {
                        p2B1R7Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p2B1R7Lbl.Text = beat1.ToString();
                        p2B2R7Lbl.Text = "/";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Spare++;
                    }
                    else
                    {
                        p2B1R7Lbl.Text = beat1.ToString();
                        p2B2R7Lbl.Text = beat2.ToString();
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round7ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 8:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 1

                    if (beat1 == 10)
                    {
                        p1B1R8Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p1B1R8Lbl.Text = beat1.ToString();
                        p1B2R8Lbl.Text = "/";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Spare++;
                    }
                    else
                    {
                        p1B1R8Lbl.Text = beat1.ToString();
                        p1B2R8Lbl.Text = beat2.ToString();
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round8ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(100);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 2

                    if (beat1 == 10)
                    {
                        p2B1R8Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p2B1R8Lbl.Text = beat1.ToString();
                        p2B2R8Lbl.Text = "/";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Spare++;
                    }
                    else
                    {
                        p2B1R8Lbl.Text = beat1.ToString();
                        p2B2R8Lbl.Text = beat2.ToString();
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round8ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 9:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 1

                    if (beat1 == 10)
                    {
                        p1B1R9Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round8ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p1B1R9Lbl.Text = beat1.ToString();
                        p1B2R9Lbl.Text = "/";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round8ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round8ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Spare++;
                    }
                    else
                    {
                        p1B1R9Lbl.Text = beat1.ToString();
                        p1B2R9Lbl.Text = beat2.ToString();
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round8ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round8ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round9ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(100);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);
                    //randomly generating the beats for player 2

                    if (beat1 == 10)
                    {
                        p2B1R9Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round8ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p2B1R9Lbl.Text = beat1.ToString();
                        p2B2R9Lbl.Text = "/";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round8ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round8ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Spare++;
                    }
                    else
                    {
                        p2B1R9Lbl.Text = beat1.ToString();
                        p2B2R9Lbl.Text = beat2.ToString();
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round8ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round8ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round9ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 10:
                    do//player1 do while
                    {
                        switch(loopCounter)
                        {
                            case 1://first beat
                                beat1 = bowling(0);
                                if(beat1 == 10)//if first beat is strike
                                {
                                    p1B1R10Lbl.Text = "X";
                                    if (player1Spare > 0)
                                    {
                                        player1Score = 10 + beat1 + player1Score;
                                        p1Round9ScoreLbl.Text = player1Score.ToString();
                                        player1Spare--;
                                    }
                                    else if (player1Strike == 2)
                                    {
                                        player1Score = (10 + 10 + beat1 + player1Score);
                                        p1Round8ScoreLbl.Text = player1Score.ToString();
                                        player1Strike--;
                                    }
                                    player1Strike++;
                                }
                                else//if not a strike
                                {
                                    p1B1R10Lbl.Text = beat1.ToString();
                                    if(player1Spare > 0)
                                    {
                                        player1Score = 10 + beat1 + player1Score;
                                        p1Round9ScoreLbl.Text = player1Score.ToString();
                                        player1Spare--;
                                    }
                                    else if (player1Strike == 2)
                                    {
                                        player1Score = (10 + 10 + beat1 + player1Score);
                                        p1Round8ScoreLbl.Text = player1Score.ToString();
                                        player1Strike--;
                                    }
                                }
                                loopCounter++;
                                break;

                            case 2://second beat
                                if(beat1 == 10)//if first beat is a strike
                                {
                                    beat2 = bowling(0);//new set of 10 pins
                                    if(beat2 == 10)//if second beat is a strike
                                    {
                                        p1B2R10Lbl.Text = "X";
                                        if (player1Strike == 2)
                                        {
                                            player1Score = (10 + 10 + beat1 + player1Score);
                                            p1Round9ScoreLbl.Text = player1Score.ToString();
                                            player1Strike--;
                                        }
                                        player1Strike++;
                                    }
                                    else
                                    {
                                        p1B2R10Lbl.Text = beat2.ToString();
                                    }
                                }
                                else//of not a strike
                                {
                                    beat2 = bowling(beat1);
                                    if (beat1 + beat2 == 10)//if beat 1&2 is a spare
                                    {
                                        p1B2R10Lbl.Text = "/";
                                        if (player1Strike == 1)
                                        {
                                            player1Score = (10 + beat1 + beat2 + player1Score);
                                            p1Round9ScoreLbl.Text = player1Score.ToString();
                                            player1Strike--;
                                        }
                                        player1Spare++;
                                    }
                                    else//not a spare
                                    {
                                        p1B2R10Lbl.Text = beat2.ToString();
                                        if(player1Strike == 1)
                                        {
                                            player1Score = (10 + beat1 + beat2 + player1Score);
                                            p1Round9ScoreLbl.Text = player1Score.ToString();
                                            player1Strike--;
                                        }
                                        player1Score = beat1 + beat2 + player1Score;
                                        p1Round10ScoreLbl.Text = player1Score.ToString();
                                    }
                                }
                                loopCounter++;
                                break;

                            case 3://third beat, only to be used if case 1 is a strike or case 2 is a spare
                                if((player1Spare > 0) || (player1Strike >= 1))
                                {
                                    if(player1Strike == 2)//if beat 1&2 is a strike
                                    {
                                        beat3 = bowling(0);
                                        if(beat3 == 10)
                                        {
                                            p1B3R10Lbl.Text = "X";
                                        }
                                        else
                                        {
                                            p1B3R10Lbl.Text = beat3.ToString();
                                        }
                                        player1Score = 10 + 10 + beat1 + player1Score;
                                        p1Round10ScoreLbl.Text = player1Score.ToString();
                                        //This code covers the final beat being a strike or not
                                    }
                                    else if(player1Strike == 1)
                                    {
                                        beat3 = bowling(beat2);
                                        if (beat2 + beat3 == 10)
                                        {
                                            p1B3R10Lbl.Text = "/";
                                        }
                                        else
                                        {
                                            p1B3R10Lbl.Text = beat3.ToString();
                                        }
                                        player1Score = 10 + beat2 + beat3 + player1Score;
                                        p1Round10ScoreLbl.Text = player1Score.ToString();
                                        //this code covers the first beat being a strike and the second two being a spare or not
                                    }
                                    else if(player1Spare >0)
                                    {
                                        beat3 = bowling(0);
                                        if (beat3 == 10)
                                        {
                                            p1B3R10Lbl.Text = "X";
                                        }
                                        else
                                        {
                                            p1B3R10Lbl.Text = beat3.ToString();
                                        }
                                        player1Score = 10 + beat3 + player1Score;
                                        p1Round10ScoreLbl.Text = player1Score.ToString();
                                        //this code covers the first two beats being a spare. 
                                    }
                                    loopCounter++;
                                }
                                else
                                {
                                    //if no spare or strike has been achived in round 10 then no extra beat.
                                    loopCounter++;
                                }
                                break;
                        }
                    } while (loopCounter != 4);
                    loopCounter = 1;
                    Thread.Sleep(100);
                    do//player2 do while
                    {
                        switch (loopCounter)
                        {
                            case 1://first beat
                                beat1 = bowling(0);
                                if (beat1 == 10)//if first beat is strike
                                {
                                    p2B1R10Lbl.Text = "X";
                                    if (player2Spare > 0)
                                    {
                                        player2Score = 10 + beat1 + player2Score;
                                        p2Round9ScoreLbl.Text = player2Score.ToString();
                                        player1Spare--;
                                    }
                                    else if (player2Strike == 2)
                                    {
                                        player2Score = (10 + 10 + beat1 + player2Score);
                                        p2Round8ScoreLbl.Text = player2Score.ToString();
                                        player2Strike--;
                                    }
                                    player2Strike++;
                                }
                                else
                                {
                                    p2B1R10Lbl.Text = beat1.ToString();
                                    if (player2Spare > 0)
                                    {
                                        player2Score = 10 + beat1 + player2Score;
                                        p2Round9ScoreLbl.Text = player2Score.ToString();
                                        player2Spare--;
                                    }
                                    else if (player2Strike == 2)
                                    {
                                        player2Score = (10 + 10 + beat1 + player2Score);
                                        p2Round8ScoreLbl.Text = player2Score.ToString();
                                        player2Strike--;
                                    }
                                }
                                loopCounter++;
                                break;

                            case 2://second beat
                                if (beat1 == 10)
                                {
                                    beat2 = bowling(0);
                                    if (beat2 == 10)
                                    {
                                        p2B2R10Lbl.Text = "X";
                                        if (player2Strike == 2)
                                        {
                                            player2Score = (10 + 10 + beat1 + player2Score);
                                            p2Round9ScoreLbl.Text = player2Score.ToString();
                                            player2Strike--;
                                        }
                                        player2Strike++;
                                    }
                                    else
                                    {
                                        p2B2R10Lbl.Text = beat2.ToString();
                                    }
                                }
                                else
                                {
                                    beat2 = bowling(beat1);
                                    if (beat1 + beat2 == 10)
                                    {
                                        p2B2R10Lbl.Text = "/";
                                        if (player2Strike == 1)
                                        {
                                            player2Score = (10 + beat1 + beat2 + player2Score);
                                            p2Round9ScoreLbl.Text = player2Score.ToString();
                                            player2Strike--;
                                        }
                                        player2Spare++;
                                    }
                                    else
                                    {
                                        p2B2R10Lbl.Text = beat2.ToString();
                                        if (player2Strike == 1)
                                        {
                                            player2Score = (10 + beat1 + beat2 + player2Score);
                                            p2Round9ScoreLbl.Text = player2Score.ToString();
                                            player2Strike--;
                                        }
                                        player2Score = beat1 + beat2 + player2Score;
                                        p2Round10ScoreLbl.Text = player2Score.ToString();
                                    }
                                }
                                loopCounter++;
                                break;

                            case 3://third beat, only to be used if case 1 is a strike or case 2 is a spare
                                if ((player2Spare > 0) || (player2Strike >= 1))
                                {
                                    //run third beat code
                                    if (player2Strike == 2)
                                    {
                                        beat3 = bowling(0);
                                        if (beat3 == 10)
                                        {
                                            p2B3R10Lbl.Text = "X";
                                        }
                                        else
                                        {
                                            p2B3R10Lbl.Text = beat3.ToString();
                                        }
                                        player2Score = 10 + 10 + beat1 + player2Score;
                                        p2Round10ScoreLbl.Text = player2Score.ToString();
                                    }
                                    else if (player2Strike == 1)
                                    {
                                        beat3 = bowling(beat2);
                                        if (beat2 + beat3 == 10)
                                        {
                                            p2B3R10Lbl.Text = "/";
                                        }
                                        else
                                        {
                                            p2B3R10Lbl.Text = beat3.ToString();
                                        }
                                        player2Score = 10 + beat2 + beat3 + player2Score;
                                        p2Round10ScoreLbl.Text = player2Score.ToString();
                                    }
                                    else if (player2Spare > 0)
                                    {
                                        beat3 = bowling(0);
                                        if (beat3 == 10)
                                        {
                                            p2B3R10Lbl.Text = "X";
                                        }
                                        else
                                        {
                                            p2B3R10Lbl.Text = beat3.ToString();
                                        }
                                        player2Score = 10 + beat3 + player2Score;
                                        p2Round10ScoreLbl.Text = player2Score.ToString();
                                    }
                                    loopCounter++;
                                }
                                else
                                {
                                    loopCounter++;
                                }
                                break;
                        }
                    } while (loopCounter != 4);

                    //WIN CONDITION
                    if(player1Score > player2Score)
                    {
                        winCondition(player1Score, player2Score, player1Name);
                    }
                    else if (player2Score > player1Score)
                    {
                        winCondition(player2Score, player1Score, player2Name);
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show("Its a tie! Well played " + player1Name + " and " + player2Name + "!",
                            "Its a tie!", buttons);
                        if (result == DialogResult.OK)
                        {
                            mainMenu openMain = new mainMenu();
                            this.Close();
                            openMain.Show();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            roundCounter++;
                        }
                    }
                    break;

                case 11:
                    //if the player presses cancel it will loop through this area so no changes to score can happen
                    if (player1Score > player2Score)
                    {
                        winCondition(player1Score, player2Score, player1Name);
                    }
                    else if (player2Score > player1Score)
                    {
                        winCondition(player2Score, player1Score, player2Name);
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show("Its a tie! Well played " + player1Name + " and " + player2Name + "!",
                            "Its a tie!", buttons);
                        if (result == DialogResult.OK)
                        {
                            mainMenu openMain = new mainMenu();
                            this.Close();
                            openMain.Show();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            roundCounter++;
                        }
                    }
                    roundCounter--;
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
            Random random = new Random();//create random
            score = random.Next(0, (11 - score));//generate a number between 1 - (10 - previous score)
            return score;//return score
        }

        private void winCondition(int higher, int lower, string winner)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Congratulations " + winner + " you won by " + (higher - lower) + " points.",
                winner + " won!", buttons);
            if (result == DialogResult.OK)
            {
                mainMenu openMain = new mainMenu();
                this.Close();
                openMain.Show();
            }
            else if (result == DialogResult.Cancel)
            {
                roundCounter++;
            }
        }
    }
}