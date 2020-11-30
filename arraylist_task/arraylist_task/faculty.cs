using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_task
{
    class faculty
    {
        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;


        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public faculty()
        {
        }
        public faculty(string name, string id)
        {
            this.name = name;
            this.id = id;


        }
        public void ShowInfo()
        {
            Console.WriteLine("Faculty Name : " + name);
            Console.WriteLine("Faculty ID : " + id);
            Console.WriteLine(" ");
        }

    }
}
