namespace Phoenix;
public class Program
{
    public static List<Player> PlayerList {get;set;} = new List<Player>();
    
    public static void Main(string[] args)
    {
        Program pr = new Program();
        while(true)
        {
            Console.WriteLine("\n1.Add Player Details\n2.Find Count By Age\n3.View Details By InterestedIn\n4.Exit\nEnter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the number of entries");
                    int entries = int.Parse(Console.ReadLine());
                    // int entries = 4;
                    string[] playerDetails = new string[entries];
                    // playerDetails[0] = "AP36:Abraham:20:All Rounder";
                    // playerDetails[1] = "AP37:Adam:15:Bowler";
                    // playerDetails[2] = "AP38:Mathew:14:Batter";
                    // playerDetails[3] = "AP40:Leo:19:Bowler";
                    for(int i=0; i<entries; i++)
                    {
                        playerDetails[i] = Console.ReadLine();
                    }
                    pr.AddPlayerDetails(playerDetails);
                    break;

                case 2:
                    Console.WriteLine("Enter the age");
                    int age = int.Parse(Console.ReadLine());
                    int result = pr.FindCountOfPlayersByAge(age);
                    if(result == 0)
                        Console.WriteLine("Player not found");
                    else
                        Console.WriteLine($"The players below {age} is {result}");
                    break;

                case 3:
                    Console.WriteLine("Enter the interested in");
                    string interested = Console.ReadLine();
                    List<Player> myList = pr.ViewDetailsByInterestedIn(interested);
                    if(myList.Count > 0)
                    {
                        foreach(Player item in myList)
                        {
                            Console.WriteLine($"{item.Number} {item.Name} {item.Age} {item.InterestedIn}");
                        }
                    }
                    else
                        Console.WriteLine("Player not found");
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

    public void AddPlayerDetails(string[] playerDetails)
    {
        foreach(string item in playerDetails)
        {
            string[] details = item.Split(":");
            Player player = new Player(details[0], details[1], int.Parse(details[2]), details[3]);
            PlayerList.Add(player);
        }
    }

    public int FindCountOfPlayersByAge(int age)
    {
        int count = 0;
        foreach(Player item in PlayerList)
        {
            if(item.Age < age)
            {
                count++;
            }
        }
        return count;
    }

    public List<Player> ViewDetailsByInterestedIn(string interestedin)
    {
        List<Player> myList = new List<Player>();
        foreach(Player item in PlayerList)
        {
            if(String.Equals(item.InterestedIn, interestedin))
            {
                myList.Add(item);
            }
        }
        return myList;
    }
}
