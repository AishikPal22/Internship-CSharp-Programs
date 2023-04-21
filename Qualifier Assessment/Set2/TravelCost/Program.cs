using System;

namespace TravelCost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the travel id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter the departure place");
            string departure = Console.ReadLine();
            Console.WriteLine("Enter the destination place");
            string destination = Console.ReadLine();
            Console.WriteLine("Enter the number of days");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cost per day");
            double cost = double.Parse(Console.ReadLine());
            Service service = new Service(id, departure, destination, days, cost);
            if(service.ValidateTravelId(id))
            {
                Console.WriteLine("Discounted Cost: {0}", service.CalculateDiscountedCost());
            }
            else
                Console.WriteLine("Invalid travel id");
        }
    }
}