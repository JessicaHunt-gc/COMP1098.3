﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{

    public class CollegeProgram
    {
        public enum CollegeCredentials { Certificate, Diploma, Degree}
        public String Name { get; private set; }
        public CollegeCredentials Credential { get; private set; }
        public int Years { get; private set; }

        private List<Student> students { get; set; }
        private List<Course> courses { get; set; }

        public CollegeProgram(String name, CollegeCredentials credential, int years)
        {
            Name = name;
            Credential = credential;
            Years = years;
            students = new List<Student>();
            courses = new List<Course>();
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public List<Course> GetCourses()
        {
            return courses;
        }
        public void addCourse(Course c)
        {
            if(c!=null)
                courses.Add(c);
        }
    }
}
