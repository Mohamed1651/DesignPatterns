using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class FileLogger : Logger
    {
        protected override bool CanHandle(LogLevel level)
        {
            return level == LogLevel.Error;
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"File Logger: {message}");
        }
    }
}
