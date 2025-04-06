using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
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
            List<IFile> files = new List<IFile>
            {
                new AudioFile("music.mp3"),
                new TextFile("notes.txt")
            };

            IFileVisitor scanner = new VirusScanner();
            IFileVisitor compressor = new Compressor();

            foreach(var file in files)
            {
                file.Accept(scanner);
                file.Accept(compressor);
            }
        }

    }
}
