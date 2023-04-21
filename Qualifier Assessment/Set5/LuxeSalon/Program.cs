namespace LuxeSalon;
public class Program
{
    public static void Main(string[] args)
    {
        CustomerDetails customer = new CustomerDetails();
        Console.WriteLine("Enter the customer name");
        customer.CustomerName = Console.ReadLine();
        Console.WriteLine("Enter the membership type");
        customer.MemberType = Console.ReadLine();
        System.Console.WriteLine("Enter the service charge");
        customer.ServiceCharge = double.Parse(Console.ReadLine());
        if(customer.ValidateMemberType())
            System.Console.WriteLine("Service charge after the discount is " + customer.ServiceChargeAfterDiscount());
        else
            System.Console.WriteLine("Invalid membership");
    }
}
