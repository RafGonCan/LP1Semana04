﻿using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
        }
        private static int GetSpecial (int n)
        {
              if (n == 0)
              {
                return 0;
              }
              else if (n == 1)
              {
                return 1;
              }

              return GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
        }
    }
}
