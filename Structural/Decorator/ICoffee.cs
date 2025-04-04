using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public interface ICoffee
    {
        public string GetDescription();
        public double GetCost();
    }
}
