using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Remote
    {
        protected IDevice _device;

        public Remote(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if (_device.IsEnabled())
            {
                _device.TurnOff();
            }
            else
            {
                _device.TurnOn();
            }
        }
    }
}
