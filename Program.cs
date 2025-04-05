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
            CardFactory cardFactory = new CardFactory();
            Card card1 = cardFactory.GetCard(Rank.Ace, Suit.Hearts);
            Card card2 = cardFactory.GetCard(Rank.Queen, Suit.Spades);
            Card card3 = cardFactory.GetCard(Rank.Ace, Suit.Hearts);
            card1.Display();
            Console.WriteLine(Object.ReferenceEquals(card1, card3));
            Console.WriteLine(Object.ReferenceEquals(card1, card2));
        }

    }
}
