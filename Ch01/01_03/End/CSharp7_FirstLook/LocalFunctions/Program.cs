﻿using System;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNumbers();

            // Local Functions
            void MyNumbers()
            {
                int myFavNumber3 = 0b1111111111;
                int myFavNumber4 = 0b1111_1111_11;
                int OneMillion = 1_000_000;
                Console.WriteLine($"These are my fav numbers: " +
                 $"{myFavNumber3}, {myFavNumber4}, { OneMillion}");
            }

            int AddTen(int n)
            {
                return n + 10;
            }
            int start = 6;
            Console.WriteLine($"total of 10 + {start} = " + AddTen(start));        
        }
        
    }
}
