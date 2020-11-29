using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask08
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator calcu = new calculator();
            Console.WriteLine(" Sum = " + calcu.sum(10, 5));
            Console.WriteLine(" Sub = " + calcu.sub(10, 5));
            Console.WriteLine(" Division = " + calcu.division(25,5));
            Console.WriteLine(" Multiplication = " + calcu.multiplication(10, 5));
            Console.WriteLine(" Division = " + calcu.division(10, 5));
            Console.WriteLine(" Power = " + calcu.XtoY(10, 5));
            Console.WriteLine(" Factorial = " + calcu.factorial(5));


        }
    }
}
