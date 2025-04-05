using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class TV : IDevice
    {
        private bool _on = false;

        public bool IsEnabled()
        {
            return _on;
        }

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }
    }
}
