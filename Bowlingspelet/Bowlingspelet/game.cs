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

                    Thread.Sleep(50);
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

                    Thread.Sleep(50);
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if(player1Strike == 2)
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
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
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round3ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round2ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round1ScoreLbl.Text = player2Score.ToString();
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round2ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round1ScoreLbl.Text = player2Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round2ScoreLbl.Text = player1Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round4ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round2ScoreLbl.Text = player2Score.ToString();
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round2ScoreLbl.Text = player2Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round3ScoreLbl.Text = player1Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round5ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round3ScoreLbl.Text = player2Score.ToString();
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round3ScoreLbl.Text = player2Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round4ScoreLbl.Text = player1Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round6ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round4ScoreLbl.Text = player2Score.ToString();
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round4ScoreLbl.Text = player2Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round5ScoreLbl.Text = player1Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round7ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round5ScoreLbl.Text = player2Score.ToString();
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round5ScoreLbl.Text = player2Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round6ScoreLbl.Text = player1Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round8ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round6ScoreLbl.Text = player2Score.ToString();
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round6ScoreLbl.Text = player2Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round8ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round7ScoreLbl.Text = player1Score.ToString();
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
                        else if (player1Strike == 1)
                        {
                            player1Score = 10 + beat1 + beat2 + player1Score;
                            p1Round8ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        else if (player1Strike == 2)
                        {
                            player1Score = (10 + 10 + beat1 + player1Score);
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Strike--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round9ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round8ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
                        {
                            player2Score = (10 + 10 + beat1 + player2Score);
                            p2Round7ScoreLbl.Text = player2Score.ToString();
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
                        else if (player2Strike == 1)
                        {
                            player2Score = 10 + beat1 + beat2 + player2Score;
                            p2Round8ScoreLbl.Text = player2Score.ToString();
                            player2Strike--;
                        }
                        else if (player2Strike == 2)
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
                    do
                    {
                        switch(loopCounter)
                        {
                            case 1://first beat
                                beat1 = bowling(0);
                                if(beat1 == 10)//if first beat is strike
                                {
                                    p1B1R10Lbl.Text = "X";
                                    if(player1Spare > 0)
                                    {
                                        p1Round9ScoreLbl.Text = (10 + beat1 + player1Score).ToString();
                                        player1Spare--;
                                    }
                                    player1Strike++;
                                }
                                else
                                {
                                    p1B1R10Lbl.Text = beat1.ToString();
                                    if(player1Spare > 0)
                                    {
                                        p1Round9ScoreLbl.Text = (10 + beat1 + player1Score).ToString();
                                        player1Spare--;
                                    }
                                }
                                loopCounter++;
                                break;

                            case 2://second beat
                                if(beat1 == 10)
                                {
                                    beat2 = bowling(0);
                                    if(beat2 == 10)
                                    {
                                        p1B2R10Lbl.Text = "X";
                                        //run checks for previous strikes
                                        player1Strike++;
                                    }
                                    else
                                    {
                                        p1B2R10Lbl.Text = beat2.ToString();
                                    }
                                }
                                else
                                {
                                    beat2 = bowling(beat1);
                                    if (beat1 + beat2 == 10)
                                    {
                                        p1B2R10Lbl.Text = "/";
                                        player1Spare++;
                                    }
                                }
                                loopCounter++;
                                break;

                            case 3://third beat, only to be used if case 1 is a strike or case 2 is a spare
                                if((player1Spare > 0) || (player1Strike >= 1))
                                {
                                    //run third beat code
                                }
                                else
                                {
                                    loopCounter++;
                                }
                                break;
                        }
                    } while (loopCounter != 4);
                    //beat1 = bowling(0);
                    //if(beat1 == 10)
                    //{
                    //    p1B1R10Lbl.Text = "X";
                    //}
                    //else
                    //{
                    //    beat2 = bowling(beat1);
                    //    if (beat1 + beat2 == 10)
                    //    {
                    //        p1B1R10Lbl.Text = beat1.ToString();
                    //        p1B2R10Lbl.Text = "/";
                    //    }
                    //    else
                    //    {
                    //        p1B1R10Lbl.Text = beat1.ToString();
                    //        p1B2R10Lbl.Text = beat2.ToString();
                    //        p1Round10ScoreLbl.Text = (beat1 + beat2 + player1Score).ToString();
                    //    }
                    //}

                    //Thread.Sleep(50);

                    //beat1 = bowling(0);
                    //if (beat1 == 10)
                    //{
                    //    p2B1R10Lbl.Text = "X";
                    //    if(player2Spare > 0)
                    //    {
                    //        p2Round9ScoreLbl.Text = (10 + beat1 + player2Score).ToString();
                    //    }
                    //}
                    //else
                    //{
                    //    beat2 = bowling(beat1);
                    //    if (beat1 + beat2 == 10)
                    //    {
                    //        p2B1R10Lbl.Text = beat1.ToString();
                    //        p2B2R10Lbl.Text = "/";
                    //        beat3 = bowling(0);
                    //        p2Round10ScoreLbl.Text = (10 + beat3 + player2Score).ToString();
                    //    }
                    //    else
                    //    {
                    //        p2B1R10Lbl.Text = beat1.ToString();
                    //        p2B2R10Lbl.Text = beat2.ToString();
                    //        p2Round10ScoreLbl.Text = (beat1 + beat2 + player2Score).ToString();
                    //    }
                    //}
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
