using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface IFileVisitor
    {
        void Visit(AudioFile audioFile);
        void Visit(TextFile textFile);
    }
}
