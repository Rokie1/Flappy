using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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




        public Flappy()
        {
            InitializeComponent();
            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            BottomPipe.Left -= pipeSpeed;
            TopPipe.Left -= pipeSpeed;
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
    }
}
