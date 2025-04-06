using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class TextFile : IFile
    {
        public string FileName { get; set; }

        public TextFile(string fileName)
        {
            FileName = fileName;
        }

        public void Accept(IFileVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
