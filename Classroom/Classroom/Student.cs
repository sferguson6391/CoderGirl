using System;
using System.Collections.Generic;
using System.Text;

namespace Classroom
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public Student (string name, string gender, int age, string grade)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Grade = grade;
        }

    }
}
