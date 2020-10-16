using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int t = 1; t <= 10; t++)
            {
                if (t  % 2 == 0)

                    Console.WriteLine("even number:" + t);
                else
                    Console.WriteLine("odd number:" + t);


            }
            for (int a = 0; a <= 1; a++)
            {
                for (int x = 0; x <= 2; x++)
                {
                    Console.Write("X0");
                }
                Console.WriteLine(" ");
                for (int x = 0; x <= 2; x++)
                {
                    Console.Write("0X");

                }
                Console.WriteLine(" ");
            }
            for (int  q= 1; q <= 5; q++)
            {
                int o = 0;
                for (int k = 1; k <= 5; k++)
                {

                    Console.Write(q + o);
                    o++;
                }
                Console.WriteLine("");
                o++;
            }


            int sum = 0;
            int sumx = 0;
            for (int w = 1; w <= 100; w++)
            {

                if (w % 2 == 0)
                {
                    sum = sum + w;
                }

                if (w % 2 != 0)
                {
                    sumx = sumx + w;
                }

            }
            Console.WriteLine("The sum of Even number:");
            Console.WriteLine(sum);
            Console.WriteLine("The sum of odd number:");
            Console.WriteLine(sumx);

            for (int g = 1; g <= 5; g++)
            {
                Console.WriteLine(g);
                for (int j = 1; j <= g; j++)
                {
                    Console.Write(" ");
                }

            }
            int i, f = 1, n = 5;
            for (i = 1; i <= n; i++)
            {
                f = f * i;

            }
            Console.Write(" Factorial of " + n + " is:  " + f);

            int r;
            for ( r = 1; r <= 5; r++)
            {
                for (int j = 1; j <= r; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(" \n");
            }
            for ( r = 4; r >= 1; r--)
            {
                for (int j = 1; j <= r; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(" \n");
            }
        }

        }
    }
