using NUnit.Framework;
using System;
using Grades;
namespace Grades.Tests
{
    [TestFixture()]
    public class GradebookTest
    {
        [Test()]
        public void ComputesHighGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(10);
            book.AddGrade(90);
            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(stats.HighGrade, 90);
        }

        [Test()]
        public void ComputesLowGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(10);
            book.AddGrade(90);
            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(stats.LowGrade, 10);
        }

        [Test()]
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
