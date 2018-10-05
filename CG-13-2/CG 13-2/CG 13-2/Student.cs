using System;
using System.Collections.Generic;
using System.Text;

namespace CG_13_2
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public decimal GPA { get; set; }

        public Student(string firstName, string lastName, int grade, decimal gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
            GPA = gpa;
        }
    }
}
