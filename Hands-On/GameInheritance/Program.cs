namespace GameInheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a game");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the maximum number of players");
            int num = int.Parse(Console.ReadLine());
            Game game = new Game(name, num);

            Console.WriteLine("Enter a game that has time limit");
            string nameLimit = Console.ReadLine();
            Console.WriteLine("Enter the maximum number of players");
            int numLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time limit in minutes");
            int timeLimit = int.Parse(Console.ReadLine());
            GameWithTimeLimit gameLimit = new GameWithTimeLimit(nameLimit, numLimit, timeLimit);

            Console.WriteLine(game.ToString());
            Console.WriteLine(gameLimit.ToString());
        }
    }
}