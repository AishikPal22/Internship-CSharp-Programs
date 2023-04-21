namespace CustomerUtility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomerUtility cu = new CustomerUtility();
            while (true)
            {
                Console.WriteLine("1. Add Customer\n2. Display Customer\n3. Search Customer\n4. Delete Customer");
                Console.WriteLine("Enter Your Choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Customer id, name and city");
                        int id = int.Parse(Console.ReadLine());
                        string name = Console.ReadLine();
                        string city = Console.ReadLine();
                        Customer customer = new Customer(id, name, city);
                        _ = cu.AddCustomer(customer);
                        break;

                    case 2:
                        cu.DisplayAllCustomers();
                        break;

                    case 3:
                        int searchId = int.Parse(Console.ReadLine());
                        Customer temp = cu.SearchCustomerByID(searchId);
                        if(temp!=null)
                            Console.WriteLine(temp.CustomerId + " " + temp.Name + " " + temp.City);
                        else
                            Console.WriteLine("Wrong input.");
                        break;

                    case 4:
                        int deleteId = int.Parse(Console.ReadLine());
                        cu.DeleteCustomer(deleteId);
                        break;

                    default:
                        return;
                }
            }
        }

    }
}