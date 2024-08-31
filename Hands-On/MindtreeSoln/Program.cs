using System;

namespace MindtreeSoln
{
    public class Bike
    {
        public string Modelname { get; set; }
        public string Wheelsize { get; set; }

        public Bike(string modelname, string wheelsize)
        {
            Modelname = modelname;
            Wheelsize = wheelsize;
        }
    }

    public class DHBike : Bike
    {
        public string Forkmodel { get; set; }

        public DHBike(string modelname, string wheelsize, string forkmdodel) : base(modelname, wheelsize)
        {
            Forkmodel = forkmdodel;
        }
    }

    public class PaymentGateway
    {
        public string PaymentProcess(string s1, string s2)
        {
            return "Netbanking Payment Processed !";
        }
        public string PaymentProcess(string s3, int num) 
        {
            return "Creditcard Mode Payment !";
        }
        public string PaymentProcess(string s4)
        {
            return "BHIM UPI Payment Process !";
        }
    }

    public class Program
    {
        public static int CountRupee(int money)
        {
            int sum = 0;
            int[] arr = { 100, 50, 10, 2, 1 };
            foreach(int i in arr)
            {
                sum = sum + money / i;
                if(money/i != 0)
                    money = money % i;
            }
            return sum;
        }
        
        public static void Main(string[] args)
        {
            //QUESTION-5
            string s = "hhhello";
            List<char> list = new List<char>();
            List<char> result = new List<char>();
            foreach (char c in s)
            {
                if (list.Contains(c))
                    result.Remove(c);
                else
                {
                    list.Add(c);
                    result.Add(c);
                }
            }
            if (result.Count != 0)
                Console.WriteLine(result[0]);
            else
                Console.WriteLine("#");
            Console.ReadKey();

            
            //QUESTION-4
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(CountRupee(num));
            
            
            //QUESTION-3
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //string s3 = Console.ReadLine();
            //int num = int.Parse(Console.ReadLine());
            //string s4 = Console.ReadLine();
            //PaymentGateway pg = new PaymentGateway();
            //Console.WriteLine(pg.PaymentProcess(s1, s2));
            //Console.WriteLine(pg.PaymentProcess(s3, num));
            //Console.WriteLine(pg.PaymentProcess(s4));


            //QUESTION-2
            //string s = Console.ReadLine();
            //string sUpper = "";
            //string sLower = "";
            //foreach(char c in s.ToCharArray())
            //{
            //    if (char.IsUpper(c))
            //        sUpper += c;
            //    else
            //        sLower += c;
            //}
            //Console.WriteLine(String.Concat(sLower, sUpper));


            //QUESTION-1
            //Console.WriteLine("Hello, World!");
            //string model1 = Console.ReadLine();
            //string wheel1 = Console.ReadLine();
            //Bike bike = new Bike(model1, wheel1);
            //string model2 = Console.ReadLine();
            //string wheel2 = Console.ReadLine();
            //string fork = Console.ReadLine();
            //DHBike bikedh = new DHBike(model2, wheel2, fork);
            //Console.WriteLine("Bike Details");
            //Console.WriteLine($"Model:{bike.Modelname}\nWheelsize:{bike.Wheelsize}");
            //Console.WriteLine();
            //Console.WriteLine("DH Bike Details");
            //Console.WriteLine($"Model:{bikedh.Modelname}\nWheelsize:{bikedh.Wheelsize}\nFork:{bikedh.Forkmodel}");
        }
    }
}