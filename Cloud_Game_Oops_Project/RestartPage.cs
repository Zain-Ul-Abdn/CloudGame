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
    public partial class RestartPage : Form
    {
        MediaPlayer MP = new Music();
       
        public RestartPage()
        {
            InitializeComponent();
            HighScoreManage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                MP.ButtonEffectSoundPlay();
                StartPage form = new StartPage();
                form.Show();
                this.Hide();
            }
            catch(Exception)
            {
                MessageBox.Show("Sound Player File not found");
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                MP.ButtonEffectSoundPlay();
                MenuPage mp = new MenuPage();
                mp.Show();
                this.Hide();
            }
            catch(Exception)
            {
                MessageBox.Show("Sound Player File not found");
            }
          
        }

        private void HighScoreManage()
        {
            txtscore.Text = "Score :" + StartPage.score.ToString();
            if (StartPage.score > HighScorePage.hs1 && StartPage.score > HighScorePage.hs2 && StartPage.score < HighScorePage.hs1 &&
                StartPage.score > HighScorePage.hs3 && StartPage.score < HighScorePage.hs2)
            {
                HighScorePage.hs1 = StartPage.score;
            }
            else if (StartPage.score > HighScorePage.hs1)
            {
                HighScorePage.hs1 = StartPage.score;
            }
            else if (StartPage.score > HighScorePage.hs2 && StartPage.score < HighScorePage.hs1)
            {
                HighScorePage.hs2 = StartPage.score;
            }
            else if (StartPage.score > HighScorePage.hs3 && StartPage.score < HighScorePage.hs2)
            {
                HighScorePage.hs3 = StartPage.score;
            }
        }
    }
}
