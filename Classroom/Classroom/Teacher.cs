using System;
using System.Collections.Generic;
using System.Text;

namespace Classroom
{
    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Teacher(string name, int Age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}
