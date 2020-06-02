// Piranavan Jeykumar
// 12.17.2017
// Pong
// To create pong against a computer that gets progessively harder
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class frmPong : Form
    {
        // Variable Declaration
        double dblSpeedPJ = 7;
        int intPlayerScorePJ = 0;
        int intComputerScorePJ = 0;
        int intComputerSpeedPJ = 3;
        int intAnglePJ = 30;
        double dblXValuePJ = 0;
        double dblYValuePJ = 0;
        int intRoundNumberPJ = 1;
        int intRandomDirectionPJ;
        Random rndDirectionPJ = new Random();
        Random rndInsultPJ = new Random();
        int intDirection;
        public frmPong()
        {
            InitializeComponent();
            // Variable Declaration
            int intRandomDirectionPJ;
            // Ball direction randomly chosen
            intRandomDirectionPJ = rndDirectionPJ.Next(1, 5);
            if (intRandomDirectionPJ == 1)
            {
                intDirection = 1;
            }
            else if (intRandomDirectionPJ == 2)
            {
                intDirection = 2;
            }
            else if (intRandomDirectionPJ == 3)
            {
                intDirection = 3;
            }
            else if (intRandomDirectionPJ == 4)
            {
                intDirection = 4;
            }
            this.lblComputerScore.Text = intComputerScorePJ.ToString();
            this.lblPlayerScore.Text = intPlayerScorePJ.ToString();
        }
        // Finds the Vertical value in which the ball will travel
        public int intVerticalValue(int intHypPJ, int intDegree)
        {
            return (int)(intHypPJ * Math.Sin((double)intDegree * Math.PI / 180));
        }
        // Finds the horizontal value in which the ball will travel
        public int intHorizontalValue(int intHypPJ, int intDegree)
        {
            return (int)(intHypPJ * Math.Cos((double)intDegree * Math.PI / 180));
        }
        // Game Functions, Ball movement, paddle interesection
        private void tmrGame_Tick(object sender, EventArgs e)
        {

            // Sets Angle Coordinates
            dblXValuePJ = intHorizontalValue((int)dblSpeedPJ, intAnglePJ);
            dblYValuePJ = intVerticalValue((int)dblSpeedPJ, intAnglePJ);
            // Quadrant IV
            if (intDirection == 1)
            {
                dblXValuePJ = Math.Abs(dblXValuePJ);
                dblYValuePJ = Math.Abs(dblYValuePJ) * -1;
            }
            // Quadrant III
            else if (intDirection == 2)
            {
                dblXValuePJ = Math.Abs(dblXValuePJ) * -1;
                dblYValuePJ = Math.Abs(dblYValuePJ) * -1;
            }
            // Quadrant II
            else if (intDirection == 3)
            {
                dblXValuePJ = Math.Abs(dblXValuePJ) * -1;
                dblYValuePJ = Math.Abs(dblYValuePJ);
            }
            // Quadrant I
            else if (intDirection == 4)
            {
                dblXValuePJ = Math.Abs(dblXValuePJ);
                dblYValuePJ = Math.Abs(dblYValuePJ);
            }
            // Sets the Boundaries and Direction for Counter-Clockwise
            // If the Ball hits the Computer Paddle
            if(this.picBall.Bounds.IntersectsWith(this.picComputer.Bounds))
            {
                if ((this.picBall.Top > this.picComputer.Top || this.picBall.Top < picComputer.Top) && this.picBall.Top < (this.picComputer.Top + this.picComputer.Height * 0.1))
                {
                    intDirection = 2;
                    intAnglePJ = 20;
                    dblSpeedPJ += 0.1;
                }
                else if (this.picBall.Top > this.picComputer.Top && this.picComputer.Top < (this.picComputer.Top + this.picComputer.Height * 0.75))
                {
                    intDirection = 2;
                    intAnglePJ = 45;
                    dblSpeedPJ += 0.1;
                }
                else if (this.picBall.Top > this.picComputer.Top && this.picBall.Top < (this.picComputer.Top + this.picComputer.Height * 0.5))
                {
                    intDirection = 3;
                    intAnglePJ = 45;
                    dblSpeedPJ += 0.1;
                }
                else if ((this.picBall.Top > this.picComputer.Top || this.picBall.Top < this.picComputer.Top) && this.picBall.Top < (this.picComputer.Top + this.picComputer.Height))
                {
                    intDirection = 3;
                    intAnglePJ = 20;
                    dblSpeedPJ += 0.1;
                }
                dblSpeedPJ += 0.25;
            }
            // If the ball hits the top border
            else if(intDirection == 2 && this.picBall.Bounds.IntersectsWith(this.picTopBorder.Bounds))
            {
                intDirection = 3;
            }
            // If the ball hits the Player paddle
            else if(this.picBall.Bounds.IntersectsWith(this.picPlayer.Bounds))
            {
                if((this.picBall.Top > this.picPlayer.Top || this.picBall.Top < picPlayer.Top) && this.picBall.Top < (this.picPlayer.Top + this.picPlayer.Height * 0.1))
                {
                    intDirection = 1;
                    intAnglePJ = 20;
                    dblSpeedPJ+= 0.1;
                }
                else if(this.picBall.Top > this.picPlayer.Top && this.picPlayer.Top < (this.picPlayer.Top + this.picPlayer.Height * 0.75))
                {
                    intDirection = 1;
                    intAnglePJ = 45;
                    dblSpeedPJ+= 0.1;
                }
                else if(this.picBall.Top > this.picPlayer.Top && this.picBall.Top < (this.picPlayer.Top + this.picPlayer.Height * 0.5))
                {
                    intDirection = 4;
                    intAnglePJ = 45;
                    dblSpeedPJ+= 0.1;
                }
                else if((this.picBall.Top > this.picPlayer.Top || this.picBall.Top < this.picPlayer.Top) && this.picBall.Top < (this.picPlayer.Top + this.picPlayer.Height))
                {
                    intDirection = 4;
                    intAnglePJ = 20;
                    dblSpeedPJ+= 0.1;
                }
            }
            // If the ball hits the bottom border
            else if(intDirection == 4 && this.picBall.Bounds.IntersectsWith(this.picBottomBorder.Bounds))
            {
                intDirection = 1;
            }
            // If the ball reaches the end of the player's side
            else if(intDirection == 3 && this.picBall.Bounds.IntersectsWith(this.picRightBounds.Bounds))
            {
                tmrGame.Enabled = false;
                tmrComputerMoves.Enabled = false;
                intComputerScorePJ++;
                this.lblComputerScore.Text = intComputerScorePJ.ToString();
                btnRematch.Visible = true;
                this.lblComputerScore.Visible = true;
                this.lblPlayerScore.Visible = true;
            }
            // If the ball reaches the end of the computer's side
            else if(intDirection == 1 && this.picBall.Bounds.IntersectsWith(this.picLeftBounds.Bounds))
            {
                tmrGame.Enabled = false;
                tmrComputerMoves.Enabled = false;
                intPlayerScorePJ++;
                this.lblPlayerScore.Text = intPlayerScorePJ.ToString();
                btnRematch.Visible = true;
                this.lblComputerScore.Visible = true;
                this.lblPlayerScore.Visible = true;
            }
            // Sets the Boundaries and Borders for Clockwise
            // If the ball hits the Player paddle
            if(this.picBall.Bounds.IntersectsWith(this.picPlayer.Bounds))
            {
                if ((this.picBall.Top > this.picPlayer.Top || this.picBall.Top < picPlayer.Top) && this.picBall.Top < (this.picPlayer.Top + this.picPlayer.Height * 0.1))
                {
                    intDirection = 4;
                    intAnglePJ = 20;
                    dblSpeedPJ+= 0.1;
                }
                else if (this.picBall.Top > this.picPlayer.Top && this.picPlayer.Top < (this.picPlayer.Top + this.picPlayer.Height * 0.75))
                {
                    intDirection = 4;
                    intAnglePJ = 45;
                    dblSpeedPJ+= 0.1;
                }
                else if (this.picBall.Top > this.picPlayer.Top && this.picBall.Top < (this.picPlayer.Top + this.picPlayer.Height * 0.5))
                {
                    intDirection = 1;
                    intAnglePJ = 45;
                    dblSpeedPJ+= 0.1;
                }
                else if ((this.picBall.Top > this.picPlayer.Top || this.picBall.Top < this.picPlayer.Top) && this.picBall.Top < (this.picPlayer.Top + this.picPlayer.Height))
                {
                    intDirection = 1;
                    intAnglePJ = 20;
                    dblSpeedPJ+= 0.1;
                }
            }
            // If the ball hits the top border
            else if(intDirection == 1 && this.picBall.Bounds.IntersectsWith(this.picTopBorder.Bounds))
            {
                intDirection = 4;
            }
            // If the ball hits the Computer paddle
            else if( this.picBall.Bounds.IntersectsWith(this.picComputer.Bounds))
            {
                if ((this.picBall.Top > this.picComputer.Top || this.picBall.Top < picComputer.Top) && this.picBall.Top < (this.picComputer.Top + this.picComputer.Height * 0.1))
                {
                    intDirection = 3;
                    intAnglePJ = 20;
                    dblSpeedPJ+= 0.1;
                }
                else if (this.picBall.Top > this.picComputer.Top && this.picComputer.Top < (this.picComputer.Top + this.picComputer.Height * 0.75))
                {
                    intDirection = 3;
                    intAnglePJ = 45;
                    dblSpeedPJ+= 0.1;
                }
                else if (this.picBall.Top > this.picComputer.Top && this.picBall.Top < (this.picComputer.Top + this.picComputer.Height * 0.5))
                {
                    intDirection = 2;
                    intAnglePJ = 45;
                    dblSpeedPJ+= 0.1;
                }
                else if ((this.picBall.Top > this.picComputer.Top || this.picBall.Top < this.picComputer.Top) && this.picBall.Top < (this.picComputer.Top + this.picComputer.Height))
                {
                    intDirection = 2;
                    intAnglePJ = 20;
                    dblSpeedPJ+= 0.1;
                }
            }
            // If the ball hits the bottom border
            else if(intDirection == 3 && this.picBall.Bounds.IntersectsWith(this.picBottomBorder.Bounds))
            {
                intDirection = 2;
            }
            // If the ball reaches the player's side
            else if(intDirection == 2 && this.picBall.Bounds.IntersectsWith(this.picRightBounds.Bounds))
            {
                tmrGame.Enabled = false;
                tmrComputerMoves.Enabled = false;
                intComputerScorePJ++;
                this.lblComputerScore.Text = intComputerScorePJ.ToString();
                btnRematch.Visible = true;
                this.lblComputerScore.Visible = true;
                this.lblPlayerScore.Visible = true;
            }
            // If the ball reaches the computer's side
            else if(intDirection == 4 && this.picBall.Bounds.IntersectsWith(this.picLeftBounds.Bounds))
            {
                tmrGame.Enabled = false;
                tmrComputerMoves.Enabled = false;
                intPlayerScorePJ++;
                this.lblPlayerScore.Text = intPlayerScorePJ.ToString();
                btnRematch.Visible = true;
                this.lblComputerScore.Visible = true;
                this.lblPlayerScore.Visible = true;
            }
            // Moves the Ball
            this.picBall.Left += (int)dblXValuePJ;
            this.picBall.Top += (int)dblYValuePJ;
            // Ensures  ball speed does not exceed 14 units per interval
            if(dblSpeedPJ > 14)
            {
                dblSpeedPJ -= 0.1;
            }
            // If you win, displays a message and shows Next Level button
            if(intPlayerScorePJ == 2)
            {
                // Variable Declaration
                int intRandomNumberPJ;
                // Button visibility
                btnExit.Visible = true;
                // Buton invisibility
                btnRematch.Visible = false;
                // Score reset
                this.lblPlayerScore.Text = 0.ToString();
                this.lblComputerScore.Text = 0.ToString();
                intPlayerScorePJ = 0;
                intComputerScorePJ = 0;
                // Random Message
                intRandomNumberPJ = rndInsultPJ.Next(1, 6);
                if(intRandomNumberPJ == 1)
                {
                    MessageBox.Show("You've shattered the hopes and dreams of this computer.\nAren't you proud?");
                }
                else if(intRandomNumberPJ == 2)
                {
                    MessageBox.Show("Not too shabby, but do you have what it takes to beat the next level?");
                }
                else if(intRandomNumberPJ == 3)
                {
                    MessageBox.Show("You may have won the battle, but you WILL lose the war.");
                }
                else if(intRandomNumberPJ == 4)
                {
                    MessageBox.Show("Don't get to exicted yet! This is only going to get HARDER.");
                }
                else if(intRandomNumberPJ == 5)
                {
                    MessageBox.Show("A little bit of luck can go a long way....");
                }
                //Button visibility
                btnNextLevel.Visible = true;
            }
            // If you lose, displays a message and shows Rematch button
            else if(intComputerScorePJ == 2)
            {
                // Button visibility
                btnExit.Visible = true;
                // Variable Declaration
                int intRandomNumberPJ;
                // Score reset
                this.lblPlayerScore.Text = 0.ToString();
                this.lblComputerScore.Text = 0.ToString();
                intPlayerScorePJ = 0;
                intComputerScorePJ = 0;
                // Random Message
                intRandomNumberPJ = rndInsultPJ.Next(1, 6);
                if (intRandomNumberPJ == 1)
                {
                    MessageBox.Show("Perhaps you should go back to playing Tic Tac Toe on EASY.");
                }
                else if (intRandomNumberPJ == 2)
                {
                    MessageBox.Show("Keep this up and you'll never be able to win.");
                }
                else if (intRandomNumberPJ == 3)
                {
                    MessageBox.Show("It would appear that Easy mode is too HARD for you.");
                }
                else if (intRandomNumberPJ == 4)
                {
                    MessageBox.Show("There's no shame in losing once...or twice..or thrice.. or however many times you've lost.");
                }
                else if (intRandomNumberPJ == 5 && intRandomNumberPJ > 5)
                {
                    MessageBox.Show("How many times did you lose? You've lost soo many, I lost count.");
                }
                // Button visibility
                btnRematch.Visible = true;
            }
        }
        // Controls Player paddle using keyboard buttons
        private void frmPong_KeyDown(object sender, KeyEventArgs e)
        {
            // Unit Movement for the Up Arrow Key
            if (e.KeyData == Keys.Up && this.picPlayer.Top > 30)
            {
                this.picPlayer.Top -= 15;
            }
            // Unit Movement for the Down Arrow Key
            else if(e.KeyData == Keys.Down && this.picPlayer.Bottom + 38 < 575)
            {
                this.picPlayer.Top += 15;
            }
        }
        // Enables Timer for Game functions
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Round Number label updated
            lblRoundNumber.Text = intRoundNumberPJ.ToString();
            // Timer enabled
            tmrGame.Enabled = true;
            tmrComputerMoves.Enabled = true;
            // Button visibility
            btnStart.Visible = false;
            btnInstructions.Visible = false;
        }
        // Timer controling computer movements
        private void tmrComputerMoves_Tick(object sender, EventArgs e)
        {
            // If the ball is passed the midway point
            if (picBall.Left > 530)
            {
                // If ball is above middle of computer paddle
                if (picComputer.Top + 12 > picBall.Top && picComputer.Top > picTopBorder.Bottom + 10)
                {
                    this.picComputer.Top -= intComputerSpeedPJ;
                }
                // If ball is below middle of computer paddle
                else if (picComputer.Top - 50 < picBall.Top && picComputer.Bottom < picBottomBorder.Top - 17)
                {
                    this.picComputer.Top += intComputerSpeedPJ;
                }
            }
        }
        // Computer difficulty raised
        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            // Variable increment
            intRoundNumberPJ++;
            // Ball speed reset
            dblSpeedPJ = 7;
            // Timers enabled
            tmrGame.Enabled = true;
            tmrComputerMoves.Enabled = true;
            // Ball Location reset
            picBall.Location = new Point(530, 204);
            // Computer paddle movement increased
            intComputerSpeedPJ += 3;
            // Label scores invisible
            this.lblComputerScore.Visible = false;
            this.lblPlayerScore.Visible = false;
            // Button visibility
            btnExit.Visible = false;
            btnNextLevel.Visible = false;
            // Ball Direction is randomly picked
            intRandomDirectionPJ = rndDirectionPJ.Next(1, 5);
            if (intRandomDirectionPJ == 1)
            {
                intDirection = 1;
            }
            else if (intRandomDirectionPJ == 2)
            {
                intDirection = 2;
            }
            else if (intRandomDirectionPJ == 3)
            {
                intDirection = 3;
            }
            else if (intRandomDirectionPJ == 4)
            {
                intDirection = 4;
            }
            // Label update
            this.lblRoundNumber.Text = intRoundNumberPJ.ToString();
            // Opponent colour change
            if(intRoundNumberPJ == 2)
            {
                picComputer.BackColor = Color.Green;
                picLeftBounds.BackColor = Color.Green;
            }
            else if(intRoundNumberPJ == 3)
            {
                picComputer.BackColor = Color.Orange;
                picLeftBounds.BackColor = Color.Orange;
            }
            else if(intRoundNumberPJ == 4)
            {
                picComputer.BackColor = Color.Pink;
                picLeftBounds.BackColor = Color.Pink;
            }
            else if(intRoundNumberPJ == 5)
            {
                picComputer.BackColor = Color.White;
                picLeftBounds.BackColor = Color.White;
            }
            else if(intRandomDirectionPJ > 5)
            {
                int intRandomNumberPJ;
                intRandomNumberPJ = rndDirectionPJ.Next(1, 5);
                if (intRandomNumberPJ == 1)
                {
                    picComputer.BackColor = Color.Green;
                    picLeftBounds.BackColor = Color.Green;
                }
                else if (intRandomNumberPJ == 2)
                {
                    picComputer.BackColor = Color.Orange;
                    picLeftBounds.BackColor = Color.Orange;
                }
                else if (intRandomNumberPJ == 3)
                {
                    picComputer.BackColor = Color.Pink;
                    picLeftBounds.BackColor = Color.Pink;
                }
                else if (intRandomNumberPJ == 4)
                {
                    picComputer.BackColor = Color.White;
                    picLeftBounds.BackColor = Color.White;
                }
            }
        }
        // Computer difficulty unchanged
        private void btnRematch_Click(object sender, EventArgs e)
        {
            // Button invisible
            btnExit.Visible = false;
            // Ball speed reset
            dblSpeedPJ = 7;
            // Timer enabled
            tmrGame.Enabled = true;
            tmrComputerMoves.Enabled = true;
            // Ball location reset
            picBall.Location = new Point(530,240);
            // Ball direction randomly chosen
            intRandomDirectionPJ = rndDirectionPJ.Next(1, 5);
            if (intRandomDirectionPJ == 1)
            {
                intDirection = 1;
            }
            else if (intRandomDirectionPJ == 2)
            {
                intDirection = 2;
            }
            else if (intRandomDirectionPJ == 3)
            {
                intDirection = 3;
            }
            else if (intRandomDirectionPJ == 4)
            {
                intDirection = 4;
            }
            // Button invisibility
            btnRematch.Visible = false;
            // Labels are invisible
            this.lblComputerScore.Visible = false;
            this.lblPlayerScore.Visible = false;
        }
        // Displays Instructions for game
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Final Battle Royal. You, against countless opponents who will not show mercy and will fight till the end. Will you emerge victorious or fall like the rest? \n\nYou are equipped with an upwards movement by using the Up Arrow Key and a downwards movement by using the Down Arrow Key. \n\nYour goal is simple. Hit the energy blast to the end of your opponent's side.\n\nRemember every time the energy blast is hit, it gets faster. Don't forgot, with every opponent, it'll only get harder. You only get 3 round against each opponent, the one who wins twice, shall move on.\n\nNow go! Let's find out how long you'll be able to last....");
        }
        // Exits Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
