using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public abstract class FileSystemItem
    {
        public string Name { get; set; }
        public FileSystemItem(string name)
        {
            Name = name;
        }

        public abstract int GetSize();
    }
}
