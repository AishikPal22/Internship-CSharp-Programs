namespace ArchiveManagement;
class Program
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
                        System.Console.WriteLine($"{kvp.Key}\t\t{kvp.Value}");
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
        List<string> StringList = new List<string>(); 
        foreach(Book item in bookDetails.Values)
        {
            StringList.Add(item.Genre);
        }
        List<string> MyList = new List<string>();
        MyList.AddRange(StringList.Distinct());

        SortedDictionary<string, List<Book>> MyDict = new SortedDictionary<string, List<Book>>();

        for(int i=0;i<MyList.Count;i++)
        {
            List<Book> BookList = new List<Book>();
            foreach(Book item in bookDetails.Values)
            {   
                if(item.Genre == MyList[i])
                    BookList.Add(item);
            }
            MyDict.Add(MyList[i],BookList);
        }

        return MyDict;
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
