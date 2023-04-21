namespace DateEx2
{
    public class Program
    {
        static Dictionary<string, DateTime> flightSchedule
            = new Dictionary<string, DateTime>()
            {
                {"ZW346", Convert.ToDateTime("13:54:10")},
                {"AT489", Convert.ToDateTime("16:30:00")},
                {"BR267", Convert.ToDateTime("21:15:30")},
                {"AP420", Convert.ToDateTime("23:58:00")}
            };
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Flight Number: ");
            string result = Console.ReadLine();
            Console.WriteLine(flightStatus(result));
        }

        public static string flightStatus(string flightNo)
        {
            if(flightSchedule.ContainsKey(flightNo))
            {
                DateTime deptTime = flightSchedule[flightNo];
                //Console.WriteLine("Time of departure: " + deptTime.TimeOfDay);
                //Console.WriteLine("Time now: " + DateTime.UtcNow);
                if (DateTime.UtcNow > deptTime)
                    return "Flight Already Left";
                else
                    return "Time To Flight " + (deptTime - DateTime.UtcNow).ToString();
            }
            else
                return "Invalid Flight Number";
        }
    }
}