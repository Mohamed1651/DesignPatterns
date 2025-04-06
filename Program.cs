using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
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
using Logger = DesignPatterns.Behavioral.ChainOfResponsibility.Logger;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logger console = new ConsoleLogger();
            Logger file = new FileLogger();
            Logger email = new EmailLogger();

            console.SetNext(file);
            file.SetNext(email);

            console.Log(LogLevel.Debug, "Debug message");
            console.Log(LogLevel.Error, "Error message");
            console.Log(LogLevel.Fatal, "Fatal message");
        }

    }
}
