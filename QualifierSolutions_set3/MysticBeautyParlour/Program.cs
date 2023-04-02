namespace MysticBeautyParlour;
public class Program
{
    public static Queue<Customer> CustomerQueue { get; set; } = new Queue<Customer>();
    
    public static void Main(string[] args)
    {
        Customer customer = new Customer();
        while(true)
        {
            System.Console.WriteLine("\nChoose the option\n1.Add the customer details\n2.Get customer name with service\n3.Remove customer details\n4.Exit");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    System.Console.WriteLine("Enter the customer name");
                    string name = Console.ReadLine();
                    System.Console.WriteLine("Enter the mobile number");
                    long num = long.Parse(Console.ReadLine());
                    System.Console.WriteLine("Enter the city");
                    string city = Console.ReadLine();
                    System.Console.WriteLine("Enter the service");
                    string service = Console.ReadLine();
                    
                    bool result = customer.AddCustomer(name, num, city, service);
                    if(result)
                        System.Console.WriteLine("Customer details added successfully\n");
                    break;

                case 2:
                    System.Console.WriteLine(customer.GetCustomerNameWithService());
                    break;

                case 3:
                    System.Console.WriteLine("Enter the mobile number");
                    long number = long.Parse(Console.ReadLine());
                    _ = customer.RemoveCustomerDetails(number); 
                    if(CustomerQueue.Count==0)
                        System.Console.WriteLine("No data found");
                    else
                    {
                        foreach(Customer item in CustomerQueue)
                        {
                            System.Console.WriteLine($"{item.CustomerName} {item.MobileNumber} {item.City} {item.Service}");
                        }
                    }     
                    break;

                case 4:
                    System.Console.WriteLine("Thank you");
                    return;
                
                default:
                    System.Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
