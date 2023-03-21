namespace CalculatorProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the operator");
            char op = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operands");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Calculator calc = new Calculator();
            if (op == '+')
            {
                int result = calc.Addition(num1, num2);
                Console.WriteLine($"Result of {num1} {op} {num2} is {result}");
            }
            if(op == '-')
            {
                int result = calc.Subtraction(num1, num2);
                Console.WriteLine($"Result of {num1} {op} {num2} is {result}");
            }
            if(op == '*')
            {
                int result = calc.Multiplication(num1, num2);
                Console.WriteLine($"Result of {num1} {op} {num2} is {result}");
            }
            if(op == '/')
            {
                double result = calc.Division(num1, num2, out double remainder);
                Console.WriteLine($"Result of {num1} {op} {num2} is {result}");
                Console.WriteLine($"Remainder={remainder}");
            }
        }
    }
}