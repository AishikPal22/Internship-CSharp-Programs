namespace QualifierQ2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the customer name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter SSN(social security number)");
            long ssn = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the total loan amount");
            double loan = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of years");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the loan type");
            string type = Console.ReadLine();

            CustomerUtility customer = new CustomerUtility(name, ssn, city, loan, years);

            Console.WriteLine("Token number is {0}", customer.GenerateTokenNumber());
            Console.WriteLine("Annual interest is {0}", customer.CalculateAnnualInterest(type));
        }
    }
}