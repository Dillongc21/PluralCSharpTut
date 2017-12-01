using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Grades
{
    public class Gradebook
    {

        // Public Constructor, Mutators, and Accessors

        public Gradebook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name;

        public GradeStatistics ComputeStatistics()
        {
            
            GradeStatistics stats = new GradeStatistics();

            // Calculate Avg
            float sum = 0;
            foreach (float grade in grades)
            {
                sum += grade;
                stats.HighGrade = Math.Max(grade, stats.HighGrade);
                stats.LowGrade = Math.Min(grade, stats.LowGrade);
            }
            stats.AvgGrade = sum / grades.Count();

            return stats;
        }

        // Static Members

        public static float MaxGrade = 100;
        public static float MinGrade = 0;

        // Private Data

        List<float> grades;
    }
}
