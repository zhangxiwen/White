using TestStack.White.UIItems;
using Xunit;

namespace TestStack.White.UnitTests.UIItems
{
    public class DateFormatTest
    {
        [Fact]
        public void DifferentDateFormats()
        {
            Assert.Equal(DateFormat.dayMonthYear, DateFormat.Create("-", "dd-MM-yyyy"));
            Assert.Equal(DateFormat.dayMonthYear, DateFormat.Create("-", "d-M-yyyy"));
        }
    }
}