using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiS;
namespace FileIO_L5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for (int x = 0; x < 10; x++)
            {
                Student s = new Student("John", "Doe"+x, new DateTime(1980, 11, 01));
                students.Add(s);
            }
            String header = "FirstName,LastName,DateOfBirth,ID";
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("output.csv"))
            {
                file.WriteLine(header);
                foreach (Student s in students)
                {
                    //https://github.com/justinhuntgc/COMP1098.3
                    String line = s.FirstName.Replace(",","") + "," + s.LastName.Replace(",", "") + "," +
                        s.DateOfBirth.ToShortDateString() + "," + s.ID.ID;
                    file.WriteLine(line);
                }
            }


        }
    }
}
