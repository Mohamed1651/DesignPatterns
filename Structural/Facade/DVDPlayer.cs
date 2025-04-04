using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD Player On");
        public void Play(string movie) => Console.WriteLine($"Playing '{movie}'");
        public void Off() => Console.WriteLine("DVD Player Off");
    }
}
