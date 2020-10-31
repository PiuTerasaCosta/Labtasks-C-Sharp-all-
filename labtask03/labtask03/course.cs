using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask03
{
    class course
    {
        String coursename;
        String coursecode;
      

        public string getcn()
        {
            return coursename;
        }
        public void setcn(String cn)
        {
            coursename = cn;
        }

       public string getcc()
        {
            return coursecode;
        }
        public void setcc(String cc)
        {
            coursecode = cc;
        }
        
        
        public void showinfo ()
        {
            Console.WriteLine("COURSE NAME :" + coursename);
            Console.WriteLine("COURSE CODE :" + coursecode);
            

        }




        }
}
