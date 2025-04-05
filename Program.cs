using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Observer;
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

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookCollection bookCollection = new BookCollection();
            Book book1 = new Book("Book 1");
            Book book2 = new Book("Book 2");
            Book book3 = new Book("Book 3");
            bookCollection.AddBook(book1);
            bookCollection.AddBook(book2);
            bookCollection.AddBook(book3);
            IBookIterator iterator = bookCollection.CreateIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next().Title);
            }
        }

    }
}
