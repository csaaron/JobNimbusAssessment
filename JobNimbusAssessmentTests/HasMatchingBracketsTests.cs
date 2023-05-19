using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JobNimbusAssessment.Tests
{
    [TestClass]
    public class HasMatchingBracketsTests
    {
        [TestMethod]
        public void MatchingBracketTest()
        {
            Assert.IsTrue(StringUtilities.HasMatchingBrackets("<>"));
            Assert.IsTrue(StringUtilities.HasMatchingBrackets("<<>>"));
            Assert.IsTrue(StringUtilities.HasMatchingBrackets("<<><<>>>"));
        }

        [TestMethod]
        public void ClosingBracketBeforeOpeningTest()
        {
            Assert.IsFalse(StringUtilities.HasMatchingBrackets("><"));
            Assert.IsFalse(StringUtilities.HasMatchingBrackets(">><"));
            Assert.IsFalse(StringUtilities.HasMatchingBrackets("><<<"));
        }

        [TestMethod]
        public void EmptyAndWhitespaceTest()
        {
            Assert.IsTrue(StringUtilities.HasMatchingBrackets(string.Empty));
            Assert.IsTrue(StringUtilities.HasMatchingBrackets("      "));
            Assert.IsTrue(StringUtilities.HasMatchingBrackets("   \n \t \r\n"));
        }

        [TestMethod]
        public void NonBracketCharactersTest()
        {
            Assert.IsTrue(StringUtilities.HasMatchingBrackets("<abc...xyz>"));
            Assert.IsTrue(StringUtilities.HasMatchingBrackets("<ABC...XYZ>"));
            Assert.IsTrue(StringUtilities.HasMatchingBrackets("<<Abc>DeF<GH<Ij>k>l>mn  \n \t \r\nop"));

            Assert.IsFalse(StringUtilities.HasMatchingBrackets("H>e<l<l<o"));
            Assert.IsFalse(StringUtilities.HasMatchingBrackets("<w<O>rLd"));
            Assert.IsFalse(StringUtilities.HasMatchingBrackets("<!>:)>"));
        }

        [TestMethod]
        public void TooManyOpeningBracketsTest()
        {
            Assert.IsFalse(StringUtilities.HasMatchingBrackets("<"));
            Assert.IsFalse(StringUtilities.HasMatchingBrackets("<<>"));
            Assert.IsFalse(StringUtilities.HasMatchingBrackets("<<<"));
            Assert.IsTrue(StringUtilities.HasMatchingBrackets("<<><<>>>"));
        }

        [TestMethod]
        public void TooManyClosingBracketsTest()
        {
            Assert.IsFalse(StringUtilities.HasMatchingBrackets(">"));
            Assert.IsFalse(StringUtilities.HasMatchingBrackets("<>>"));
            Assert.IsFalse(StringUtilities.HasMatchingBrackets("<>>>>>>>"));
            Assert.IsFalse(StringUtilities.HasMatchingBrackets("<<><><>>>"));
        }
    }
}