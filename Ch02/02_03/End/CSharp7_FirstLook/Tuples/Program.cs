using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 6
            CS7_TupleDemo();
        }


        // C# 7 - Ex 6
        private static void CS7_TupleDemo()
        {
            TupleSamples ts = new TupleSamples();
            var person = ts.GetNewCS7_Tuple();
            Console.Write($"\n C# 7 Tuple - Author " +
                $"{person.Item1} {person.Item2} {person.Item3}");
        }

    }

    class TupleSamples
    {
        // Ex 6 - C# 7 Tuple
        public (string name, string title, long year) GetNewCS7_Tuple() {
            string name = "Reynald Adolphe";
            string title = ".Net Programming";
            long year = 2017;

            return (name, title, year);
        }
    }
}
