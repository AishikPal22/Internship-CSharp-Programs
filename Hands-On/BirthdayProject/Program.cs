using System;
using System.IO;

namespace BirthdayProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter date of birth in yyyy/mm/dd/ format");
            DateTime bdate = DateTime.Parse(Console.ReadLine());
            Person man = new Person(fName, lName, bdate);
            man.DisplayDetails();
            Console.ReadKey();
        }
    }
}