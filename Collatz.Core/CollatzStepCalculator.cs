namespace Collatz.Core
{
    public static class CollatzStepCalculator
    {
        public static CollatzStep Calculate(CollatzStep input)
        {
            if (input.Value == 1)
            {
                return input;
            }

            int nextStep = input.Step + 1;
            int nextValue = (input.Value % 2 == 0) ? input.Value / 2 : (input.Value * 3) + 1;

            return new CollatzStep { Value = nextValue, Step = nextStep };
        }
    }
}
