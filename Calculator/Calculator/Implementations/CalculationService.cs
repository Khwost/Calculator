using Calculator.Abstractions;
using DecimalMath;

namespace Calculator.Implementations
{
    public class CalculationService: ICalculationService
    {
        public decimal Cube(decimal x)
        {
            return DecimalEx.Pow(x, 3);
        }

        public decimal CubeRoot(decimal x)
        {
            return DecimalEx.Pow(x, 1m / 3m);
        }

        public decimal Divide(decimal x, decimal y)
        {
            return x / y;
        }

        public decimal Minus(decimal x, decimal y)
        {
            return x - y;
        }

        public decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }

        public decimal Plus(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Square(decimal x)
        {
            return DecimalEx.Pow(x, 2);
        }

        public decimal SquareRoot(decimal x)
        {
            return DecimalEx.Pow(x, 0.5m);
        }
    }
}
