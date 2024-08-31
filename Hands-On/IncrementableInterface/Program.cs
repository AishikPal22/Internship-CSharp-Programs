namespace IncrementableInterface;
public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the details of Manager");
        string mname = Console.ReadLine();
        double msalary = double.Parse(Console.ReadLine());
        string teamId = Console.ReadLine();
        
        System.Console.WriteLine("Enter the details of Programmer");
        string pname = Console.ReadLine();
        double psalary = double.Parse(Console.ReadLine());
        string domain = Console.ReadLine();

        Employee m = new Manager(mname, msalary, teamId);
        m.Print();
        Employee p = new Programmer(pname, psalary, domain);
        p.Print();
    }
}
