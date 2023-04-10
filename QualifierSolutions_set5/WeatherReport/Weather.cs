namespace WeatherReport
{
    public class Weather
    {
        public string Location {get;set;}
        public string Date {get;set;}
        public int Temperature {get;set;}
        public string Status {get;set;}
        public Weather(string location, string date, int temp, string sts)
        {
            Location = location;
            Date = date;
            Temperature = temp;
            Status = sts;
        }
    }

}