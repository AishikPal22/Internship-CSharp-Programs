using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUtility
{
    public class CustomerUtility
    {
        public CustomerUtility() { }
        
        List<Customer> CustList { get; set; } = new List<Customer>();

        public List<Customer> AddCustomer(Customer customer)
        {
            CustList.Add(customer);
            return CustList;
        }
        public Customer SearchCustomerByID(int id)
        {
            Customer temp = null;
            foreach(var item in CustList)
            {
                if(item.CustomerId == id)
                    temp = item;
            }
            return temp;
        }
        public void DisplayAllCustomers()
        {
            foreach(var item in CustList)
            {
                Console.WriteLine(item.CustomerId + " " + item.Name + " " + item.City);
            }
        }
        public void DeleteCustomer(int id)
        {
            for(int i=0 ; i<CustList.Count ; i++)
            {
                if (CustList[i].CustomerId == id)
                {
                    CustList.RemoveAt(i);
                }
            }
        }
    }
}
