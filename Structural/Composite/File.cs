using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class File : FileSystemItem
    {
        private int size;
        public File(string name, int size) : base(name)
        {
            this.size = size;
        }

        public override int GetSize()
        {
            return size;
        }
    }
}
