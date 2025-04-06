using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class StoppedState : IPlayerState
    {
        public void Play(MediaPlayer mediaPlayer)
        {
            Console.WriteLine("Starting playback.");
            mediaPlayer.SetState(new PlayingState());
        }

        public void Pause(MediaPlayer mediaPlayer)
        {
            Console.WriteLine("Cannot pause. Media is stopped.");
        }

        public void Stop(MediaPlayer mediaPlayer)
        {
            Console.WriteLine("Already stopped.");
        }
    }
}
