using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;
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

          //  Console.ReadLine();

            DataModel dataModelTest = new DataModel();
            var ComputerProgrammer = new CollegeProgram("Computer Programmer", CollegeProgram.CollegeCredentials.Diploma, 3);
            dataModelTest.Programs.Add(ComputerProgrammer);
            dataModelTest.Programs.Add(new CollegeProgram("Paralegal", CollegeProgram.CollegeCredentials.Certificate, 1));



            IPerson CEO = new Staff("Jane", "Doe", "CEO", 1000000, DateTime.Parse("Jan 6, 2010"), null);
            Staff vp = new Staff("John", "Doe", "VP", 500000, DateTime.Parse("Jan 25, 2013"), (Staff)CEO);

           // m.People.Add(CEO);
           // m.People.Add(vp);


            Course c = new Course("Intro to C#", "COMP", "1098", 35, ComputerProgrammer);
            c.registerInstructor(vp);
            Student s2 = new Student("Tim", "Cook", new DateTime(1960, 11, 01));
            c.registerStudent(s2);

            dataModelTest.Courses.Add(c);
            dataModelTest.People.Add(s2);
            s2 = new Student("Steve", "Jobs", new DateTime(1955, 02, 24));
            c.registerStudent(s2);
            dataModelTest.People.Add(s2);

            byte[] serializedData = DataModel.serialize<DataModel>(dataModelTest);
            File.WriteAllBytes("Output.dat", serializedData);
            // Console.ReadLine();

            //XmlSerializer xml = new XmlSerializer(typeof(DataModel));
            //MemoryStream memStream = new MemoryStream();

            //xml.Serialize(memStream, m);
            //memStream.Seek(0, SeekOrigin.Begin);
            //String xmlOut = memStream.ToString();

            s2.Addresses.Add(new Address("1line1", "Line2", "Toronto", "Ontario", "Canada", AddressTypes.Home, s2));
            s2.Addresses.Add(new Address("2line1", "Line2", "Toronto", "Ontario", "Canada", AddressTypes.Home, s2));
            s2.Addresses.Add(new Address("3line1", "Line2", "Toronto", "Ontario", "Canada", AddressTypes.Home, s2));

            XDocument doc = new XDocument(
                new XElement("SIS",s2.createXMLTree()));

            doc.Save("Output.xml");

            XmlDocument xmlIn = new XmlDocument();
            xmlIn.Load("Output.xml");
            XmlNode n = xmlIn.DocumentElement.FirstChild;
            Console.WriteLine("FirstChild Name: " + n.Name);
            n = n.FirstChild;
            Console.WriteLine("FirstChild Name: " + n.Name);
           // Console.WriteLine("FirstChild Name: " + n.InnerText);
            XmlNodeList list = xmlIn.DocumentElement.SelectNodes("Student");
            foreach(XmlNode node in list)
            {
                Console.WriteLine("FirstChild Name: " + node.FirstChild.InnerText);
            }
            Console.ReadLine();

            String Json = JsonConvert.SerializeObject(dataModelTest, Newtonsoft.Json.Formatting.Indented, 
                new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                PreserveReferencesHandling = PreserveReferencesHandling.All
            });
            Console.WriteLine(Json);

            object o = JsonConvert.DeserializeObject(Json);


            Movie m = new Movie()
            {
                Name = "James bond",
                lengthSec = 3800
            };
            Movie m2 = new Movie()
            {
                Name = "James bond2",
                lengthSec = 3980
            };
            Movie m3 = new Movie()
            {
                Name = "James bond3",
                lengthSec = 3300
            };
            Book b1 = new Book()
            {
                Name = "Book1",
                Author = "Author1"
            };
            Book b2 = new Book()
            {
                Name = "Book2",
                Author = "Author2"
            };
            Book b3 = new Book()
            {
                Name = "Book3",
                Author = "Author3"
            };
            Library l = new Library()
            {
                Movies = new List<Movie>(),
                Books = new List<Book>()
            };
            l.Movies.Add(m);
            l.Movies.Add(m2);
            l.Movies.Add(m3);
            l.Books.Add(b1);
            l.Books.Add(b2);
            l.Books.Add(b3);

            Json = JsonConvert.SerializeObject(l);

            Library deserializedLib = JsonConvert.DeserializeObject<Library>(Json);


        }
    }
}
