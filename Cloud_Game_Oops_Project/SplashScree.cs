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
    public partial class SplashScree : Form
    {
        public SplashScree()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer(object sender, EventArgs e)
        {
           
            timer1.Enabled = true;
            LoadingBar.Increment (3);
            if (LoadingBar.Value==100)
            {
                timer1.Enabled = false;
                MenuPage mp = new MenuPage();
                mp.Show();
                this.Hide();
            }
        }
      
    }
}
