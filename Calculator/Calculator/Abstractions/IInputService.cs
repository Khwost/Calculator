﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Abstractions
{
    /// <summary>
    /// Сервис ввода чисел (меняет строку на число)
    /// </summary>
    public interface IInputService
    {
        /// <summary>
        /// Добавляет цифру к цифрам в строке
        /// </summary>
        void AddDigit(int digit);

        /// <summary>
        /// Меняет знак числа
        /// </summary>
        void ChangeSign();

        /// <summary>
        /// Добавляет запятую в число
        /// </summary>
        void AddDot();

        /// <summary>
        /// Отдаёт строку
        /// </summary>
        string GetLine();

        /// <summary>
        /// Отдаёт число
        /// </summary>
        double GetNumber();
    }
}
