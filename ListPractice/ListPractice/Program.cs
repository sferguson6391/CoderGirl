using System;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //I want to create a collection of students
            ClassExercise classExercise = new ClassExercise();
            classExercise.Run();
            Console.Write("Press enter to exit");
            Console.ReadLine();

        }
    }
}
