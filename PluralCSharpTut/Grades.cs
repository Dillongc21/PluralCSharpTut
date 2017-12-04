﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Grades
{
    class Program
    {

        static void Main(string[] args)
        {
            Gradebook book = new Gradebook();

            book.NameChanged += OnNameChanged; // add subscriber to event

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.Name = "Dillon's Grade Book";
            book.Name = "Grade Book";
            book.Name = null;

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResult("Average Grade", stats.AverageGrade);
            WriteResult("Highest Grade", (int)stats.HighestGrade);
            WriteResult("Lowest Grade", (int)stats.LowestGrade);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade Book changing name from {args.ExistingName} to {args.NewName}...");
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}