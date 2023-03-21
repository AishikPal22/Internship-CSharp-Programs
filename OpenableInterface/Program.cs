namespace OpenableInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the letter found in the paper");
            char letter = char.Parse(Console.ReadLine());
            if (letter == 'T')
            {
                IOpenable open = new TreasureBox();
                Console.WriteLine(open.OpenSesame());
            }
            else if (letter == 'P')
            {
                IOpenable open = new Parachute();
                Console.WriteLine(open.OpenSesame());
            }
        }
    }
}