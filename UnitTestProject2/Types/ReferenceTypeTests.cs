﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        // Private Methods

        private void GiveBookAName(ref Gradebook book)
        {
            book = new Gradebook();
            book.Name = "A Name";
        }

        private void IncrementNumber(ref int number)
        {
            number++;
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        // Unit Tests

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades = new float[3];
            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);

        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "Dillon";
            name.ToUpper();

            Assert.AreNotEqual("DILLON", name);

            name = name.ToUpper();

            Assert.AreEqual("DILLON", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2010, 5, 25);
            date.AddDays(2);

            Assert.AreNotEqual(27, date.Day);

            date = date.AddDays(2);

            Assert.AreEqual(27, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47, x);
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            Gradebook book1 = new Gradebook();
            Gradebook book2 = book1;
            GiveBookAName(ref book2);

            Assert.AreEqual("A Name", book2.Name);
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Dillon";
            string name2 = "dillon";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradebookVariablesHoldAReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;
            g1.Name = "Dillon's Gradebook";

            Assert.AreEqual(g1.Name, g2.Name);
        }

    }
}
