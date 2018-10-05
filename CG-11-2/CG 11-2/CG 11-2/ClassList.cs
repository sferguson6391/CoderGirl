using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CG_11_2
{
    internal class ClassList
    {

        public void Run()
        {
            CreateStudent();
            Console.ReadLine();
        }

        public void CreateStudent()
        {
            List<Student> students = new List<Student>();
            string line;
            StreamReader file = new StreamReader(@"C:\Users\Jared\Source\Repos\CG-11-2\CG 11-2\CG 11-2\StudentList.txt");
            while ((line = file.ReadLine()) != null)
            {
                decimal totalGrades = 0;
                decimal averageGrade = 0;
                string[] lines = line.Split(' ');
                string studentName = lines[0];

                foreach (string grade in lines.Skip(1))
                {
                    int grades = int.Parse(grade);
                    totalGrades = totalGrades + grades;
                }
                averageGrade = totalGrades / (lines.Length-1);

                Student newStudent = new Student(studentName, totalGrades, averageGrade);
                students.Add(newStudent);
            }
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} has an average grade of {student.AverageGrade: .##}");
            }
        }
    }

}