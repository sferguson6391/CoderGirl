using System;

namespace CG_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //statement: a complete "thought" that acts as instructions for the compiler to execute
            Console.WriteLine("What is your name?");

            //expression: a fragment of code that contains a value, name, operator(s), or operand(s) but cannot execute a function by itself
            string userName = Console.ReadLine();

            //operator: a "verb" that acts on operands in order to have an action occur
            //operand: a "noun" that is the subject of code, usually what we name ourselves, like objects and variables
            Console.WriteLine("Hello " + userName + "!");
            Console.ReadLine();
            //operator examples: ( ) + ;
            //operand examples: Console userName
        }
    }
}
