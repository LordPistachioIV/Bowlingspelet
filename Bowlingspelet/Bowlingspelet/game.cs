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
            player1Spare=0, player1Strike=0, player2Spare=0, player2Strike=0;

        private void bowlBtn_Click(object sender, EventArgs e)
        {
            switch(roundCounter)
            {
                case 1:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

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

                    if (beat1 == 10)
                    {
                        p1B1R2Lbl.Text = "X";
                        if(player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round1ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        player1Strike++;
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
                        }
                        player1Spare++;
                    }
                    else
                    {
                        p1B1R2Lbl.Text = beat1.ToString();
                        p1B2R2Lbl.Text = beat2.ToString();
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round1ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round2ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

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

                    if (beat1 == 10)
                    {
                        p1B1R3Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round2ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
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
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round3ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p2B1R3Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
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
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round3ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 4:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p1B1R4Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round3ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
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
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round4ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p2B1R4Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round3ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
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
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round4ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 5:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p1B1R5Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round4ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
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
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round5ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p2B1R5Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round4ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
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
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round5ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 6:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p1B1R6Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round5ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
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
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round6ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p2B1R6Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round5ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
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
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round6ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 7:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p1B1R7Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round6ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
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
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round7ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p2B1R7Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round6ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
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
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round7ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 8:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p1B1R8Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round7ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
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
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round8ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p2B1R8Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round7ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
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
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round8ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 9:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p1B1R9Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round8ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
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
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round9ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p2B1R9Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round8ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
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
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round9ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
                    roundCounter++;
                    break;
                
                case 10:
                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p1B1R10Lbl.Text = "X";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round9ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        player1Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p1B1R10Lbl.Text = beat1.ToString();
                        p1B2R10Lbl.Text = "/";
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round9ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        player1Spare++;
                    }
                    else
                    {
                        p1B1R10Lbl.Text = beat1.ToString();
                        p1B2R10Lbl.Text = beat2.ToString();
                        if (player1Spare > 0)
                        {
                            player1Score = 10 + beat1 + player1Score;
                            p1Round9ScoreLbl.Text = player1Score.ToString();
                            player1Spare--;
                        }
                        player1Score = beat1 + beat2 + player1Score;
                        p1Round10ScoreLbl.Text = player1Score.ToString();
                    }
                    //update scoreboard player 1

                    Thread.Sleep(50);
                    //program runs too quickly causing p1&p2 scores to be the same

                    beat1 = bowling(0);
                    beat2 = bowling(beat1);

                    if (beat1 == 10)
                    {
                        p2B1R10Lbl.Text = "X";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round9ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        player2Strike++;
                    }
                    else if (beat1 + beat2 == 10)
                    {
                        p2B1R10Lbl.Text = beat1.ToString();
                        p2B2R10Lbl.Text = "/";
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round9ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        player2Spare++;
                    }
                    else
                    {
                        p2B1R10Lbl.Text = beat1.ToString();
                        p2B2R10Lbl.Text = beat2.ToString();
                        if (player2Spare > 0)
                        {
                            player2Score = 10 + beat1 + player2Score;
                            p2Round9ScoreLbl.Text = player2Score.ToString();
                            player2Spare--;
                        }
                        player2Score = beat1 + beat2 + player2Score;
                        p2Round10ScoreLbl.Text = player2Score.ToString();
                    }
                    //update scoreboard player2
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
