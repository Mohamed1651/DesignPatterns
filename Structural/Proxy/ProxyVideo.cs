using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class ProxyVideo : IVideo
    {
        private string _filename;
        private RealVideo _realVideo;
        public ProxyVideo(string filename)
        {
            _filename = filename;
        }

        public void Play()
        {
            if (_realVideo == null)
            {
                _realVideo = new RealVideo(_filename);
            }
            _realVideo.Play();
        }
    }
}
