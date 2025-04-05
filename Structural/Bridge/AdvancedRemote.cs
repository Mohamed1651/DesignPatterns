using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device) {}

        public void Mute()
        {
            Console.WriteLine("Device muted");
        }
    }
}
