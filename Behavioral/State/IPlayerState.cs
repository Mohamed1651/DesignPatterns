using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public interface IPlayerState
    {
        void Play(MediaPlayer mediaPlayer);
        void Pause(MediaPlayer mediaPlayer);
        void Stop(MediaPlayer mediaPlayer);
    }
}
