using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Grades
{
    public class Gradebook
    {

        // Public Constructor, Modifiers, and Accessors

        public Gradebook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        // Static Members

        public static float MaxGrade = 100;
        public static float MinGrade = 0;

        // Private Data

        List<float> grades;
    }
}
