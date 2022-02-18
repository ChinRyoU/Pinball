using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinball
{
    public partial class Form1 : Form
    {
        private ball b;
        bool move1down = false;
        bool move1up = false;
        bool move2down = false;
        bool move2up = false;
        float speedup = 1.1f;
        float defaultspeed = 1.5f;
        float speed1 = 3f;
        float speed2 = 3f;
        Random rdm = new Random();
        float ballspeed_x = 1f;
        float ballspeed_y = 1f;
        int score1 = 0;
        int score2 = 0;
        int balldefault_positionX;
        int balldefault_positionY;
        int player1default_positionX;
        int player1default_positionY;
        int player2default_positionX;
        int player2default_positionY;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                restart();
            }
            if (e.KeyCode == Keys.S)
            {
                move1down = true;
            }

            if (e.KeyCode == Keys.W)
            {
                move1up = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                move2down = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                move2up = true;
            }

        }

        private void Player2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                //Console.WriteLine("s!");
                move1down = false;
            }
            if (e.KeyCode == Keys.W)
            {
                //Console.WriteLine("w!");
                move1up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                move2down = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                move2up = false;

            }
        }
            private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (move1up && Player1.Location.Y > 0)
            {
                float y1 = Player1.Location.Y;
                speed1 *= speedup;
                y1 -= speed1;
                if (y1 < 0)
                {
                    y1 = 0;
                }
                Player1.Location = new System.Drawing.Point(Player1.Location.X, (int)y1);
            }
            if (move1down && Player1.Location.Y < 360)
            {
                float y1 = Player1.Location.Y;
                speed1 *= speedup;
                y1 += speed1;
                if (y1 > 360)
                {
                    y1 = 360;
                }
                Player1.Location = new System.Drawing.Point(Player1.Location.X, (int)y1);
            }
            if(!move1down && !move1up)
            {
                speed1 = 3;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (move2up && Player2.Location.Y > 0)
            {
                float y2 = Player2.Location.Y;
                speed2 *= speedup;
                y2 -= speed2;
                if(y2 < 0)
                {
                    y2 = 0;
                }
                Player2.Location = new System.Drawing.Point(Player2.Location.X, (int)y2);
            }
            if (move2down && Player2.Location.Y < 360)
            {
                float y2 = Player2.Location.Y;
                speed2 *= speedup;
                y2 += speed2;
                if (y2 > 360)
                {
                    y2 = 360;
                }         
                Player2.Location = new System.Drawing.Point(Player2.Location.X, (int)y2);
            }
            if (!move2down && !move2up)
            {
                speed2 = 3;
            }
        }

        private void timerball_Tick(object sender, EventArgs e)
        {
            float p_x, p_y;

            if (b.PositionY >= 440)
            {
                ballspeed_y *= -1f;
            }
            if (b.PositionY <= 3)
            {
                ballspeed_y *= -1f;
            }
            if (b.PositionX < 9)
            {
                if(move1up && ballspeed_y > 0)
                {
                    ballspeed_y *= -1f;
                    ballspeed_x *= 1.01f + (speed1 / defaultspeed) / 12;
                }
                if (move1down && ballspeed_y < 0)
                {
                    ballspeed_y *= -1.1f;
                    ballspeed_x *= 1.01f + (speed1 / defaultspeed) / 12;
                }
                ballspeed_x *= -1f;
            }
            if (b.PositionX >= 755)
            {
                if (move2up && ballspeed_y > 0)
                {
                    ballspeed_y *= -1f;
                    ballspeed_x *= 1.01f + (speed2 / defaultspeed) / 12;
                }
                if (move2down && ballspeed_y < 0)
                {
                    ballspeed_y *= -1f;
                    ballspeed_x *= 1.01f + (speed2 / defaultspeed) / 12;
                }
                ballspeed_x *= -1f;
            }

            b.move(ballspeed_x, ballspeed_y, out p_x, out p_y);
            this.SuspendLayout();
            
            b.draw(p_x, p_y);
            this.ResumeLayout();
            Console.WriteLine(b.PositionX + " " + b.PositionY);
            bool g = goal();
            if (g)
            {
                timerball.Stop();
                timer.Stop();
                timer2.Stop();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBall.BringToFront();
            ballspeed_x = (float)(rdm.NextDouble() + 1);
            ballspeed_y = (float)(rdm.NextDouble() + 1);
            balldefault_positionX = pictureBall.Location.X;
            balldefault_positionY = pictureBall.Location.Y;
            player1default_positionX = Player1.Location.X;
            player1default_positionY = Player1.Location.Y;
            player2default_positionX = Player2.Location.X;
            player2default_positionY = Player2.Location.Y;
            b = new ball(pictureBall.Location.X, pictureBall.Location.Y, defaultspeed, pictureBall);
            labelScore1.Text = score1.ToString();
            labelScore2.Text = score2.ToString();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public bool goal()
        {
            bool g = false;
            if ((b.PositionX < 10 && Player1.Location.Y + 100 < b.PositionY) || (b.PositionX < 10 && Player1.Location.Y > b.PositionY + 15))
            {
                //Console.WriteLine("goal" + "Player1.Location.Y = " + Player1.Location.Y + "b.PositionY = " + b.PositionY);
                score2++;
                labelScore2.Text = score2.ToString();
                g = true;
            }
            if ((b.PositionX > 755 && Player2.Location.Y + 100 < b.PositionY) || (b.PositionX > 755 && Player2.Location.Y > b.PositionY + 15))
            {
                Console.WriteLine("goal" + "Player2.Location.Y = " + Player2.Location.Y + "b.PositionY = " + b.PositionY);
                score1++;
                labelScore1.Text = score1.ToString();
                g = true;
            }
            return g;
        }
        public void restart()
        {
            
            int positionX = balldefault_positionX;
            int positionY = balldefault_positionY;
            Player1.Location = new System.Drawing.Point(player1default_positionX, player1default_positionY);
            Player2.Location = new System.Drawing.Point(player2default_positionX, player2default_positionY);
            b.draw(positionX, positionY);
            ballspeed_x = (float)(rdm.Next(-3, 3));
            ballspeed_y = (float)(rdm.Next(-3, 3));   // (rdm.NextDouble() - 0.5) * 10d - 9d
            if(ballspeed_x == 0 || ballspeed_y == 0)
            {
                ballspeed_x = 1.5f;
                ballspeed_y = 1.5f;
            }
            if ((score1 + score2) % 2 != 0)
            {
                ballspeed_x *= -1f;
            }
            else
            {
                ballspeed_y *= -1f;
            }
            timer.Start();
            timer2.Start();
            timerball.Start();
        }
    }
}
