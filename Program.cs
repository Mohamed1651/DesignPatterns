using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using File = DesignPatterns.Structural.Composite.File;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            File file1 = new File("file1.txt", 100);
            File file2 = new File("file2.txt", 200);
            Folder folder1 = new Folder("folder1");
            folder1.Add(file1);
            folder1.Add(file2);
            
            Folder root = new Folder("root");
            root.Add(folder1);
            root.Add(new File("file3.txt", 300));

            Console.WriteLine($"Total size of {root.Name}: {root.GetSize()} bytes");
        }

    }
}
