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
    public partial class MenuPage : Form
    {
        MediaPlayer mp = new Music();
        public MenuPage()
        {
            mp.MenuPageSoundPlay();
            InitializeComponent();
            
        }
        
        //GameStart page open
        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                mp.ButtonEffectSoundPlay();
                StartPage sp = new StartPage();
                sp.Show();
                this.Hide();
            }
            catch(Exception)
            {
                MessageBox.Show("Sound Player File not found");
            }
           
        }

        //HighScore page open
        private void label3_Click(object sender, EventArgs e)
        {
            try {
                mp.ButtonEffectSoundPlay();
                HighScorePage hsp = new HighScorePage();
                hsp.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Sound Player File not found");
            }


        }

        //Application Exit
        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                mp.ButtonEffectSoundPlay();
                Application.Exit();
            }
            catch(Exception )
            {
                MessageBox.Show("Sound Player File not found");
            }
           
        }


        //Mouse Hover Effect
        private void sthover(object sender, EventArgs e)
        {
            this.label2.ForeColor = ColorTranslator.FromHtml("Red");
        }

        private void stleave(object sender, EventArgs e)
        {
            this.label2.ForeColor = ColorTranslator.FromHtml("AliceBlue");
        }

        private void hshover(object sender, EventArgs e)
        {
            this.label3.ForeColor = ColorTranslator.FromHtml("Red");
        }

        private void hsleave(object sender, EventArgs e)
        {
            this.label3.ForeColor = ColorTranslator.FromHtml("AliceBlue");
        }

        private void exithover(object sender, EventArgs e)
        {
            this.label4.ForeColor = ColorTranslator.FromHtml("Red");
        }

        private void exitleave(object sender, EventArgs e)
        {
            this.label4.ForeColor = ColorTranslator.FromHtml("AliceBlue");
        }
    }
}
