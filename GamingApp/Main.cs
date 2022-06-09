using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace GamingApp
{
    public partial class DinoGame : Form
    {
        bool jumping;
        bool increaseSpeed;
        bool decreaseSpeed;
        int jumpSpeed;
        int force;
        int score,time;
        int SpeedOfDino;
        bool isGameFail;
        int n = 0;
       
        Random random = new Random();
        int position;
        

        public DinoGame()
        {
            InitializeComponent();
            StartGame();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void StartGame()
        {
            force = 20;
            jumpSpeed = 0;
            increaseSpeed = false;
            decreaseSpeed = false;
            isGameFail = false;
            jumping = false;
            SpeedOfDino = 10;
            score = 0;
            time = 0;
            PB_TRex.Image = Properties.Resources.running_1_;
            lbl_score.Text = "Score: " + score;

            PB_TRex.Top = 243;
            n = 50;
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Tree")
                {
                    
                    x.Left = this.ClientSize.Width  + n;
                    n = n + random.Next(50,200);
                    
                }


            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Santa")
                {

                    if (x is PictureBox && (string)x.Tag == "Santa")
                    {

                        x.Left = this.ClientSize.Width +random.Next(100, 500) ;

                    }
                }
            }
            TimerForSearchingRealTime.Start();
            MyTimer.Start();

        }
        int pushing = 1;

        private void WhenKeyIsDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space )
            {
                if (isGameFail == true && pushing==0)
                {
                    StartGame();
                }
                pushing = 1;
                if (jumping == false)
                {
                    jumping = true;
                }
                PB_TRex.Image = Properties.Resources.MyTirexFlying;
                
             
            }
            
            if (e.KeyCode == Keys.Right&&SpeedOfDino<30)
            {
                if(SpeedOfDino<30)
                increaseSpeed = true;

            }
            if (e.KeyCode == Keys.Left&&SpeedOfDino>5)
            {
                if(SpeedOfDino>6)
                decreaseSpeed = true;
            }
            if (e.KeyCode == Keys.R&&isGameFail==true)
            {
                lbl_RestartGame.Text = "The game restarted!";
                
                StartGame();
            }
            if (e.KeyCode == Keys.Up)
            {
                if(jumping==false)
                jumping = true;

                if (PB_TRex.Top < 243
                    && isGameFail == false)
                {
                    PB_TRex.Image = Properties.Resources.MyTirexFlying;
                }
            }
            

            
        }

        private void WhenKeyIsUp(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Space)
            {
                if (jumping == true)
                {
                    jumping = false;
                }
                pushing = 0;


            }
            if (e.KeyCode == Keys.Right && SpeedOfDino < 30)
            {
                increaseSpeed = false;

            }
            if (e.KeyCode == Keys.Left && SpeedOfDino > 5)
            {
                decreaseSpeed = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (jumping == true)
                {
                    jumping = false;
                }


            }

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            PB_TRex.Top += jumpSpeed;
            lbl_score.Text = "Score: " + score;
            if (jumping == true && force < 0)
            {
                jumping = false;

            }
            if (SpeedOfDino > 30) increaseSpeed = false;
            if (SpeedOfDino < 6) decreaseSpeed = false;
            if (increaseSpeed) SpeedOfDino++;
            if (decreaseSpeed) SpeedOfDino-=2;

            pb_speedOfDino.Value = SpeedOfDino*3;

            if (jumping == true)
            {
                jumpSpeed = -12;

                force = force - 1;
            }
            else
            {
                jumpSpeed = 12;

            }

            if(PB_TRex.Top>243 && jumping == false)
            {
                force = 20;
                PB_TRex.Top = 243;
                jumpSpeed = 0;
                PB_TRex.Image = Properties.Resources.running_1_;
            }
            if (n > 870)
            {
                n = 50;

            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "Tree")
                {
                    
                    x.Left = x.Left - SpeedOfDino;
                    if (x.Left < -100)
                    {
                        n = n + random.Next(50,200);
                        x.Left = this.ClientSize.Width + n;
                        score++;
                    }
                    
                    if (PB_TRex.Bounds.IntersectsWith(x.Bounds))
                    {
                        MyTimer.Stop();
                        TimerForSearchingRealTime.Stop();
                        lbl_RestartGame.Visible = true;
                        lbl_RestartGame.Text = "Push R to restart the game!";
                        PB_TRex.Image = Properties.Resources.dead_1_;
                        isGameFail = true;
                    }
                }
            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "Santa")
                {
                    
                    x.Left = x.Left - SpeedOfDino-10;
                    if (x.Left < -100&&isGameFail==false)
                    {
                        x.Left = this.ClientSize.Width + random.Next(500,1000);
                    }
                    
                    if (PB_TRex.Bounds.IntersectsWith(x.Bounds))
                    {
                        MyTimer.Stop();
                        TimerForSearchingRealTime.Stop();
                        lbl_RestartGame.Visible = true;
                        lbl_RestartGame.Text = "Push R to restart the game!";
                        PB_TRex.Image = Properties.Resources.dead_1_;
                        isGameFail = true;
                    }
                }
            }

            

        }

        private void TimerForSearchingRealTime_Tick(object sender, EventArgs e)
        {
            time++;
            lbl_time.Text = "Time: " + time;
            if (time == 3)
            {
                lbl_RestartGame.Visible = false;
            }
        }

        private void DinoGame_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string MessageToUser = "   This game is developed for fun. You can increase and decrease speed of T-Rex unlike other Dino games.\n" +
                "   I didn't have any equipments for changing the color of T-Rexes.So, they could be seen different.\n" +
                "   PictureBoxes are not the same size with pictures inside of them,and the PictureBoxes couldn't be cut. So, the T-Rex could touch the border,and you could fail the game for this.\n" +
                "   I didn't find any gif to add ground side,but as soon as I find, I will update the game.\n" +
                "            Happy New Year from Arif Mammadov";
            MessageBox.Show(MessageToUser,"Dino Game");


        }

       
private void brn_aboutTheGame_Click(object sender, EventArgs e)
{
   
}

        private void PB_TRex_Click(object sender, EventArgs e)
        {

        }
    }
}
