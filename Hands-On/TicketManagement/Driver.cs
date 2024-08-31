using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Implement the code here
            char choice = 'y';

            Console.WriteLine("Enter Ticket Details: ");
            while (choice == 'y')
            {
                Console.WriteLine("Enter Passenger Id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Passenger Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Travel Date:");
                string date = Console.ReadLine();
                Console.WriteLine("Enter Distance Travelled:");
                int dist = int.Parse(Console.ReadLine());
                DistanceValidator dv = new DistanceValidator();

                while (dv.ValidateTravelDistance(dist) == "true")
                {
                    Console.WriteLine("Given distance is invalid");
                    Console.WriteLine("Enter Distance Travelled: ");

                    dist = int.Parse(Console.ReadLine());
                }
                TicketDetail td = new TicketDetail(id, name, date, dist);
                TicketBooking tb = new TicketBooking();

                tb.CalculateCost(td);
                tb.AddTicket(td);
                Console.WriteLine(td.PassengerId);
                Console.WriteLine(td.PassengerName);

                Console.WriteLine(td.TravelDate);
                Console.WriteLine(td.DistanceTravel);
                Console.WriteLine($"Ticket Cost : {td.TicketCost}");
                Console.WriteLine("Book Another Ticket (y/n): ");
                choice = char.Parse(Console.ReadLine());
            }
        }
    }

    public class DistanceValidator
    {//DO NOT change the class name

        public String ValidateTravelDistance(int distance)  //DO NOT change the method signature
        {

            //Implement code here
            if (distance < 0)
            {
                return "Given distance is invalid";
            }
            else
            {
                return "";
            }
        }
    }
}
