using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            StringReverse(str);
        }
        public static void StringReverse(string s)
        {
            ArrayList arl = new ArrayList();
            string[] words = s.Split(' ');
            //foreach(string p in words)
            //    Console.WriteLine(p);
            for(int i = words.Length - 1; i>=0; i--)
            {
                arl.Add(words[i]);
                arl.Add(" ");
            }
            //PrintValues(arl);
            string output = "";
            foreach(string element in  arl)
            {
                output += element;
            }
            Console.WriteLine(output);
        }

        private static void PrintValues(IEnumerable myList)
        {
            //throw new NotImplementedException();
            foreach (Object obj in myList)
                Console.Write("{0}", obj);
            Console.WriteLine();
        }
    }
}
