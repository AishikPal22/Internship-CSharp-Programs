using System;

// for .NET 6.0+, no need to include Console.Readkey() 

namespace ProgFundamentals7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the product :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter price of the product :");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Is the product on SALE (yes/no) :");
            string opt = Console.ReadLine();

            int[] days = new int[3];
            Console.WriteLine("Enter the number of product sold in day 1");
            days[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of product sold in day 2");
            days[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of product sold in day 3");
            days[2] = int.Parse(Console.ReadLine());
            
            Console.WriteLine(name);

            if (string.Equals(opt, "yes"))
            {
                double[] total = new double[3];
                
                for (int i = 0; i < 3; i++)
                {
                    price = price * 0.93;
                    total[i] = price * days[i];
                    Console.WriteLine($"Day {i+1} sales total : {(int)total[i]}");
                    Console.ReadKey(); // for .NET 6.0+, no need to include Console.Readkey()
                }
            }
            else
            {
                double[] total = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    total[i] = price * days[i];
                    Console.WriteLine($"Day {i + 1} sales total : {(int)total[i]}");
                    Console.ReadKey(); // for .NET 6.0+, no need to include Console.Readkey()
                }
            }
        }
    }
}
