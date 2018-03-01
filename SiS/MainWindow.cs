using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiS
{
    public partial class MainWindow : Form
    {

        DataModel m;
        public MainWindow()
        {
            InitializeComponent();
            Load += MainWindow_Load;
            ProgramGrid.DoubleClick += ProgramGrid_DoubleClick;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Load our data model and prime some data...
            m = new DataModel();
            var ComputerProgrammer = new CollegeProgram("Computer Programmer", CollegeProgram.CollegeCredentials.Diploma, 3);
            m.Programs.Add(ComputerProgrammer);
            m.Programs.Add(new CollegeProgram("Paralegal", CollegeProgram.CollegeCredentials.Certificate, 1));



            IPerson CEO = new Staff("Jane", "Doe", "CEO", 1000000, DateTime.Parse("Jan 6, 2010"), null);
            Staff vp = new Staff("John", "Doe", "VP", 500000, DateTime.Parse("Jan 25, 2013"), (Staff)CEO);

            m.People.Add(CEO);
            m.People.Add(vp);


            Course c = new Course("Intro to C#", "COMP", "1098", 35, ComputerProgrammer);
            c.registerInstructor(vp);
            Student s = new Student("Tim", "Cook", new DateTime(1960, 11, 01));
            c.registerStudent(s);
            
            m.Courses.Add(c);
            m.People.Add(s);
            s = new Student("Steve", "Jobs", new DateTime(1955, 02, 24));
            c.registerStudent(s);
            m.People.Add(s);

            

            UpdatePersonGridData();
            UpdateProgramGridData();
            UpdateCourseGridData();
            
        }

        private void ProgramGrid_DoubleClick(object sender, EventArgs e)
        {
            
            MessageBox.Show(ProgramGrid.SelectedRows[0].Cells["NameCol"].Value.ToString());
        }

        private void CreateStudent_Click(object sender, EventArgs e)
        {
            CreateStudent createStudentForm = new CreateStudent(m);
            createStudentForm.StudentCreated += CreateStudentForm_PersonCreated;
            createStudentForm.Show();
        }

        private void CreateStudentForm_PersonCreated(object sender, IPerson e)
        {
            if (e != null)
            {
                m.People.Add(e);
                ((Form)sender).Hide(); //Hide the form that triggered this event
                UpdatePersonGridData(); //Update the data grid with the new person we created...
                UpdateCourseGridData();
            }
        }
        private void UpdatePersonGridData()
        {
            StudentGridView.Rows.Clear();
            foreach (IPerson p in m.People)
            {
                //full refresh of grid data to ensure accuracy
                int rowid = StudentGridView.Rows.Add();
                DataGridViewRow r = StudentGridView.Rows[rowid];
                r.Cells["PersonID"].Value = p.ID.ID;
                r.Cells["FirstName"].Value = p.FirstName;
                r.Cells["LastName"].Value = p.LastName;
                if (p is Staff)
                    r.Cells["Type"].Value = "Staff";
                else if (p is Student)
                    r.Cells["Type"].Value = "Student";

             
            }
        }

        private void UpdateProgramGridData()
        {
            ProgramGrid.Rows.Clear();
            foreach (CollegeProgram p in m.Programs)
            {
                //full refresh of grid data to ensure accuracy
                int rowid = ProgramGrid.Rows.Add();
                DataGridViewRow r = ProgramGrid.Rows[rowid];

                r.Cells["NameCol"].Value = p.Name;
                r.Cells["Credential"].Value = Enum.GetName(typeof(CollegeProgram.CollegeCredentials), p.Credential);
                r.Cells["Years"].Value = p.Years;
                r.Cells["Courses"].Value = p.GetCourses().Count;
            }
        }

        private void UpdateCourseGridData()
        {
            CourseGrid.Rows.Clear();
            foreach (Course p in m.Courses)
            {
                //full refresh of grid data to ensure accuracy
                int rowid = CourseGrid.Rows.Add();
                DataGridViewRow r = CourseGrid.Rows[rowid];

                r.Cells["CourseName"].Value = p.Name;
                r.Cells["Subject"].Value = p.Subject;
                r.Cells["Number"].Value = p.Number;
                r.Cells["Capacity"].Value = p.Capacity;
                r.Cells["Registered"].Value = (p.students.Count);
            }
        }


        private void CreateStaff_Click(object sender, EventArgs e)
        {
            CreateStaff cs = new CreateStaff(m);
            cs.StaffCreated += CreateStudentForm_PersonCreated;            
            cs.Show();
        }

    }
}
