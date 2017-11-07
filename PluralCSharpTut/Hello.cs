using System;

namespace PluralCSharpTut
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Prompt for name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //Hello Message
            Console.WriteLine("Hello, " + name);
        }
    }
}
