using System;
using Xunit;

namespace Collatz.Core.Tests
{
    public class StepTests
    {
        [Fact]
        public void NegativeValueThrowsArgumentOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new CollatzStep { Value = -1, Step = 0 });
        }

        [Fact]
        public void NegativeValueThrowsArgumentOutOfRangeWithMessage()
        {
            string expectedMsg = "Specified argument was out of the range of valid values. (Parameter 'Value')";
            Action act = () => new CollatzStep { Value = -1, Step = 0 };
            var ex = Assert.Throws<ArgumentOutOfRangeException>(act);
            Assert.Equal(expectedMsg, ex.Message);
        }
    }
}
