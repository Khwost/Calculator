using Calculator.Abstractions;
using System;

namespace Calculator.Implementations
{
    public class InputService: IInputService
    {
        /// <summary>
        /// Число, которое хранится и отображается на экране
        /// </summary>
        private decimal _number;

        /// <summary>
        /// Делитель для введённого числа
        /// </summary>
        private int _divider = 10;

        /// <summary>
        /// Нажата точка или нет
        /// </summary>
        private bool _isDotPressed;

        public void AddDigit(int digit)
        {
            if (digit < 0 || digit > 9)
            {
                throw new ArgumentException(nameof(digit));
            }

            if (_isDotPressed)
            {
                // После нажатия точки
                _number = _number + digit / (decimal)_divider;
                _divider = _divider * 10;
            }
            else
            {
                // Если точка не нажата
                _number = _number * 10 + digit;
            }
        }

        public void AddDot()
        {
            if (_isDotPressed)
            {
                return;
            }

            _isDotPressed = true;
        }

        public void ChangeSign()
        {
            _number = _number * -1;
        }

        public string GetLine()
        {
            return _number.ToString();
        }

        public decimal GetNumber()
        {
            throw new NotImplementedException();
        }
    }
}
