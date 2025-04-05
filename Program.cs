using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;
using File = DesignPatterns.Structural.Composite.File;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stock googleStock = new Stock();
            PriceDisplay priceDisplay = new PriceDisplay();
            PriceLogger priceLogger = new PriceLogger();
            googleStock.AddObserver(priceDisplay);
            googleStock.AddObserver(priceLogger);
            googleStock.Price = 1500; // This will notify observers
            googleStock.RemoveObserver(priceDisplay);
            googleStock.Price = 1600; // This will notify only the logger
        }

    }
}
