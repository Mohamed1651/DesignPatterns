using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Folder : FileSystemItem
    {
        private List<FileSystemItem> items = new List<FileSystemItem>();

        public Folder(string name) : base(name) { }

        public void Add(FileSystemItem item)
        {
            items.Add(item);
        }

        public override int GetSize()
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.GetSize();
            }
            return total;
        }
    }
}
