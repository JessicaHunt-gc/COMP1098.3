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
        public event EventHandler<Student> StudentCreated;
        public CreateStudent()
        {
            InitializeComponent();
            
            this.Load += CreateStudent_Load;
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {
            //place code to run on loading of this form...
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DateTime dob = DateTime.Parse(DoB.Text);
            Student s = new Student(FirstName.Text, LastName.Text, dob);
            
            StudentCreated?.Invoke(this, s);
        }
    }
}
