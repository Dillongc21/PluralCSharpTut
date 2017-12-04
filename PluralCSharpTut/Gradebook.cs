using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Gradebook
    {
        // Static Properties

        public static float MaxGrade = 100;
        public static float MinGrade = 0;

        // Private Properties
        private string _name;

        // Delegates
        public NameChangedDelegate NameChanged;

        // Public Constructor, Mutators, and Accessors

        public Gradebook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    if(_name != value)
                    {
                        NameChanged(_name, value);
                    }

                    _name = value;
                }
            }
        }

        public GradeStatistics ComputeStatistics()
        {
            
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

        // Private Data

        List<float> grades;
    }
}
