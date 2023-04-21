namespace MysticBeautyParlour
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public long MobileNumber { get; set; }
        public string City { get; set; }
        public string Service { get; set; }

        public Customer()
        {
            
        }
        
        public bool AddCustomer(string name, long mobileNo, string city, string service)
        {
            Customer customer = new Customer();
            customer.CustomerName = name;
            customer.MobileNumber = mobileNo;
            customer.City = city;
            customer.Service = service;
            Program.CustomerQueue.Enqueue(customer);
            return true;
        }
        public string GetCustomerNameWithService()
        {
            if(Program.CustomerQueue.Count!=0)
                return String.Concat(Program.CustomerQueue.Peek().CustomerName.ToUpper(), Program.CustomerQueue.Peek().Service.ToLower()); 
            else
                return "No data found";
            
        }
        public Queue<Customer> RemoveCustomerDetails(long mobileNo)
        {
            if(Program.CustomerQueue.Count!=0)
                Program.CustomerQueue = new Queue<Customer>(Program.CustomerQueue.Where(x => x.MobileNumber!=mobileNo)); 
            
            return Program.CustomerQueue;
        }
    }
}