using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08task03
{
    class Phone : IMusicPlayer, IRadioPlayer
    {
        
        
            public void ChangeChannel()
            {
                Console.WriteLine("Changing Channel");
            }

            public void Play(bool on)
            {
                Console.WriteLine("Playing Music");
            }

            public void PlayNext()
            {
                Console.WriteLine("Playing Next Music");
            }

            public void PlayPrevious()
            {
                Console.WriteLine("Playing Previous Music");
            }

            public void Retune(double frequency)
            {
                Console.WriteLine("Retuning to " + frequency);
            }

            public void SetVolume(int loudness)
            {
                Console.WriteLine("Setting volume to " + loudness);
            }

            public void Switch(bool on)
            {
                Console.WriteLine("Turning switch ON");
            }
    }

}

