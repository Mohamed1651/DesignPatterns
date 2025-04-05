using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is turned ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is turned OFF");
        }
    }
}
