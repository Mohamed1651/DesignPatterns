using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("You have created a Windows checkbox.");
        }
    }
}
