using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class VirusScanner : IFileVisitor
    {
        public void Visit(AudioFile audioFile)
        {
            Console.WriteLine($"Scanning audio file: {audioFile.FileName}");
        }

        public void Visit(TextFile textFile)
        {
            Console.WriteLine($"Scanning text file: {textFile.FileName}");
        }
    }
}
