namespace CalculatorProgram
{
    public class Calculator
    {
        public int Addition(int a, int b)
        { return a + b; }

        public int Subtraction(int a, int b)
        { return a - b; }

        public int Multiplication(int a, int b)
        { return a * b; }

        public double Division(int a, int b, out double remainder)
        {
            remainder = a % b;
            return a / b;
        }
    }
}
