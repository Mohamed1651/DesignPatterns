using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class AudioFile : IFile
    {
        public string FileName { get; set; }

        public AudioFile(string fileName)
        {
            FileName = fileName;
        }

        public void Accept(IFileVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
