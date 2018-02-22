using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiS
{
    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());


            //CollegeProgram cp = new CollegeProgram("Computer Programmer", CollegeProgram.CollegeCredentials.Diploma, 3);
            //CollegeProgram paralegal = new CollegeProgram("Paralegal", CollegeProgram.CollegeCredentials.Certificate, 1);



            //IPerson CEO = new Staff("Jane", "Doe","CEO",1000000,DateTime.Parse("Jan 6, 2010"),null);
            //Staff vp = new Staff("John", "Doe", "VP", 500000, DateTime.Parse("Jan 25, 2013"), (Staff)CEO);
            //    //new Student("John", "Doe", DateTime.Now);
            //Console.WriteLine("Name: " + CEO.FirstName + " " + CEO.LastName);
            //Console.WriteLine("ID: " + CEO.ID.ID);
            //Console.WriteLine("Name: " + vp.FirstName + " " + vp.LastName);
            //Console.WriteLine("ID: " + vp.ID.ID);
            //if (CEO is Staff)
            //{
            //    Staff s = (Staff)CEO;
            //    Console.WriteLine("Salary: $" + s.Salary);
            //}
            //if (CEO is Student)
            //{
            //    Student s = (Student)CEO;
            //    Console.WriteLine(s.DateOfBirth);
            //}
            //Console.ReadLine();
        }
    }
}
