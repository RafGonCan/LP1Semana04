using System;
using System.Text;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor("Good Morning!", '*',4));
            Console.WriteLine(Decor("Good Evening!", '.',2));
        }
        private static string Decor (string frase, char dec, int count)
        {
            return $"{dec}{dec}{dec} {frase} {dec}{dec}{dec}";
        }
    }
}
