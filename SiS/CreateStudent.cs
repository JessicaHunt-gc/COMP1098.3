using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace SiS
{
    public partial class CreateStudent : Form
    {
        private DataModel m;
        public event EventHandler<Student> StudentCreated;
        public CreateStudent()
        {
            InitializeComponent();
            
            Load += CreateStudent_Load;
        }
        public CreateStudent(DataModel m) : this()
        {
            this.m = m;
        }

        public class CourseBoxItem
        {
            public string Text { get; set; }
            public Course Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {

            //place code to run on loading of this form...
            foreach (Course c in m.Courses) {
                AvailableCourses.Items.Add(new CourseBoxItem()
                {
                    Text = c.Subject + c.Number,
                    Value = c
                });
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DateTime dob = DateTime.Parse(DoB.Text);
            Student s = new Student(FirstName.Text, LastName.Text, dob);
            foreach (CourseBoxItem cbi in RegisteredCourses.Items)
                cbi.Value.registerStudent(s);
            StudentCreated?.Invoke(this, s);
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            if (AvailableCourses.SelectedItem != null)
            {
                var selected = ((CourseBoxItem)AvailableCourses.SelectedItem);
                RegisteredCourses.Items.Add(selected);
                AvailableCourses.Items.Remove(selected);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void RemoveCourse_Click(object sender, EventArgs e)
        {
            if (RegisteredCourses.SelectedItem != null)
            {
                var selected = ((CourseBoxItem)RegisteredCourses.SelectedItem);
                AvailableCourses.Items.Add(selected);
                RegisteredCourses.Items.Remove(selected);
            }
        }
    }
}
