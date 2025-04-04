using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class SoundSystem
    {
        public void On() => Console.WriteLine("Sound System On");
        public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}");
        public void Off() => Console.WriteLine("Sound System Off");
    }
}
