using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flepygames
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; 
        int gravity = 15; 
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = -15;
            }
            }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = 15;
            }


        }

        private void timeGamesEvent(object sender, EventArgs e)
        {
            player.Top += gravity;
            pipe1.Left -= pipeSpeed; 
            pipe2.Left -= pipeSpeed; 
            txtscore.Text = "Score: " + score; 


            if (pipe1.Left < -150)
            {
              
                pipe1.Left = 300;
                score++;
            }
            if (pipe2.Left < -350)
            {
              
                pipe2.Left = 500;
                score++;
            }

           
            if (player.Bounds.IntersectsWith(pipe1.Bounds) ||
                player.Bounds.IntersectsWith(pipe2.Bounds) ||
                player.Bounds.IntersectsWith(black1.Bounds) ||
                   player.Bounds.IntersectsWith(black2.Bounds) ||
                player.Top < -25
                )
            {
               
                endGame();
            }
            if (score > 2)
            {
                pipeSpeed = 15;
            }

            if(score > 10)
            {
                pipeSpeed = 20;
            }


        }

        private void pipe2_Click(object sender, EventArgs e)
        {

        }


        private void endGame()
        {
            
            timerGames.Stop(); 
            txtscore.Text += " Game over!!!";

            
        }
    }
}
