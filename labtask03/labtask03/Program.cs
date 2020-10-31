using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask03
{
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.setName("Piu");
            s.setId("18-38286-2");
            s.setDep("CSE");
            s.setCgpa(4);
            s.showinfo();
            triangle t = new triangle();
            t.setX(5);
            t.setY(5);
            t.setZ(5);
            t.showinfo();
            t.TestTriangle();
            account a = new account();
            a.setAccName("Costa ");
            a.setAcId("4828368bgh");
            a.setBlance(58000);
            a.showinfo();
            a.Deposit(2000);
            a.withdraw(500);
            course c = new course();
            c.setcn(" OOP2");
            c.setcc("12345");
            c.showinfo();

;
            



        }
    }
}
