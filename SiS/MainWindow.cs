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
            if (e != null)
            {
                studentList.Add(e);
                DataGridViewRow r = (DataGridViewRow)StudentGridView.Rows[0].Clone();

                r.Cells[0].Value = e.FirstName;
                r.Cells[1].Value = e.LastName;

                StudentGridView.Rows.Add(r);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
