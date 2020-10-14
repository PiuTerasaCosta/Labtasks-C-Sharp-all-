using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello" );
            Console.WriteLine("Piu Terasa Costa");
            int a = 12;
            int b = 6;
            Console.WriteLine("Sum of a & b :" + (a+b));
            Console.WriteLine("division:" + (a / b));
            Console.WriteLine(-5 + 8 * 6);
            Console.WriteLine((55 + 9) % 9);
            Console.WriteLine(20 + -3 * 5/8);
            Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);
            float c = 100;
            float d = 4;
            Console.WriteLine("sum:" + (c + d) + "  sub:" + (c - d) + "   mul:" + (c * d) + "  div:" + (c / d) + "  remainder:" + (c % d));
            Console.WriteLine((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            double w = 5.6;
            double h = 8.5;
            Console.WriteLine("area is:" + (w * h) + "  &" + "  Perimeter:" + (2 * (w + h)));


        }
    }
}
