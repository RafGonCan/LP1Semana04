using System;
using System.Text;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
        }
        private static string Decor (string s, char dec, int count)
        {
            string decors = "";
            int number;

            for (number = 0; number < count; number++)
            {
                decors += decors;
            }

            return $"{decors} {s} {decors}";
        }
    }
}
