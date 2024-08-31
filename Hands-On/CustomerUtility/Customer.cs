namespace CustomerUtility
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(int id, string name, string city)
        {
            CustomerId = id;
            Name = name;
            City = city;
        }
    }
}