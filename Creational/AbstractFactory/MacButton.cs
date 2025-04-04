using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("You have created MacButton.");
        }
    }
}
