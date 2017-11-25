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
    }
}
