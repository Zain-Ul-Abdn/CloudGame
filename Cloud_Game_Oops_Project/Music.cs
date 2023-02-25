using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Game_Oops_Project
{
    internal class Music:MediaPlayer
    {
        SoundPlayer gos, gs,mps,bes;
        public void gameOverSound()
        {
            //gos = new SoundPlayer(@"D:\PROJECTS\Cloud_Game_Oops_Project\Resources\Sound Effect\GameOver SoundEffect.wav");
             gos = new SoundPlayer(@"GameOver SoundEffect.wav");
        }

        public void gameSound()
        {
           // gs = new SoundPlayer(@"D:\PROJECTS\Cloud_Game_Oops_Project\Resources\Sound Effect\Fluffing-a-Duck.wav");
            gs = new SoundPlayer(@"Fluffing-a-Duck.wav");

        }

        public void gameOverSoundPlay()
        {
            gameOverSound();
            gos.Play();
        }
        public void gameSoundPlay()
        {
            gameSound();
            gs.Play();
        }
        public void gameOverSoundStop()

        {
            gameOverSound();
            gos.Stop();
        }
        public void gameSoundStop()
        {
            gameSound();
            gs.Stop();
        }
        public void MenuPageSoundPlay()
        {
            MenuPageSound();
            mps.Play();
        }
        public void ButtonEffectSoundPlay()
        {
            ButtonEffectSound();
            bes.Play();
        }
        public void MenuPageSoundStop()
        {
            MenuPageSound();
            mps.Stop();
        }
        public void ButtonEffectSoundStop()
        {
            ButtonEffectSound();
            bes.Stop();
        }

        public void MenuPageSound()
        {
            //mps = new SoundPlayer(@"D:\PROJECTS\Cloud_Game_Oops_Project\Resources\Sound Effect\Carefree.wav");
            mps = new SoundPlayer(@"Carefree.wav");


        }
        public void ButtonEffectSound()
        {
           // bes = new SoundPlayer(@"D:\PROJECTS\Cloud_Game_Oops_Project\Resources\Sound Effect\ButtonEffext Sound.wav");
            bes = new SoundPlayer(@"ButtonEffext Sound.wav");

        }
    }
}
