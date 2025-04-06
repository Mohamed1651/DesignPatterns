using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class PausedState : IPlayerState
    {
        public void Play(MediaPlayer mediaPlayer)
        {
            Console.WriteLine("Resuming playback.");
            mediaPlayer.SetState(new PlayingState());
        }

        public void Pause(MediaPlayer mediaPlayer)
        {
            Console.WriteLine("Already paused.");
        }

        public void Stop(MediaPlayer mediaPlayer)
        {
            Console.WriteLine("Stopping playback.");
            mediaPlayer.SetState(new StoppedState());
        }
    }
}
