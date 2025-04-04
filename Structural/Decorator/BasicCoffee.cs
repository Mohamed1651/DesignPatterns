using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class BasicCoffee : ICoffee
    {
        public double GetCost()
        {
            return 2.0;
        }

        public string GetDescription()
        {
            return "Basic Coffee";
        }
    }
}
