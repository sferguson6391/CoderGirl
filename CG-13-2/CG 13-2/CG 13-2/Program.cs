using System;
using System.Collections.Generic;
using System.Linq;

namespace CG_13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Sarah", "Park", 12, 4.0M));
            studentList.Add(new Student("Jared", "Park", 11, 2.0M));
            studentList.Add(new Student("Kendra", "Kuhl", 10, 4.0M));
            studentList.Add(new Student("Scott", "Kuhl", 9, 2.5M));
            studentList.Add(new Student("Jane", "Doe", 8, 3.5M));
            studentList.Add(new Student("Ryan", "Ferguson", 7, 3.0M));
            studentList.Add(new Student("Kathy", "Jones", 11, 4.0M));
            studentList.Add(new Student("Lucy", "Park", 5, 3.5M));
            studentList.Add(new Student("Maggie", "Park", 10, 3.7M));
            studentList.Add(new Student("Sophie", "Simpson", 3, 2.0M));

            var students = (studentList.Where(s => s.GPA >= 3.0M && s.Grade >= 9)
                            .OrderBy(s => s.Grade)
                            .ThenBy(s => s.GPA)
                            .ThenBy(s => s.LastName)
                            .ThenBy(s => s.FirstName)
                            .ToList());

            students.Reverse();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName}, {student.LastName}, {student.Grade}, {student.GPA}");
            }
            Console.ReadLine();
        }
    }
}
