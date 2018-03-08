using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
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
                    String line = "\"" + s.FirstName.Replace(",","") + "\"," + s.LastName.Replace(",", "") + "," +
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

            DataModel m = new DataModel();
            var ComputerProgrammer = new CollegeProgram("Computer Programmer", CollegeProgram.CollegeCredentials.Diploma, 3);
            m.Programs.Add(ComputerProgrammer);
            m.Programs.Add(new CollegeProgram("Paralegal", CollegeProgram.CollegeCredentials.Certificate, 1));



            IPerson CEO = new Staff("Jane", "Doe", "CEO", 1000000, DateTime.Parse("Jan 6, 2010"), null);
            Staff vp = new Staff("John", "Doe", "VP", 500000, DateTime.Parse("Jan 25, 2013"), (Staff)CEO);

           // m.People.Add(CEO);
           // m.People.Add(vp);


            Course c = new Course("Intro to C#", "COMP", "1098", 35, ComputerProgrammer);
            c.registerInstructor(vp);
            Student s2 = new Student("Tim", "Cook", new DateTime(1960, 11, 01));
            c.registerStudent(s2);

            m.Courses.Add(c);
            m.People.Add(s2);
            s2 = new Student("Steve", "Jobs", new DateTime(1955, 02, 24));
            c.registerStudent(s2);
            m.People.Add(s2);

            byte[] serializedData = DataModel.serialize<DataModel>(m);
            File.WriteAllBytes("Output.dat", serializedData);
            Console.ReadLine();

            //XmlSerializer xml = new XmlSerializer(typeof(DataModel));
            //MemoryStream memStream = new MemoryStream();

            //xml.Serialize(memStream, m);
            //memStream.Seek(0, SeekOrigin.Begin);
            //String xmlOut = memStream.ToString();

            XDocument doc = new System.Xml.Linq.XDocument(
                new XElement("SIS"));
            

        }
    }
}
