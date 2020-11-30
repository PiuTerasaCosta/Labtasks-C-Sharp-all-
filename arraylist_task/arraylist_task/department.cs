using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_task
{
    class department
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
        ArrayList faculties;
        public department()
        {
            faculties = new ArrayList();
        }
        public department(string name, string id)
        {
            this.name = name;
            this.id = id;
            faculties = new ArrayList();
        }
        public void AddFaculty(params faculty[] faculties)
        {
            foreach (faculty f in faculties)
            {
                this.faculties.Add(f);
            }
        }
        public void ShowAllFaculties()
        {
            foreach (faculty f in this.faculties)
            {
                f.ShowInfo();
            }
        }
        public faculty SearchFaculty(string id)
        {
            faculty t = null;
            foreach (faculty f in faculties)
            {
                if (f.Id.Equals(id))
                {
                    t = f;
                }
            }
            return t;
        }
        public void DelateFaculty(faculty f)
        {
            faculties.Remove(f);
        }
        public void ShowInfo()
        {
            Console.WriteLine("Department Name : " + name);
            Console.WriteLine("Department ID : " + id);
            Console.WriteLine(" ");
        }

    }
}
