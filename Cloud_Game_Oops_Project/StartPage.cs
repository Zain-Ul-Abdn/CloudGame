using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloud_Game_Oops_Project
{
    public partial class StartPage : Form
    {
        MediaPlayer mp = new Music();
        //Boolean Datatype variable
        private bool IsGameOver = false;
        private bool IsGameStart = false;
        private bool STimer = false;
        private bool countertimer = false;

        // Int dataType variables
        private int gravity = 5;
        private int obstacleSpeed = 10;
        private int counter = 0;

        //For Access the score variable in otherforms
        public static int score;
       

        //For Generating Random positions for obstacle in the game
        Random random = new Random();

        public StartPage()
        {
            InitializeComponent();

            try
            {
                mp.gameSoundPlay();
            }
            catch(Exception)
            {
                MessageBox.Show("Sound player file not found!");
            }
            
            //When the game restart the score set to be zero 
            score = 0;
            
        }

        /*Main game timer where you can applay logic and condtions for 
          moving the obtacle and what happens when cloud strike to the obstacle*/
        private void MainGameTimer(object sender, EventArgs e)
        { 
            //Set the cloud position and jumping state
            Cloud.Top += gravity;

            //Move the standind position of cloud to the left
            StartingPosition.Left -= 3;

            //Move the obstacles to the left according to the score level
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Bird1_obstacle")
                {
                    x.Left -= obstacleSpeed;
                    if (x.Left < -this.ClientSize.Width)
                    {
                        x.Left = this.ClientSize.Width+random.Next(300, 500);
                    }
                }

                if (x is PictureBox && (string)x.Tag == "StormCloud2_obstacle")
                {
                    if ((int)score > 50)
                    {
                        x.Left -= obstacleSpeed; 
                        if (x.Left < -this.ClientSize.Width)
                        {
                            x.Left = this.ClientSize.Width + random.Next(400,800)+(x.Width * 15);
                        }
                    }

                }
                if (x is PictureBox && (string)x.Tag == "StormCloud_obstacle")
                {
                    if ((int)score > 30)
                    {
                        x.Left -= obstacleSpeed;
                        if (x.Left < -this.ClientSize.Width)
                        {
                            x.Left = this.ClientSize.Width + random.Next(200,500) + (x.Width * 10);
                        }
                    }

                }

                // ScoreTimer && Gametimer Stop when the cloud strike to the obstacle
                if (Cloud.Bounds.IntersectsWith(Bird1_obstacle.Bounds) || 
                    Cloud.Bounds.IntersectsWith(StormCloud_obstacle.Bounds)
                   ||Cloud.Bounds.IntersectsWith(StormCloud2_obstacle.Bounds)
                    || Cloud.Bounds.IntersectsWith(pictureBox1.Bounds) || 
                    Cloud.Bounds.IntersectsWith(pictureBox4.Bounds)
                    || Cloud.Bounds.IntersectsWith(pictureBox7.Bounds)
                    || Cloud.Bounds.IntersectsWith(pictureBox2.Bounds) || 
                    Cloud.Bounds.IntersectsWith(txtcounter.Bounds) || 
                    Cloud.Bounds.IntersectsWith(label1.Bounds) )
                {
                    Scoretimer.Stop();
                    gametimer.Stop();
                    Cloud.Image = Properties.Resources.Dead;
                    IsGameOver = true;
                    RestartGame();

                }
            }
        }

        //ScoreCounter timer for score counting
        private void ScoreCounter(object sender, EventArgs e)
        {          
            if (STimer==true)
            {
                txtScore.Text = "Score :" +score++.ToString();

                //When cloud score reached 100 obstacle speed raised to +5
                if (score>100)
                {
                    obstacleSpeed+=5;
                }
                
            }

        }

        /*There we control our bird position and when we press jump key gametimer && 
        ScoreTimer start*/
        private void UpKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && IsGameStart == false)
            {
                  
                
                if (gametimer.Enabled == false)
                {
                    gametimer.Enabled = true;
                    gametimer.Start();

                }
                IsGameStart = true;
                if (STimer == false)
                {
                    Scoretimer.Start();
                    STimer = true;
                }
            }

            if (e.KeyCode == Keys.Space && IsGameStart == true)
            {
                gravity = -5;
            }
        }

        private void DownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && IsGameStart == true)
            {
                gravity = 5;
            }
        }

        private void RestartGame()
        {
            if (IsGameOver==true)
            {
                try
                {
                    mp.gameSoundStop();
                    mp.gameOverSoundPlay();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sound player file not found!");
                }
               
                Restart.Enabled = true;
                Restart.Start();
                IsGameOver = false;
               
            }
        }

        /*GameOver Timer is used for displaying the restartgame page
         * Actually when gameisover restartgame page not show instantly
         * Its shows with 3 sec delay time
         */
        private void Gameovertimer(object sender, EventArgs e)
        {
            txtcounter.Text = counter++.ToString();
            if (Convert.ToInt32(counter)>=5)
            {
                Restart.Enabled = false;
                Counter.Text = " ";
                Restart.Stop();
                this.Hide();
                RestartPage restart = new RestartPage();
                restart.Show();
            }
        }
    }

}
