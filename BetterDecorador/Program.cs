﻿using System;
using System.Diagnostics;
using System.Text;

namespace BetterDecorador
{
    /// <summary>
    /// Write a sentence with chars on the side separated by a space and
    /// the user can choose the char and its quantity
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Writes a sentence given by the user and "embellishes" it with chars
        /// </summary>
        /// <param name="args"></param>
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
                Console.WriteLine(Decor());
            }
        }
        /// <summary>
        /// count the number of the chars
        /// </summary>
        /// <param name="s">sentence given by user</param>
        /// <param name="dec">char given by user</param>
        /// <param name="count">count how many times the char repeat in the sentence</param>
        /// <returns>Sentence with the number given by user in chars</returns>
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
        /// <summary>
        /// if the user does not give the required args or does not enter any args at all
        /// print a warning sentence
        /// </summary>
        /// <returns> "=== User did not specify args! ==="</returns>
        private static string Decor ()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
