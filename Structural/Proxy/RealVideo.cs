using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class RealVideo : IVideo
    {
        public string _filename;

        public RealVideo(string filename)
        {
            _filename = filename;
            LoadVideoFromDisk(); //Simulate heavy loading
        }

        private void LoadVideoFromDisk()
        {
            Console.WriteLine($"Loading video: {_filename} from disk...");
        }

        public void Play()
        {
            Console.WriteLine($"Playing video '{_filename}'");
        }
    }
}
