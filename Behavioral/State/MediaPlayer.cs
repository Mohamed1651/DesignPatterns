using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class MediaPlayer
    {
        private IPlayerState _playerState;
        public MediaPlayer()
        {
            _playerState = new StoppedState();
        }

        public void SetState(IPlayerState state)
        {
            _playerState = state;
        }

        public void Play()
        {
            _playerState.Play(this);
        }

        public void Pause()
        {
            _playerState.Pause(this);
        }

        public void Stop()
        {
            _playerState.Stop(this);
        }
    }
}
