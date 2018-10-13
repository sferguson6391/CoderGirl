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
            //to use long way remove nameof after case
            //Students students = (Students)Enum.Parse(typeof(Students), student);
            switch (student)
            {
                case nameof(Students.Sarah):
                    Console.WriteLine("Park");
                    break;
                case nameof(Students.Jared):
                    Console.WriteLine("Park");
                    break;
                case nameof(Students.Lucy):
                    Console.WriteLine("Park");
                    break;
                case nameof(Students.Maggie):
                    Console.WriteLine("Park");
                    break;
                case nameof(Students.Carol):
                    Console.WriteLine("Simpson");
                    break;
                case nameof(Students.Ali):
                    Console.WriteLine("York");
                    break;
                case nameof(Students.Hunter):
                    Console.WriteLine("Park");
                    break;
                case nameof(Students.Ryan):
                    Console.WriteLine("Ferguson");
                    break;
                case nameof(Students.Sophie):
                    Console.WriteLine("Park");
                    break;
                case nameof(Students.Marie):
                    Console.WriteLine("Ferguson");
                    break;
            }
            Console.ReadLine();
        }
    }
}
