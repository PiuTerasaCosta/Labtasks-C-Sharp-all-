using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_task
{
    class Program
    {
        static void Main(string[] args)
        {
			faculty f1 = new faculty("Tanvir Ahmed", "234566");
			faculty f2 = new faculty("Kaniz Fatema", "098654");
			department d1 = new department("CSE", "1234");
			d1.ShowInfo();
			d1.AddFaculty(f1, f2);
			d1.ShowAllFaculties();


			var faculty = d1.SearchFaculty("234566");
			if (faculty != null)
			{
				d1.DelateFaculty(faculty);
			}
			Console.WriteLine("delated");
			d1.ShowAllFaculties();

		}
	}
}
