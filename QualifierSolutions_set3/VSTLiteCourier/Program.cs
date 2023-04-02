using System.Globalization;

namespace VSTLiteCourier;
public class Program
{
    public static void Main(string[] args)
    {
        CourierDetails courier = new CourierDetails();
        
        System.Console.WriteLine("Enter the pickup date");
        string pdate = Console.ReadLine();
        courier.PickUpDate = DateTime.ParseExact(pdate, "M/d/yyyy", CultureInfo.InvariantCulture);
        
        System.Console.WriteLine("Enter the delivery date");
        string ddate = Console.ReadLine();
        courier.DeliveryDate = DateTime.ParseExact(ddate, "M/d/yyyy", CultureInfo.InvariantCulture);
        
        courier.FindServiceType();
        
        if(String.Equals(courier.ServiceType, "Invalid"))
            System.Console.WriteLine("Invalid delivery date");
        else
        {    
            System.Console.WriteLine("Enter the cost");
            double cost = double.Parse(Console.ReadLine());
            courier.Cost = cost;
            System.Console.WriteLine("Delivery charge is " + courier.CalculateDeliveryCharge());
        }
    }
}
