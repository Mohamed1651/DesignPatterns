
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class DocumentProcessor
    {
        public void ProcessDocument(string document)
        {
            Open();
            ParseContent();
            Close();
        }

        protected void Open()
        {
            Console.WriteLine("Opening document...");
        }

        protected abstract void ParseContent();

        protected void Close()
        {
           Console.WriteLine("Closing document...");
        }
    }
}
