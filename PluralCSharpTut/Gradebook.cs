using System;
using System.Collections.Generic;
using System.IO;
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
        public event NameChangedDelegate NameChanged;

        public void WriteGrades(TextWriter destination)
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
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }

                if (_name != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }

                _name = value;
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
