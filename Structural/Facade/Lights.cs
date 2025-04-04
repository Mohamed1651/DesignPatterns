using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Lights
    {
        public void Dim() => Console.WriteLine("Lights Dimmed");
        public void On() => Console.WriteLine("Lights On");
    }
}
