namespace InsuranceDetails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program pr = new Program();

            Console.WriteLine("Insurance Number : ");
            string iNo = Console.ReadLine();
            Console.WriteLine("Insurance Name : ");
            string iName = Console.ReadLine();
            Console.WriteLine("Amount Covered : ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Select\n1.Life Insurance\n2.Motor Insurance");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Policy Term : ");
                int policy = int.Parse(Console.ReadLine());
                Console.WriteLine("Benefit Percent : ");
                float benefit = float.Parse(Console.ReadLine());

                Insurance li = new LifeInsurance(iNo, iName, amount, policy, benefit);
                double result = pr.addPolicy(li, option);
                Console.WriteLine($"Calculated Premium : {result}");
            }
            else if (option == 2)
            {
                Console.WriteLine("Depreciation Percent : ");
                float dep = float.Parse(Console.ReadLine());

                Insurance mi = new MotorInsurance(iNo, iName, amount, dep);
                double result = pr.addPolicy(mi, option);
                Console.WriteLine($"Calculated Premium : {result}");
            }
            else
            {
                Console.WriteLine("Invalid Option.");
            }
        }

        public double addPolicy(Insurance ins, int opt)
        {
            // return ins.calculatePremium(); // this was sufficient.

            if (opt == 1)
            {
                return ins.calculatePremium();
            }
            if (opt == 2)
            {
                return ins.calculatePremium();
            }
            return 0;
        }
    }
}