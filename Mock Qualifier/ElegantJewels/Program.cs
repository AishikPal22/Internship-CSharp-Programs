using System;

namespace ElegantJewels
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Service service = new Service();
            Console.WriteLine("Enter the bill details");
            string details = Console.ReadLine();
            service.ExtractDetails(details);
            if(service.ValidateMetalName())
            {
                System.Console.WriteLine("The bill amount is: {0}", service.CalculateTotalPrice());
            }
            else
                System.Console.WriteLine("Invalid metal name");
        }
    }
}

