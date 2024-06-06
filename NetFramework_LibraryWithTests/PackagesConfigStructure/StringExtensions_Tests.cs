using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryExample
{
    [TestClass]
    public class StringExtensions_Tests
    {
        [TestMethod]
        public void NullString_EmptyStringIsReturned()
        {
            string value = null;
            Assert.AreEqual(value.SafeTrim(), "");
        }

        [TestMethod]
        public void EmptyString_EmptyStringIsReturned()
            => Assert.AreEqual("".SafeTrim(), "");

        [TestMethod]

        public void ValueWithLeadingAndTrailingSpace_ValueIsTrimmed()
            => Assert.AreEqual(" hello world ".SafeTrim(), "hello world");
    }
}
