using System;
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
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade = " + stats.AvgGrade);
            Console.WriteLine("Highest Grade = " + stats.HighGrade);
            Console.WriteLine("Lowest Grade = " + stats.LowGrade);
        }
    }
}