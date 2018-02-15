using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    class Program
    {
        static void Main(string[] args)
        {

            IPerson staff = new Staff("Jane", "Doe","CEO",1000000,DateTime.Parse("Jan 6, 2010"),null);
            Staff vp = new Staff("John", "Doe", "VP", 500000, DateTime.Parse("Jan 25, 2013"), (Staff)staff);
                //new Student("John", "Doe", DateTime.Now);
            Console.WriteLine("Name: " + staff.FirstName + " " + staff.LastName);
            if(staff is Staff)
            {
                Staff s = (Staff)staff;
                Console.WriteLine("Salary: $" + s.Salary);
            }
            if (staff is Student)
            {
                Student s = (Student)staff;
                Console.WriteLine(s.DateOfBirth);
            }
            Console.ReadLine();
        }
    }
}
