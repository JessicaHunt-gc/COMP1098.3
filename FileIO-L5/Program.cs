using System;
using System.Collections.Generic;
using System.IO;
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

            students.Clear();

            bool firstLine = true;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("output.csv"))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(firstLine)
                        {
                            firstLine = false;
                            continue;
                        }
                        string[] elements = line.Split(',');
                        DateTime DoB = DateTime.Parse(elements[2]);
                        int ID = Int32.Parse(elements[3]);
                        Student s = new Student(elements[0], elements[1], DoB, ID);
                        students.Add(s);

                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
