using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            int myFavNumber = 50;

            int myFavNumber2 = 0xFFDB;

            int myFavNumber3 = 0b1111_1111_1111;

            int oneMillion = 1_000_000;

            int[] number = { 0b1, 0b10, 0b100, 0b1_000 };
        }
    }
}
