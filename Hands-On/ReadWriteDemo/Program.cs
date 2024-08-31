//using System.IO;

namespace ReadWriteDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string[] lines = File.ReadAllLines(@"D:\Documents\WORK\C#\ReadWriteDemo\input.txt");

            using(StreamWriter file = new StreamWriter(@"D:\Documents\WORK\C#\ReadWriteDemo\output.txt"))
            {
                foreach (string line in lines)
                {
                    //Console.WriteLine(count + line);
                    if (line.Contains("split"))
                    {
                        //Console.WriteLine(count + "\n" + line);

                        string[] output = line.Split();
                        Console.Write(output[4] + " "); // output on the console
                        file.Write(output[4] + " "); // writing to the file: output.txt

                        //count += 1;
                    }
                    //count += 1;
                }
            }    
        }
    }
}