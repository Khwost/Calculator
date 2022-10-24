using Calculator.Abstractions;
using System;

namespace Calculator.Implementations
{
    public class InputService: IInputService
    {
        /// <summary>
        /// Ограничение допустимых чисел в калькуляторе
        /// </summary>
        private const decimal CalculatorLimit = decimal.MaxValue / 100.0m;

        /// <summary>
        /// Число, которое хранится и отображается на экране
        /// </summary>
        private decimal _number;

        /// <summary>
        /// Делитель для введённого числа
        /// </summary>
        private decimal _divider = 1;

        /// <summary>
        /// Отрицательно-ли число?
        /// </summary>
        private bool _isNegative;

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

            if (Math.Abs(_number) > CalculatorLimit || Math.Abs(_divider) > CalculatorLimit)
            {
                return;
            }

            _number = _number * 10.0m + digit;

            if (_isDotPressed)
            {
                _divider = _divider * 10.0m;
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
            _isNegative = !_isNegative;
        }

        public string GetLine()
        {
            return PrepareResult().ToString();
        }

        public decimal GetNumber()
        {
            throw new NotImplementedException();
        }

        private decimal PrepareResult()
        {
            if (_isNegative)
            {
                return -1 * _number / _divider;
            }

            return _number / _divider;
        }
    }
}
