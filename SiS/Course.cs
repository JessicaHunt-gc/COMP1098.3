﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    public class Course
    {
        public String Name { get; private set; }
        public String Subject { get; private set; }
        public String Number { get; private set; }
        public int Capacity { get; private set; }

        public List<CollegeProgram> Programs { get; private set; }

        public Course(String name,String subject,String number,int capacity,CollegeProgram primaryProgram)
        {
            Name = name;
            Subject = subject;
            Number = number;
            Capacity = capacity;
            Programs = new List<CollegeProgram>();
            Programs.Add(primaryProgram);
            primaryProgram.addCourse(this);
        }
    }
}
