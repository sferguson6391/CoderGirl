using System;
using System.Collections.Generic;
using System.Text;

namespace ListPractice
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, int age, float gpa)
        {
            ID = id;
            Name = name;
            Age = age;
            GPA = gpa;
        }

        private Student() { }

        //so that when you print student by itself it prints what you put here - create loop in method where you call it
        public override string ToString()
        {
            return $"{this.Name} is {this.Age} and has a GPA of {this.GPA}";
        }
    }
}
