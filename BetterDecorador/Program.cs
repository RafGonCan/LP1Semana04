using System;
using System.Text;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                string s = args[0];
                char dec = Convert.ToChar(args[1]);
                int count = Convert.ToInt32(args[2]);

                Console.WriteLine(Decor(s, dec, count));
            }
            else
            {
                Console.WriteLine("You are missing some args!");
            }
        }
        private static string Decor (string s, char dec, int count)
        {
            string decors = "";
            int number;

            for (number = 0; number < count; number++)
            {
                decors += dec;
            }

            return $"{decors} {s} {decors}";
        }
    }
}
