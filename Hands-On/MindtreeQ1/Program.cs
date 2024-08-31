namespace MindtreeQ1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string");
        string s = Console.ReadLine();
        Queue<char> q = new Queue<char>();
        foreach(char c in s.ToCharArray())
        {
            q.Enqueue(c);
        }
        List<string> myList = new List<string>();
        for(int i=0;i<(q.Count-1);i++)
        {
            string str = "";
            int a = q.ElementAt(i);
            int b = q.ElementAt(i+1);
            if(a<=b)
            {
                str+=q.ElementAt(i);
                q.Dequeue();
            }
            myList.Add(str);
        }
        foreach(char c in q)
        {
            System.Console.Write(c + ",");
        }
        System.Console.WriteLine();
        foreach(string item in myList)
        {
            System.Console.Write(item + ",");
        }
    }
}
