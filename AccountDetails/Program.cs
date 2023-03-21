namespace AccountDetails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter account id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter account type");
            string accountType = Console.ReadLine();
            Console.WriteLine("Enter account balance");
            double balance = double.Parse(Console.ReadLine());
            Account account = new Account(id, accountType, balance);
            Console.WriteLine("Enter amount to withdraw");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine(account.GetDetails());
            if (account.WithDraw(amount))
                Console.WriteLine("New Balance: " + account.Balance);
        }
    }
}