using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class LazyLogger
    {
        private static readonly Lazy<LazyLogger> _instance = new Lazy<LazyLogger>(() => new LazyLogger());
        public static LazyLogger Instance => _instance.Value;

        private LazyLogger()
        {
            Console.WriteLine("Logger instance created (Lazy)");
        }
    }
}
