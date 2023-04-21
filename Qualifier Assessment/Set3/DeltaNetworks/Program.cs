namespace DeltaNetworks;
public class Program
{
    public static void Main(string[] args)
    {
        PlanDetails pd = new PlanDetails();
        Console.WriteLine("Enter the plan type");
        pd.PlanType = Console.ReadLine();
        if(pd.ValidatePlanType())
        {
            Plan p = pd.CalculatePlanAmount();
            System.Console.WriteLine($"Plan type is {p.PlanType}. \nPlan Amount is {p.PlanAmount}");
        }
        else
            System.Console.WriteLine("Invalid plan");
    }
}
