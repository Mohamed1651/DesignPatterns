using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class PriceLogger : IObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine($"Price logged: {price}");
        }
    }
}
