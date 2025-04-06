using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
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
            var editor = new Editor();
            var history = new EditorHistory();

            editor.Type("Mo is here");
            history.Save(editor.Save());
            editor.Type(" and he is happy");
            editor.Save();
            Console.WriteLine(editor.GetContent());
            editor.Restore(history.Undo());
            Console.WriteLine(editor.GetContent());
        }

    }
}
