using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void VariablesHoldAReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;
            g1.Name = "Dillon's Gradebook";

            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
