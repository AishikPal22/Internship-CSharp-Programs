namespace CentralBloodBank;
public class Program
{
    public static Dictionary<string,string> donorDetails = new Dictionary<string,string>();

    public int FindNumberOfRecords(string bloodGroup)
    {
        int count = 0;
        foreach(string item in  donorDetails.Values)
        {
            if(item == bloodGroup)
                count+=1;
        }
        return count;
    }

    public List<string> FindDonorNames(string bloodGroup)
    {
        List<string> myList = new List<string>();
        foreach(KeyValuePair<string,string> kvp in donorDetails)
        {
            if(kvp.Value == bloodGroup)
                myList.Add(kvp.Key);
        }
        return myList;
    }
    
    public Dictionary<string,string> SortByName()
    {
        SortedDictionary<string,string> myDict = new SortedDictionary<string,string>();
        foreach(KeyValuePair<string,string> kvp in donorDetails)
        {
            myDict.Add(kvp.Key, kvp.Value);
        }
        return myDict.ToDictionary(x=>x.Key, x=>x.Value);
    }
    public static void Main(string[] args)
    {
        donorDetails.Add("Sam","O+");
        donorDetails.Add("Peter","AB+");
        donorDetails.Add("Rosy","O+");
        donorDetails.Add("John","AB-");
        donorDetails.Add("Vin","B+");
        
        Program pr = new Program();
        while(true)
        {
            Console.WriteLine("1. Find number of records");
            Console.WriteLine("2. Find donor by blood group");
            Console.WriteLine("3. Sort Donors by name");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the blood group");
                    string entries = Console.ReadLine();
                    Console.WriteLine("The count is : " + pr.FindNumberOfRecords(entries));
                    break;
                
                case 2:
                    Console.WriteLine("Enter the blood group");
                    string name = Console.ReadLine();
                    List<string> myList = pr.FindDonorNames(name);
                    if(myList.Count==0)
                        Console.WriteLine("Invalid blood group");
                    else
                    {
                        Console.WriteLine($"The {name} donors are : ");
                        foreach(string item in myList)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

                case 3:
                    Dictionary<string,string> myDict = pr.SortByName();
                    foreach(KeyValuePair<string,string> kvp in myDict)
                    {
                        Console.WriteLine(kvp.Key + " " + kvp.Value);
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
