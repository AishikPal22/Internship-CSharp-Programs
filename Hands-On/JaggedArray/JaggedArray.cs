using System;

namespace JaggedArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of teams:");
            int teams = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[][] score = new int[teams][];
            for (int i = 0; i < teams; i++)
            {
                Console.WriteLine("No. of attempts for team " + (i + 1) + ":");
                count = Convert.ToInt32(Console.ReadLine());
                score[i] = new int[count];
            }
            
            for (int i = 0; i < teams; i++)
            {
                Console.WriteLine("Enter the score for team " + (i + 1) + ":");
                for (int j = 0; j < score[i].Length; j++)
                {
                    score[i][j] = Convert.ToInt32(Console.ReadLine());
                    //total += score[x, j];
                }
            }
            Console.WriteLine(GetTotalScore(score));
        }

        public static String GetTotalScore(int[][] score)
        {
            //throw new NotImplementedException();
            String str = "";
            for(int i = 0; i < score.Length; i++)
            {
                int total = 0;
                for (int j = 0; j < score[i].Length; j++)
                {
                    total += score[i][j];
                }
                str += "Team " + (i + 1) + " total score is " + total + ".";
            }
            return str;
        }
    }
}