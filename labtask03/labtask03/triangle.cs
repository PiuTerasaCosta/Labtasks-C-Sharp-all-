using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask03
{
    class triangle
    {
        int x;
        int y;
        int z;
         public int getX (int X)
        {
            return x;
        }
        public void setX ( int X )
        {
            x = X;
        }
        public int getY ()
        {
            return y;
        }
        public void setY (int Y)
        {
            y = Y;
        }
        public int getZ ()
        {
            return z;
        }
        public void setZ ( int Z )
        {

            z = Z;
        }
        public void showinfo()
        {
            Console.WriteLine("X " + x);
            Console.WriteLine("Y" + y);
            Console.WriteLine("Z " + z);

        }
        public void TestTriangle ()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Equilateral ");

            }
            else if ( x==y || y==z || z==x )
                    {
                Console.WriteLine("isosceles ");

            }
            else
            {
                Console.WriteLine("scalene ");
            }
        }











    }
}
