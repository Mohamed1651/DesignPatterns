using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Editor
    {
        private string _content;

        public Editor(){}

        public void Type(string words)
        {
            _content += words;
        }

        public string GetContent()
        {
            return _content;
        }

        public EditorMemento Save()
        {
            return new EditorMemento(_content);
        }

        public void Restore(EditorMemento memento)
        {
            _content = memento.Content;
        }

    }
}
