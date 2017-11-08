using System;

namespace PluralCSharpTut
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt for name

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();


            // Prompt for sleep info

            Console.WriteLine("How many hours of sleep did you get last night?");
            int sleepHours = int.Parse(Console.ReadLine());


            // Hello message

            Console.WriteLine("\nHello, " + name);


            // Sleep logic

            if (sleepHours >= 7)
                Console.WriteLine("You are well rested!");
            else
                Console.WriteLine("Get mo' sleep fool!");
        }
    }
}