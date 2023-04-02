namespace VegetableCost;
public class Program
{
    public static void Main(string[] args)
    {
        Service service = new Service();
        Console.WriteLine("Enter bill id");
        service.BillId = Console.ReadLine();
        if(service.ValidateBillId())
        {
            Console.WriteLine("Enter Vegetable name");
            service.Name = Console.ReadLine();
            Console.WriteLine("Enter pack capacity in grams");
            service.GramsInPack = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cost per pack");
            service.CostPerPack = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity to purchase in kgs");
            float quantity = float.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Vegetable cost Rs.{0}", service.CalculateTotalCost(quantity));
        }
        else
            System.Console.WriteLine("Invalid bill id.");
    }
}
