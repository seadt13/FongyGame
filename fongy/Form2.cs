using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fongy
{
    public partial class Form2 : Form
    {
        //location - movement speed variables
        int cpuDirection = 5;
        int ballX = 5;
        int ballY = 5;
        //score variables
        int playerScore=0;
        int cpuScore=0;
        //size variables
        int bottomLine;
        int centerPoint;
        int xMidPoint;
        int yMidPoint;
        //movement boolean
        bool playerUp;
        bool playerDown;
        //keys
        int spaceClicked = 0;
        public Form2()
        {
            InitializeComponent();
            bottomLine=ClientSize.Height - player.Height;
            xMidPoint=ClientSize.Width / 2;
            yMidPoint = ClientSize.Height / 2;
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //pressing up arrow --> move player upwards
            if(e.KeyCode==Keys.Up){playerUp=true;}
            //pressing down arrow --> move player downwards
            if (e.KeyCode == Keys.Down) { playerDown = true;}
            //pausing game with pressing spacebar
            if(e.KeyCode==Keys.Space) 
            { 
                if(spaceClicked%2==0)
                {   
                    timer1.Stop();
                }    
                else
                {
                    timer1.Start(); 
                }
            }
            spaceClicked++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            // adjust where the ball is
            pbBall.Top -= ballY;
            pbBall.Left -= ballX;
            
            // make the CPU move
            cpu.Top += cpuDirection;

            // check if CPU has reached the top or the bottom
            if (cpu.Top < 0 || cpu.Top > bottomLine) { cpuDirection = -cpuDirection; }
            // check if the ball has exited the left side of the screen
            if (pbBall.Left < 0)
            {
                pbBall.Left = xMidPoint;
                pbBall.Top = newSpot;
                ballX = -ballX;
                if (playerScore < 2) { ballX -= 1; }
                cpuScore++;
                scoreCPU.Text = cpuScore.ToString();
            }

            // Check if the ball has touched right side of the screen
            if (pbBall.Left + pbBall.Width > ClientSize.Width)
            {
                pbBall.Left = xMidPoint;
                pbBall.Top = newSpot;
                ballX = -ballX;
                if (playerScore < 2) { ballX += 1; }
                playerScore++;
                scorePlayer.Text = playerScore.ToString();
            }

            // checks if ball is in the border
            if (pbBall.Top < 0 || pbBall.Top + pbBall.Height > ClientSize.Height) { ballY = -ballY; }

            // check if the ball hits the player or CPU 
            if (pbBall.Bounds.IntersectsWith(player.Bounds) || pbBall.Bounds.IntersectsWith(cpu.Bounds))
            {
                // send ball opposite direction
                ballX = -ballX;
            }
            // move player up
            if (playerUp == true && player.Top > 0) { player.Top -= 10; }
            // move player down
            if (playerDown == true && player.Top < bottomLine) { player.Top += 10; }
            // check for winner
            if (playerScore ==5)
            {
                timer1.Stop();
            }
        }
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { playerUp = false; }
            if (e.KeyCode == Keys.Down) { playerDown = false; }
        }
    }
}
