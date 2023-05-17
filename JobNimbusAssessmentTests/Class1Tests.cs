using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobNimbusAssessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNimbusAssessment.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void HasMatchingBracketsTest()
        {
            Assert.IsTrue(Class1.HasMatchingBrackets("<>"));
            Assert.IsTrue(Class1.HasMatchingBrackets(string.Empty));
            Assert.IsTrue(Class1.HasMatchingBrackets("<abc...xyz>"));

            Assert.IsFalse(Class1.HasMatchingBrackets("><"));
            Assert.IsFalse(Class1.HasMatchingBrackets("<<>"));
        }
    }
}