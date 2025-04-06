using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
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
            IChatRoomMediator chatRoom = new ChatRoom();

            User user1 = new User("User1", chatRoom);
            User user2 = new User("User2", chatRoom);
            user1.Send("Hello User2");
            user2.Send("Hello User1");
        }

    }
}
