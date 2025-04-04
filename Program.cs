using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dvd = new DVDPlayer();
            var projector = new Projector();
            var soundSystem = new SoundSystem();
            var lights = new Lights();
            var homeTheater = new HomeTheaterFacade(dvd, projector, soundSystem, lights);
            homeTheater.WatchMovie("Inception");
            homeTheater.EndMovie();
        }

    }
}
