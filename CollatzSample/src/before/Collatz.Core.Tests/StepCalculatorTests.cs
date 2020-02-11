using Xunit;

namespace Collatz.Core.Tests
{
    public class StepCalculatorTests
    {
        [Fact]
        public void OddValueReturnsTriplePlusOne()
        {
            var startStep = new CollatzStep { Value = 35, Step = 0 };
            var expectedStep = new CollatzStep { Value = 106, Step = 1 };
            var actualStep = CollatzStepCalculator.Calculate(startStep);
            Assert.Equal(expectedStep, actualStep);
        }

        [Fact]
        public void EvenValueReturnsHalf()
        {
            var startStep = new CollatzStep { Value = 24, Step = 8 };
            var expectedStep = new CollatzStep { Value = 12, Step = 9 };
            var actualStep = CollatzStepCalculator.Calculate(startStep);
            Assert.Equal(expectedStep, actualStep);
        }
    }
}
