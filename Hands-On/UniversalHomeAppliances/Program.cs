namespace UniversalHomeAppliances;
public class Program
{
    public static Dictionary<int, Appliance> applianceDetails = new Dictionary<int, Appliance>();

    public static void Main(string[] args)
    {
        applianceDetails.Add(1, new Appliance("AP01", "Refrigerator", "LG", 25000));
        applianceDetails.Add(2, new Appliance("AP02", "Dishwasher", "Samsung", 10000));
        applianceDetails.Add(3, new Appliance("AP03", "Oven", "Bosch", 5000));
        applianceDetails.Add(4, new Appliance("AP04", "Microwave", "Whirlpool", 7500));
        applianceDetails.Add(5, new Appliance("AP05", "Toaster", "LG", 1500));

        Program pr = new Program();

        while(true)
        {
            System.Console.WriteLine("\n1. Get appliance details\n2. Find appliance with price range\n3. Find high cost appliance\n4. Exit\nEnter your choice:");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    System.Console.WriteLine("Enter appliance id");
                    string id = Console.ReadLine();
                    Dictionary<string,string> myDict = pr.GetApplianceDetails(id);
                    if(myDict.Count>0)
                    {
                        foreach(KeyValuePair<string,string> kvp in myDict)
                        {
                            System.Console.WriteLine($"{kvp.Key} {kvp.Value}");
                        }
                    }
                    else
                        System.Console.WriteLine("Appliance not found");
                    break;

                case 2:
                    System.Console.WriteLine("Enter the minumum price range");
                    double min = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Enter the maximum price range");
                    double max = double.Parse(Console.ReadLine());
                    Dictionary<string,string> rangeDict = pr.FindApplianceWithPriceRange(min, max);
                    if(rangeDict.Count>0)
                    {
                        foreach(KeyValuePair<string,string> kvp in rangeDict)
                        {
                            System.Console.WriteLine($"{kvp.Key} {kvp.Value}");
                        }
                    }
                    else
                        System.Console.WriteLine("Appliance not found");
                    break;

                case 3:
                    Dictionary<int,Appliance> highDict = pr.FindHighCostAppliance();
                    foreach(Appliance item in highDict.Values)
                    {
                        System.Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Brand: {item.Brand}, Price: {item.Price}");
                    }
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

    public Dictionary<string, string> GetApplianceDetails(string applianceId)
    {
        //throw new NotImplementedException();
        Dictionary<string,string> myDict = new Dictionary<string, string>();
        foreach(Appliance item in applianceDetails.Values)
        {
            if(String.Equals(item.Id,applianceId))
            {
                myDict.Add(item.Id, String.Concat(item.Name, "_", item.Brand));
            }
        }
        return myDict;
    }

    public Dictionary<string, string> FindApplianceWithPriceRange(double minRange, double maxRange)
    {
        //throw new NotImplementedException();
        Dictionary<string,string> myDict = new Dictionary<string, string>();
        foreach(Appliance item in applianceDetails.Values)
        {
            if(item.Price>=minRange && item.Price<=maxRange)
            {
                myDict.Add(item.Name, item.Brand);
            }
        }
        return myDict;
    }

    public Dictionary<int,Appliance> FindHighCostAppliance()
    {
        //throw new NotImplementedException();
        Dictionary<int,Appliance> myDict = new Dictionary<int,Appliance>();
        double highCost = double.MinValue;
        foreach(Appliance item in applianceDetails.Values)
        {
            highCost = Math.Max(item.Price, highCost);
        }
        foreach(KeyValuePair<int,Appliance> kvp in applianceDetails)
        {
            if(kvp.Value.Price == highCost)
            {
                myDict.Add(kvp.Key, kvp.Value);
            }
        }
        return myDict;
    }
}
