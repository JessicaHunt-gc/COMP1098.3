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
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DateTime dob = DateTime.Parse(DoB.Text);
            Student s = new Student(FirstName.Text, LastName.Text, dob);
            
            progressBar1.Maximum = 100;
            for (int x = 0; x < 10; x++)
            {
                progressBar1.Increment(10);
                Thread.Sleep(1000);
            }
            StudentCreated?.Invoke(this, s);
        }
    }
}
