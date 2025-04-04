using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Windows Button");
        }
    }
}
