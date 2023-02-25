using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Game_Oops_Project
{
    public interface MediaPlayer
    {
        void gameOverSound();
        void gameSound();
        void gameOverSoundPlay();
        void gameSoundPlay();
        void gameOverSoundStop();
        void gameSoundStop();
        void MenuPageSound();
        void ButtonEffectSound();
        void MenuPageSoundPlay();
        void ButtonEffectSoundPlay();
        void MenuPageSoundStop();
        void ButtonEffectSoundStop();
    }
}
