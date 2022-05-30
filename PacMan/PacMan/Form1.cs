using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class Form1 : Form
    {
        bool goup, godown, goleft, goright, isGameOver;

        int score, playerSpeed, blueGhostSpeed, OrangeGhostSpeed, RedGhostX, RedGhostY;

        public Form1()
        {
            InitializeComponent();

            resetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                goup = true;
                
            }
            if(e.KeyCode == Keys.Down)
            {
                godown = true;
                
            }
            if(e.KeyCode== Keys.Left)
            {
                goleft = true;
                
            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
                
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            scoreLB.Text = "SCORE: " + score;

            if (goleft == true)
            {
                PacManPB.Left -= playerSpeed;
                PacManPB.Image = Properties.Resources.pacman_vasen;
            }
            if (goright == true)
            {
                PacManPB.Left += playerSpeed;
                PacManPB.Image = Properties.Resources.pacman;
            }
            if (godown == true)
            {
                PacManPB.Top += playerSpeed;
                PacManPB.Image = Properties.Resources.pacman_alas;
            }
            if (goup == true)
            {
                PacManPB.Top -= playerSpeed;
                PacManPB.Image = Properties.Resources.Pacman_ylos;
            }

            if(PacManPB.Left < -10)
            {
                PacManPB.Left = 680;
            }
            if(PacManPB.Left > 680)
            {
                PacManPB.Left = -10;
            }

            if (PacManPB.Top < -10)
            {
                PacManPB.Top = 550;
            }
            if (PacManPB.Top > 550)
            {
                PacManPB.Top = 0;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (PacManPB.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                    }

                    if ((string)x.Tag == "wall" )
                    {
                        if (PacManPB.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("You Lose!");
                        }

                        if (RedGhostPB.Bounds.IntersectsWith(x.Bounds))
                        {
                            RedGhostX = -RedGhostX;
                        }
                    }

                    if ((string)x.Tag == "ghost")
                    {
                        if (PacManPB.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("You Lose!");
                        }
                    }

                }
            }

            BlueGhostPB.Left += blueGhostSpeed;

            if(BlueGhostPB.Bounds.IntersectsWith(pictureBox3.Bounds) || BlueGhostPB.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                blueGhostSpeed = -blueGhostSpeed;
            }

            OrangeGhostPB.Left -= OrangeGhostSpeed;

            if (OrangeGhostPB.Bounds.IntersectsWith(pictureBox2.Bounds) || OrangeGhostPB.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                OrangeGhostSpeed = -OrangeGhostSpeed;
            }

            RedGhostPB.Left -= RedGhostX;
            RedGhostPB.Top -= RedGhostY;

            if(RedGhostPB.Top < 0 || RedGhostPB.Top > 520)
            {
                RedGhostY = -RedGhostY;
            }
            if (RedGhostPB.Left < 0 || RedGhostPB.Left > 620)
            {
                RedGhostX = -RedGhostX;
            }

            if (score == 42)
            {
                gameOver("You Win!");
            }
        }

        private void resetGame()
        {

            scoreLB.Text = " SCORE: 0";
            score = 0;

            blueGhostSpeed = 5;
            OrangeGhostSpeed = 5;  
            RedGhostX = 5;
            RedGhostY = 5;
            playerSpeed = 8;

            isGameOver = false;

            PacManPB.Left = 28;
            PacManPB.Top = 39;

            BlueGhostPB.Left = 207;
            BlueGhostPB.Top = 50;

            OrangeGhostPB.Left = 404;
            OrangeGhostPB.Top = 442;

            RedGhostPB.Left = 353;
            RedGhostPB.Top = 297;

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Visible = true;
                }
            }

            GameTimer.Start();

        }

        private void gameOver(string message)
        {
            isGameOver = true;

            GameTimer.Stop();

            scoreLB.Text ="SCORE: " + score + Environment.NewLine + message;
        }
    }
}
