namespace PixelPoint;
public class Program
{
    public static Dictionary<string, double> SchemeDetails = new Dictionary<string, double>();

    public void AddSchemeDetails(string[] scheme)
    {
        foreach(string item in scheme)
        {
            string[] info = item.Split(":");
            SchemeDetails.Add(info[0], double.Parse(info[1]));
        }
        //Console.WriteLine("Details added");
    }

    public double FindSchemeMonthlyAmount(string schemeName)
    {
        if(SchemeDetails.ContainsKey(schemeName))
            return SchemeDetails[schemeName];
        else
            return -1;
    }

    public List<string> FindLowestMonthlyAmountScheme()
    {
        double cost = double.MaxValue;
        foreach(double amount in SchemeDetails.Values)
        {
            cost = Math.Min(cost,amount);
        }
        List<string> myList = new List<string>();
        foreach(KeyValuePair<string,double> kvp in SchemeDetails)
        {
            if(kvp.Value == cost)
                myList.Add(kvp.Key);
        }
        return myList;
    }
    public static void Main(string[] args)
    {
        Program pr = new Program();
        while(true)
        {
            Console.WriteLine("1. Add Scheme Details");
            Console.WriteLine("2. View Monthly Amount Based on Name");
            Console.WriteLine("3. View Schemes With Lowest Monthly Amount");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the number of entries");
                    int entries = int.Parse(Console.ReadLine());
                    string[] scheme = new string[entries];
                    for(int i=0;i<entries;i++)
                    {
                        scheme[i] = Console.ReadLine();
                    }
                    pr.AddSchemeDetails(scheme);
                    break;
                
                case 2:
                    Console.WriteLine("Enter the scheme name needs to be searched");
                    string name = Console.ReadLine();
                    if(pr.FindSchemeMonthlyAmount(name)==-1)
                        Console.WriteLine("No schemes are available");
                    else
                        Console.WriteLine("Amount is : " + pr.FindSchemeMonthlyAmount(name));
                    break;

                case 3:
                    List<string> myList = pr.FindLowestMonthlyAmountScheme();
                    Console.WriteLine("Schemes with the lowest monthly amount are:");
                    foreach(string item in myList)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 4:
                    Console.WriteLine("Thank you");
                    return;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
    }
}
