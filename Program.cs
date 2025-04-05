using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Proxy;
using File = DesignPatterns.Structural.Composite.File;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVideo video = new ProxyVideo("epic_movie.mp4");

            Console.WriteLine("First play call:");
            video.Play(); // Loads and plays the video

            Console.WriteLine("\nSecond play call:");
            video.Play(); // Only plays (no loading)
        }

    }
}
