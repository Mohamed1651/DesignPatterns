using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class PdfDocumentProcessor : DocumentProcessor
    {
        protected override void ParseContent()
        {
            Console.WriteLine("Parsing PDF content...");
        }
    }
}
