using Calculator.Abstractions;
using System;

namespace Calculator.Implementations
{
    public class InputService: IInputService
    {
        /// <summary>
        /// Число, которое хранится и отображается на экране
        /// </summary>
        private double _number;

        public void AddDigit(int digit)
        {
            if (digit < 0 || digit > 9)
            {
                throw new ArgumentException(nameof(digit));
            }

            _number = _number * 10 + digit;
        }

        public void AddDot()
        {
            throw new NotImplementedException();
        }

        public void ChangeSign()
        {
            throw new NotImplementedException();
        }

        public string GetLine()
        {
            return _number.ToString();
        }

        public double GetNumber()
        {
            throw new NotImplementedException();
        }
    }
}
