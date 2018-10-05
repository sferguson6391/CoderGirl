using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CG_11_1
{
    public class StudentList
    {
        public void Run()
        {
            GetStudents();
            Console.ReadLine();
        }

        public void GetStudents()
        {

            List<Student> students = new List<Student>();
            string line;
            int numberOfGrades = 0;
            StreamReader file = new StreamReader(@"C:\Users\Jared\Source\Repos\CG-11-1\CG 11-1\CG 11-1\StudentList.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] lines = line.Split(" ");
                numberOfGrades = lines.Length;
                string studentName = lines[0];
                Student newStudent = new Student(studentName, numberOfGrades);
                students.Add(newStudent);
            }
            foreach (Student newStudent in students)
            {
                if (newStudent.Grades >= 7)
                    Console.WriteLine(newStudent.Name);
            }
        }
    }
}
