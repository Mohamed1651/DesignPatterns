using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class HomeTheaterFacade
    {
        private DVDPlayer _dvdPlayer;
        private Projector _projector;
        private SoundSystem _soundSystem;
        private Lights _lights;

        public HomeTheaterFacade(DVDPlayer dvd, Projector projector, SoundSystem sound, Lights lights)
        {
            this._dvdPlayer = dvd;
            this._projector = projector;
            this._soundSystem = sound;
            this._lights = lights;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _lights.Dim();
            _projector.On();
            _soundSystem.On();
            _soundSystem.SetVolume(10);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _dvdPlayer.Off();
            _soundSystem.Off();
            _projector.Off();
            _lights.On();
        }
    }
}
