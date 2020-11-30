using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08task03
{
    class Ipod: IMusicPlayer
    {
        public void Play(bool on)
        {
            Console.WriteLine("Playing Music");
        }
        public void Switch(bool on)
        {
            Console.WriteLine("Turning switch ON");
        }
        public void PlayNext()
        {
            Console.WriteLine("Playing Next Music");
        }

        public void PlayPrevious()
        {
            Console.WriteLine("Playing Previous Music");
        }

        public void SetVolume(int loudness)
        {
            Console.WriteLine("Setting volume to " + loudness);
        }

    }
}
