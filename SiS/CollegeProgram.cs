using System;
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

        public CollegeProgram(String name, CollegeCredentials credential, int years)
        {
            Name = name;
            Credential = credential;
            Years = years;
        }
    }
}
