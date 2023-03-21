namespace ExtractBookCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the book code of length 18");
            string code = Console.ReadLine();
            if (code.Length == 18)
            {
                extractDept(code);
                extractYear(code);
                extractPages(code);
                extractID(code);
            }
            else
            {
                Console.WriteLine("Invalid Book Code");
            }
        }

        private static void extractID(string code)
        {
            string id = code.Substring(12, 6);
            char c = char.Parse(id.Substring(0, 1));
            if (char.IsLetter(c) && int.TryParse(id.Substring(1, 5), out int num))
                Console.WriteLine("Book ID: " + id);
            else
                Console.WriteLine("Invalid Book ID");
        }

        private static void extractPages(string code)
        {
            int pages = int.Parse(code.Substring(7, 5));
            if (pages >= 1 && pages <= 99999)
                Console.WriteLine(string.Concat("Number of Pages: ", code.AsSpan(7, 5)));
            else
                Console.WriteLine("Invalid Page Numbers");
        }

        private static void extractYear(string code)
        {
            int year = int.Parse(code.Substring(3, 4));
            if (year >= 1900 && year <= 2020)
                Console.WriteLine("Year of Publication: " + year);
            else
                Console.WriteLine("Invalid Year");
        }

        private static void extractDept(string code)
        {
            string dept = code.Substring(0, 3);
            if (String.Equals(dept, "101") || String.Equals(dept, "102") || String.Equals(dept, "103"))
                Console.WriteLine("Department Code: " + dept);
            else
                Console.WriteLine("Invalid Department Code");
        }
    }
}