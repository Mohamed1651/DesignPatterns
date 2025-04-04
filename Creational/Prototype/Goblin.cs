using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Goblin : Enemy, IPrototype<Goblin>
    {
        public Goblin(string name, int health, int damage) : base(name, health, damage)
        {
        }

        public override Goblin Clone()
        {
            return (Goblin) this.MemberwiseClone();
        }
    }
}
