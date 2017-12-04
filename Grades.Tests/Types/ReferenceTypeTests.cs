using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestFixture]
    class ReferenceTypeTests
    {
        [Test]
        public void VariablesHoldAReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;
            g1.Name = "Dillon's Gradebook";

            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}
