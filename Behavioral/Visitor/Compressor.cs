using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Compressor : IFileVisitor
    {
        public void Visit(AudioFile audioFile)
        {
            Console.WriteLine($"Compressing audio file: {audioFile.FileName}");
        }

        public void Visit(TextFile textFile)
        {
            Console.WriteLine($"Compressing text file: {textFile.FileName}");
        }
    }
}
