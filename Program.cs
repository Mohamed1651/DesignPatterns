using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Bridge;
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
            IDevice device = new TV();
            Remote remote = new AdvancedRemote(device);

            remote.TogglePower();
            remote.TogglePower();

            ((AdvancedRemote)remote).Mute();
        }

    }
}
