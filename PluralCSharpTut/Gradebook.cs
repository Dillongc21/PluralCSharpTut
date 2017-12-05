using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Gradebook : GradeTracker
    {
        // Static Properties

        public static float MaxGrade = 100;
        public static float MinGrade = 0;

        // Protected Properties

        protected List<float> grades; // protected == derived classes can use

        public override void WriteGrades(TextWriter destination)
        {
            //for (int i = grades.Count; i > 0; i--)
            //{
            //    destination.WriteLine(grades[i-1]);
            //}
            foreach (float grade in grades)
            {
                destination.WriteLine(grade);
            }
        }

        // Public Constructor, Mutators, and Accessors

        public Gradebook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("Gradebook::ComputeStatistics");

            GradeStatistics stats = new GradeStatistics();

            // Calculate Avg
            float sum = 0;
            foreach (float grade in grades)
            {
                sum += grade;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }
            stats.AverageGrade = sum / grades.Count();

            return stats;
        }
    }
}
