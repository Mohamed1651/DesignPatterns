using DesignPatterns.Behavioral.Command;
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
            RemoteControl remoteControl = new RemoteControl();
            Light light = new Light();
            ICommand lightOn = new TurnLightOnCommand(light);
            ICommand lightOff = new TurnLightOffCommand(light);

            remoteControl.SetCommand(lightOn);
            remoteControl.PressButton(); // Light is turned on
            remoteControl.PressUndo(); // Light is turned off
            remoteControl.SetCommand(lightOff);
            remoteControl.PressButton(); // Light is turned off
            remoteControl.PressUndo(); // Light is turned on
        }

    }
}
