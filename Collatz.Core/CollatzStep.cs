using System;

namespace Collatz.Core
{
    public struct CollatzStep
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(Value));
                }
                _value = value; 
            }
        }

        public int Step { get; set; }
    }
}
