namespace WeatherReport;
public class Program
{
    public static List<Weather> WeatherList {get;set;} = new List<Weather>();
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Program pr = new Program();
        while(true)
        {
            System.Console.WriteLine("\n1.Add Weather Details\n2.View Details By Location\n3.View Details By Date\n4.Exit\nEnter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    System.Console.WriteLine("Enter the number of entries");
                    int entries = int.Parse(Console.ReadLine());
                    string[] details = new string[entries];
                    for(int i=0; i<entries; i++)
                    {
                        details[i] = Console.ReadLine();
                    }
                    pr.AddWeatherDetails(details);
                    break;

                case 2:
                    System.Console.WriteLine("Enter the location");
                    string location = Console.ReadLine();
                    List<Weather> list1 = pr.ViewDetailsByLocation(location);
                    System.Console.WriteLine("Location\tDate\tTemperature\tStatus");
                    if(list1.Count>0)
                    {
                        foreach(Weather item in list1)
                        {
                            System.Console.WriteLine($"{item.Location}\t{item.Date}\t{item.Temperature}\t{item.Status}");
                        }
                    }
                    else
                        System.Console.WriteLine("Location is not found");
                    break;

                case 3:
                    System.Console.WriteLine("Enter the date");
                    string date = Console.ReadLine();
                    List<Weather> list2 = pr.ViewDetailsByLocation(date);
                    System.Console.WriteLine("Location\tDate\tTemperature\tStatus");
                    if(list2.Count>0)
                    {
                        foreach(Weather item in list2)
                        {
                            System.Console.WriteLine($"{item.Location}\t{item.Date}\t{item.Temperature}\t{item.Status}");
                        }
                    }
                    else
                        System.Console.WriteLine("Date is not found");
                    break;

                case 4:
                    System.Console.WriteLine("Thank you");
                    return;

                default:
                    System.Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    public void AddWeatherDetails(string[] weatherDetails)
    {
        foreach(string item in weatherDetails)
        {
            string[] info = item.Split(",");
            Weather weather = new Weather(info[0],info[1],int.Parse(info[2]),info[3]);
            WeatherList.Add(weather);
        }
    }

    public List<Weather> ViewDetailsByLocation(string location)
    {
        List<Weather> myList = new List<Weather>();
        foreach(Weather item in WeatherList)
        {
            if(item.Location == location)
                myList.Add(item);
        }
        return myList;
    }

    public List<Weather> ViewDetailsByDate(string date)
    {
        List<Weather> myList = new List<Weather>();
        foreach(Weather item in WeatherList)
        {
            if(item.Date == date)
                myList.Add(item);
        }
        return myList;
    }
}
