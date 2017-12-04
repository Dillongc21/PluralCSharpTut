using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass()]
    public class GradebookTest
    {
        [TestMethod()]
        public void ComputesHighGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(10);
            book.AddGrade(90);
            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(stats.HighGrade, 90);
        }

        [TestMethod()]
        public void ComputesLowGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(10);
            book.AddGrade(90);
            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(stats.LowGrade, 10);
        }

        [TestMethod()]
        public void ComputesAvgGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(stats.AvgGrade, 85.166, 0.001);
        }
    }
}
