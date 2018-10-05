using System;
using System.Collections.Generic;
using System.Text;

namespace ListPractice
{
    public class ClassExercise
    {
        public void Run()
        {
            List<Student> students = CreateStudentList();

            //PrintID(students);
            //PrintName(students);
            //PrintStudent(students);

            //add a new item to the list
            /*Student newStudent = new Student(5, "Maggie", 3, 2.0F);
            students.Insert(1, newStudent);
            PrintStudent(students);*/

            Dictionary<string, Student> classRoster = new Dictionary<string, Student>();
            classRoster.Add("CoderGirl", new Student(8, "Sarah", 27, 4.0F));
            classRoster.Add("Math", new Student(9, "Maddy", 22, 3.0F));

            Console.WriteLine(classRoster["Math"]);
        }

        private void PrintStudent(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        private void PrintName(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

        private void PrintID(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.ID);
            }
        }

        private List<Student> CreateStudentList()
        {
            Student student1 = new Student(1, "Sarah", 27, 4.0F);
            Student student2 = new Student(2, "Scott", 30, 2.5F);
            Student student3 = new Student(3, "Kendra", 21, 4.0F);
            Student student4 = new Student(4, "Lucy", 22, 3.5F);

            //array example
            //Student[] studentArray = new Student[] { student1, student2, student3, student4 };

            //long way
            //List<Student> students = new List<Student> { student1, student2, student3, student4 };
            //return students;

            //short way
            return new List<Student> { student1, student2, student3, student4 };

            //another way to add students to the list
            /*List<Student> students2 = new List<Student>();
            students2.Add(student1);
            students2.Add(student2);
            students2.Add(student3);
            students2.Add(student4);*/


        }


    }
}
