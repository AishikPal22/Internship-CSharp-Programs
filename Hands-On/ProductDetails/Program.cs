using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList products = new ArrayList();

            // using function declaration from "https://zetcode.com/csharp/streamreader/"
            using var sr = new StreamReader(@"D:\Documents\WORK\C#\ProductDetails\input.csv");
            string? file;

            while ((file = sr.ReadLine()) != null)  
            {
                string[] info = file.Split(',');
                Product item = new Product(info[0].Trim(), info[1].Trim(), DateTime.ParseExact(info[2].Trim(), "dd-MM-yyyy", null), Double.Parse(info[3].Trim()));
                products.Add(item);
            }

            Console.WriteLine("{0}", String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Product Name", "Serial Number", "Purchase Date", "Purchase Cost"));

            foreach (var obj in products)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}