using System;
using System.Collections.Generic;
using System.Text;

namespace Classroom
{
    class Classroom
    {
        Student[] students = new Student[3];
        Teacher teacher = new Teacher( "Sarah", 27, "female" );

        public string RollCall()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(students);
            Console.ReadLine();
        }

        public string GradeDistribution(int grade)
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else return "F";
        }
    }
}
