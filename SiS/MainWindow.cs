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
        List<Student> studentList = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateStudent_Click(object sender, EventArgs e)
        {
            CreateStudent createStudentForm = new CreateStudent();
            createStudentForm.StudentCreated += CreateStudentForm_StudentCreated;
            createStudentForm.Show();
        }

        private void CreateStudentForm_StudentCreated(object sender, Student e)
        {
            if(e!=null)
                studentList.Add(e);
        }
    }
}
