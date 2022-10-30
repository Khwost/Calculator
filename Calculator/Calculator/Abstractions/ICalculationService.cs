namespace Calculator.Abstractions
{
    /// <summary>
    /// Делание вычислений
    /// </summary>
    public interface ICalculationService
    {
        /// <summary>
        /// Возведение в квадрат
        /// </summary>
        decimal Square(decimal x);

        /// <summary>
        /// Возведение в куб
        /// </summary>
        decimal Cube(decimal x);

        /// <summary>
        /// Взятие квадратного корня
        /// </summary>
        decimal SquareRoot(decimal x);

        /// <summary>
        /// Взятие кубического корня
        /// </summary>
        decimal CubeRoot(decimal x);

        /// <summary>
        /// Сложение
        /// </summary>
        decimal Plus(decimal x, decimal y);

        /// <summary>
        /// Вычитание
        /// </summary>
        decimal Minus(decimal x, decimal y);

        /// <summary>
        /// Умножение
        /// </summary>
        decimal Multiply(decimal x, decimal y);

        /// <summary>
        /// Деление
        /// </summary>
        decimal Divide(decimal x, decimal y);
    }
}
