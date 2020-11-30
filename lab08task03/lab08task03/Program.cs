using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ipod : ");
            Ipod ip = new Ipod();

            ip.Switch(true);
            ip.Play(true);
            ip.PlayNext();
            ip.PlayPrevious();
            ip.SetVolume(50);

            Console.WriteLine();

            Console.WriteLine("Phone : ");
            Phone ph = new Phone();

            ph.Switch(true);
            ph.Retune(44.9);
            ph.SetVolume(49);
            ph.ChangeChannel();

            Console.WriteLine();

        }
    }
}
