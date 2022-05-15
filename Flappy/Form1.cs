using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy
{
    public partial class Flappy : Form
    {
        int pipeSpeed = 8;
        int gravity =15;
        int score = 0;
        bool start = false;



        public Flappy()
        {
            InitializeComponent();
            
            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Starting()
        {
            if (!start)
            {
                StartTimer.Text = 3 + "";
                StartTimer.Invalidate();
                StartTimer.Update();
                Thread.Sleep(1000);
                StartTimer.Text = 2 + "";
                StartTimer.Invalidate();
                StartTimer.Update();
                Thread.Sleep(1000);
                StartTimer.Text = 1 + "";
                StartTimer.Invalidate();
                StartTimer.Update();
                Thread.Sleep(1000);
                StartTimer.Text = "Go!";
                StartTimer.Invalidate();
                StartTimer.Update();
                Thread.Sleep(500);
                StartTimer.Visible=false;




                start = true;
            }

        }

        
        private void gameTimerEvent(object sender, EventArgs e)
        {
            Starting();


            Bird.Top += gravity;
            BottomPipe.Left -= pipeSpeed;
            TopPipe.Left -= pipeSpeed;
            ScoreText.Text = "Score: "+score;



            if (BottomPipe.Left < -150)
            {
                BottomPipe.Left = 800;
                pipeSpeed++;
                score++;


            }
            if (TopPipe.Left < -180)
            {
                TopPipe.Left = 950;
                pipeSpeed++;
                score++;

            }


            if (Bird.Bounds.IntersectsWith(BottomPipe.Bounds)
                || Bird.Bounds.IntersectsWith(TopPipe.Bounds) 
                || Bird.Bounds.IntersectsWith(Ground.Bounds)
                || Bird.Top < -25)


            {
                endGame();


            }
           
        }

        private void Flappy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -15;

                
            }


        }

        private void Flappy_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;


            }

        }


        private void endGame()
        {
            gameTimer.Stop();
            StartTimer.Visible = true;
            StartTimer.Text = "Game Over!";


        }
    }
}
