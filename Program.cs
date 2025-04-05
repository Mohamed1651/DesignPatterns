using DesignPatterns.Behavioral.Command;
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
            DocumentProcessor pdfProcessor = new PdfDocumentProcessor();
            pdfProcessor.ProcessDocument("example.pdf");
            DocumentProcessor wordProcessor = new WordDocumentProcessor();
            wordProcessor.ProcessDocument("example.docx");
        }

    }
}
