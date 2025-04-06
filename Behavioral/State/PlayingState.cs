using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class PlayingState : IPlayerState
    {
        public void Pause(MediaPlayer mediaPlayer)
        {
            Console.WriteLine("Pausing playback.");
            mediaPlayer.SetState(new PausedState());
        }

        public void Play(MediaPlayer mediaPlayer)
        {
            throw new NotImplementedException();
        }

        public void Stop(MediaPlayer mediaPlayer)
        {
            throw new NotImplementedException();
        }
    }
}
