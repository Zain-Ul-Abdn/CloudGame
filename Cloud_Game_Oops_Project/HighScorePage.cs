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
    public partial class HighScorePage : Form
    {
        MediaPlayer MP = new Music();

        public static int hs1 = 0;
        public static int hs2 = 0;
        public static int hs3 = 0;

        public HighScorePage()
        {
            InitializeComponent();
            HsOne.Text = hs1.ToString(); 
            Hstwo.Text = hs2.ToString();
            HsThree.Text = hs3.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

      
    }
}
