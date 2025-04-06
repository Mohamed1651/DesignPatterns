using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class EditorMemento
    {
        public string Content { get; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }
}
