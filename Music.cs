using System;
using System.Media;

namespace Main
{
    public class Music
    {
        SoundPlayer SongPlayer = new SoundPlayer();
        string CurrentSong = "";
        public void Track(string songno)
        {
            if (CurrentSong != songno)
            {
                SongPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + songno + ".wav";
                CurrentSong = songno;
                SongPlayer.PlayLooping();
                return;
                // "0" = Main Menu
                // "1" = Town -not implemented-
                // "2" = Battle -not implemented-
            }
            else
            {
                return;
            }
        }
    }
}
