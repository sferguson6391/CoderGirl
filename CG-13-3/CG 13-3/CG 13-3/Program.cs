using System;

namespace CG_13_3
{
    class Program
    {
        public enum Students {
            Sarah, Jared, Lucy, Maggie, Carol, Ali, Hunter, Ryan, Sophie, Marie }

        static void Main(string[] args)
        {
            Console.Write("Enter the student's first name: ");
            string student = Console.ReadLine();
            Students students = (Students)Enum.Parse(typeof(Students), student);
            switch (students)
            {
                case (Students.Sarah):
                    Console.WriteLine("Park");
                    break;
                case (Students.Jared):
                    Console.WriteLine("Park");
                    break;
                case (Students.Lucy):
                    Console.WriteLine("Park");
                    break;
                case (Students.Maggie):
                    Console.WriteLine("Park");
                    break;
                case (Students.Carol):
                    Console.WriteLine("Simpson");
                    break;
                case (Students.Ali):
                    Console.WriteLine("York");
                    break;
                case (Students.Hunter):
                    Console.WriteLine("Park");
                    break;
                case (Students.Ryan):
                    Console.WriteLine("Ferguson");
                    break;
                case (Students.Sophie):
                    Console.WriteLine("Park");
                    break;
                case (Students.Marie):
                    Console.WriteLine("Ferguson");
                    break;
            }
            Console.ReadLine();
        }
    }
}
