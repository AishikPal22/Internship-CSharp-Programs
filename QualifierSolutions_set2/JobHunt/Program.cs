namespace JobHunt;
class Program
{
    public static Dictionary<string, string> VacancyDetails = new Dictionary<string, string>();
    
    public static void Main(string[] args)
    {
        Program pr = new Program();
        while(true)
        {
            System.Console.WriteLine("\n1. Add Vacancy Details\n2. View Details\n3. View Number of Vacancies By Role\n4. View Company Name By Role\n5. Exit");
            System.Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    // System.Console.WriteLine("Enter the number of entries");
                    // int entries = int.Parse(Console.ReadLine());
                    // string[] vacancy = new string[entries];
                    // for(int i=0; i<entries; i++)
                    // {
                    //     vacancy[i] = Console.ReadLine();
                    // }

                    string[] vacancy = new string[6];
                    vacancy[0] = "Hype Systems:Software Developer";
                    vacancy[1] = "HData Systems:Data Science Engineer";
                    vacancy[2] = "MantorGate:Web Developer";
                    vacancy[3] = "Fortegrp:Software Developer";
                    vacancy[4] = "Coh Solutions:Database Administrator";
                    vacancy[5] = "Vile Solutions:Data Science Engineer";
                    pr.AddVacancyDetails(vacancy);
                    break;

                case 2:
                    foreach(KeyValuePair<string,string> pairs in VacancyDetails)
                    {
                        System.Console.WriteLine(pairs.Key + " : " + pairs.Value);
                    }
                    break;
                
                case 3:
                    System.Console.WriteLine("Enter role to search for vacancies");
                    string role = Console.ReadLine();
                    int result = pr.FindTheNumberOfVacancies(role);
                    if(result != -1)
                        System.Console.WriteLine($"Number of vacancies available for this role is {result}");
                    else
                        System.Console.WriteLine("No vacancies are available for this role");
                    break;

                case 4:
                    System.Console.WriteLine("Enter role to search for company names");
                    string job = Console.ReadLine();
                    List<String> companies = pr.FindCompanyNames(job);
                    if(companies.Count > 0)
                    {
                        System.Console.WriteLine("Companies available for this role");
                        foreach(string item in companies)
                        {
                            System.Console.WriteLine(item);
                        }
                    }
                    else
                        System.Console.WriteLine("No companies are available for this role");
                    break;

                case 5:
                    System.Console.WriteLine("Thank You");
                    return;

                default:
                    System.Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    public void AddVacancyDetails(string[] vacancy)
    {
        foreach(string item in vacancy)
        {
            string[] entry = item.Split(':');
            VacancyDetails.Add(entry[0], entry[1]);
        }
        System.Console.WriteLine("Detail(s) added");
    }

    public int FindTheNumberOfVacancies(string role)
    {
        int count = 0;
        foreach(string value in VacancyDetails.Values)
        {
            if(String.Equals(value, role))
                count+=1;
        }
        if(count>0)
            return count;
        else    
            return -1;
    }

    public List<string> FindCompanyNames(string role)
    {
        List<String> companies = new List<string>();
        foreach(KeyValuePair<string,string> pairs in VacancyDetails)
        {
            //if(pairs.Value == role)
            if(String.Equals(pairs.Value, role))
            {
                companies.Add(pairs.Key);
            }
        }
        return companies;
    }
}
