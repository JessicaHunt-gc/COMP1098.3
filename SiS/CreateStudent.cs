﻿using System;
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
    public partial class CreateStudent : Form
    {
        public CreateStudent()
        {
            InitializeComponent();            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DateTime dob = DateTime.Parse(DoB.Text);
            Student s = new Student(FirstName.Text, LastName.Text, dob);
        }
    }
}
