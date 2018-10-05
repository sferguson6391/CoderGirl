using System;
using System.IO;

namespace CG_11_2
{
    internal class Student
    {
        public string Name { get; set; }
        public decimal Grades { get; set; }
        public decimal AverageGrade { get; set; }

        public Student(string name, decimal grades, decimal averageGrade)
        {
            Name = name;
            Grades = grades;
            AverageGrade = averageGrade;
        }
    }
}