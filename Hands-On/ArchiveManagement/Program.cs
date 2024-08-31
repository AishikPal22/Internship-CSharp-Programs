namespace ArchiveManagement;
public class Program
{
    public static SortedDictionary<int, Book> bookDetails = new SortedDictionary<int, Book>();
    
    public static void Main(string[] args)
    {
        bookDetails.Add(1, new Book("M01", "The Stranger", "Adventure", "04/25/2020", "05/01/2020", 0));
        bookDetails.Add(2, new Book("M02", "War and Peace", "Historical", "07/15/2008", "07/15/2008", 0));
        bookDetails.Add(3, new Book("M03", "Odyssey", "Adventure", "10/25/2003", "10/25/2003", 0));
        bookDetails.Add(4, new Book("M04", "The Hobbit", "Fantasy", "11/08/2020", "11/13/2020", 0));
        bookDetails.Add(5, new Book("M05", "The Alchemist", "Fantasy", "02/09/2020", "02/10/2020", 0));

        Program pr = new Program();

        while(true)
        {
            System.Console.WriteLine("\n1. Group books by genre\n2. Update penalty amount\n3. Find same day return books\n4. Exit\nEnter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    SortedDictionary<string, List<Book>> genreDict = pr.GroupBooksByGenre();
                    foreach(KeyValuePair<string, List<Book>> kvp in genreDict)
                    {
                        System.Console.WriteLine(kvp.Key + ":\n"); // Patterns can be avoided
                        foreach(var item in kvp.Value)
                        {
                            System.Console.WriteLine(item.Name);
                        }
                        System.Console.WriteLine("-------------------"); // Patterns can be avoided
                    }
                    break;

                case 2:
                    System.Console.WriteLine("Enter the penalty amount");
                    double amount = double.Parse(Console.ReadLine());
                    Dictionary<string, double> penaltyDict = pr.UpdatePenaltyAmount(amount);
                    System.Console.WriteLine("MemberID\tPenalty");
                    foreach(KeyValuePair<string, double> kvp in penaltyDict)
                    {
                        System.Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
                    }
                    break;

                case 3:
                    List<string> newList = pr.FindBooksNameWithSameDayReturn();
                    foreach(string item in newList)
                    {
                        System.Console.WriteLine(item);
                    }
                    break;

                case 4:
                    System.Console.WriteLine("Thank You");
                    return;

                default:
                    System.Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    public SortedDictionary<string,List<Book>> GroupBooksByGenre()
    {
        SortedDictionary<string, List<Book>> myDict = new SortedDictionary<string, List<Book>>();
        // List containing all genres
        List<string> stringList = new List<string>(); 
        foreach(Book item in bookDetails.Values)
        {
            stringList.Add(item.Genre);
        }
        // List containing distinct genres
        List<string> myList = new List<string>();
        myList.AddRange(stringList.Distinct());
        // List containing objects
        List<Book> books1 = new List<Book>();
        List<Book> books2 = new List<Book>();
        List<Book> books3 = new List<Book>();
        foreach(Book item in bookDetails.Values)
        {
            if(String.Equals(item.Genre, myList[0]))
            {
                books1.Add(item);
            }
            if(String.Equals(item.Genre, myList[1]))
            {
                books2.Add(item);
            }
            if(String.Equals(item.Genre, myList[2]))
            {
                books3.Add(item);
            }
        }
        // Adding to Dictionary
        myDict.Add(myList[0],books1);
        myDict.Add(myList[1],books2);
        myDict.Add(myList[2],books3);

        return myDict;
    }

    public Dictionary<string, double> UpdatePenaltyAmount(double amount)
    {
        Dictionary<string, double> myDict = new Dictionary<string, double>();
        foreach(Book item in bookDetails.Values)
        {
            DateTime d_issue = DateTime.ParseExact(item.IssueDate,"M/d/yyyy",null);
            DateTime d_return = DateTime.ParseExact(item.ReturnDate,"M/d/yyyy",null);
            if((d_return.Subtract(d_issue)).Days > 3)
            {
                myDict.Add(item.MemberID, item.Penalty + amount);
            }
        }

        return myDict;
    }

    public List<string> FindBooksNameWithSameDayReturn()
    {
        List<string> myList = new List<string>();
        foreach(Book item in bookDetails.Values)
        {
            DateTime d_issue = DateTime.ParseExact(item.IssueDate,"M/d/yyyy",null);
            DateTime d_return = DateTime.ParseExact(item.ReturnDate,"M/d/yyyy",null);
            if(DateTime.Compare(d_return, d_issue)==0)
            {
                myList.Add(item.Name);
            }
        }

        return myList;
    }
}
