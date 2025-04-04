using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        public static Logger Instance => _instance;

        private Logger() {
            Console.WriteLine("Logger instance created (Eager)");
        }

    }
}
