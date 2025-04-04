using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Projector
    {
        public void On() => Console.WriteLine("Projector On");
        public void Off() => Console.WriteLine("Projector Off");
    }
}
