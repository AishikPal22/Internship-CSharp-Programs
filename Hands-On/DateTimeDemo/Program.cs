namespace DateTimeDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string date1 = "31/3/2011";
            Console.WriteLine("Date: {0}", date1);
            DateTime d1 = DateTime.Parse(date1); // follows local date format
            Console.WriteLine("Day: " + d1.Day);
            Console.WriteLine("Month: " + d1.Month);

            Console.WriteLine("\n");

            string date2 = "2/8/2001";
            Console.WriteLine("Date: {0}", date2);
            DateTime d2 = DateTime.ParseExact(date2, "M/d/yyyy", null); // follows specified date format
            Console.WriteLine("Day: " + d2.Day);
            Console.WriteLine("Month: " + d2.Month);

            Console.WriteLine("\n");

            string date3 = "2023/4/2";
            DateTime d3 = DateTime.Parse(date3);
            Console.WriteLine("Date: {0:d}", d3);
            Console.WriteLine("Day: " + d3.Day);
            Console.WriteLine("Month: " + d3.Month);
            Console.WriteLine("Year: " + d3.Year);
        }
    }
}