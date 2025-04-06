using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class Logger
    {
        protected Logger next;

        public void SetNext(Logger next)
        {
            this.next = next;
        }

        public void Log(LogLevel level, string message)
        {
            if (CanHandle(level))
            {
                Write(message);
            }
            else if (next != null)
            {
                next.Log(level, message);
            }
        }

        protected abstract bool CanHandle(LogLevel level);
        protected abstract void Write(string message);
    }
}
