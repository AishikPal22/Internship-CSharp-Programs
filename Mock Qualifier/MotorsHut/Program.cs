namespace MotorsHut;
public class Program
{
    public static void Main(string[] args)
    {
        Service service = new Service();
        Console.WriteLine("Enter the parking details");
        string details = Console.ReadLine();
        service.ExtractDetails(details);
        if(service.ValidateVehicleType())
        {
            System.Console.WriteLine("The amount to be paid: {0}", service.CalculateTotalAmount());
        }
        else
            System.Console.WriteLine("Invalid vehicle type");
    }
}
