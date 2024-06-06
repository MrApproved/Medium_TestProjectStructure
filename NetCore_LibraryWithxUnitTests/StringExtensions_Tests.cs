using Xunit;

namespace LibraryExample
{
    public class StringExtensions_Tests
    {
        [Fact]
        public void NullString_EmptyStringIsReturned()
        {
            string value = null;
            Assert.True(value.SafeTrim() == "");
        }

        [Fact]
        public void EmptyString_EmptyStringIsReturned()
            => Assert.True("".SafeTrim() == "");

        [Fact]

        public void ValueWithLeadingAndTrailingSpace_ValueIsTrimmed()
            => Assert.True(" hello world ".SafeTrim() == "hello world");
    }
}
