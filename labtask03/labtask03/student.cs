using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask03
{
    class student
    {
        String name;
        String id;
        String department;
        float cgpa;
        public string getName ()
        {
            return name;
        }
        public void setName ( String Name)
        {
            name = Name;
        }
        public string getId ()
        {
            return id;
        }
        public void setId ( String Id )
        {
            id = Id;
        }
        public string getDep ()
        {
            return department;
        }
        public void setDep ( String Dep)
        {
            department = Dep;
        }
        public float getCgpa ()
        {
            return cgpa;
        }
        public void setCgpa ( float Cgpa ) 
        {
            cgpa = Cgpa;
        }
        public void showinfo()
        {
            Console.WriteLine("NAME:" + name);
            Console.WriteLine("ID :" + id);
            Console.WriteLine("DEPARTMENT :" + department);
            Console.WriteLine ("CGPA: " +cgpa) ;

        }
    }
}
