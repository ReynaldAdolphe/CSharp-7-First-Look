using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 1
            Create3Tuple();

            // Ex 2
            Create5Tuple();

            // Ex 3
            CreateNestedTuple();

            // Ex 4
            TupleInMethod1();

            // Ex 5
            TupleInMethod2();

            // Ex 6
            //CS7_TupleDemo(); // Comming soon...

        }

        // Ex 1
        static private void Create3Tuple()
        {
            var person = new Tuple<string, string, int>("1. 3 tuples - Reynald Adolphe", 
                                                        "C# Design Patterns", 2016);
            Console.WriteLine($"{person.Item1} released his popular {person.Item2} " +
                              $"course in {person.Item3}.");
        }

        // Ex 2
        static private void Create5Tuple()
        {
            var reynald = Tuple.Create("\n2. 5 tuples - Reynald", "C# 6: First Look",
                                       "Lynda.com", 2016, 30.00);
            Console.WriteLine("{0} shot his 1st course titled {1} for {2} in {3}." +
                              " 2016 rate less than ${4}", reynald.Item1, reynald.Item2, 
                                                           reynald.Item3, reynald.Item4, 
                                                           reynald.Item5);
        }

        // Ex 3
        static private void CreateNestedTuple()
        {
            var myNestedTuple = new Tuple<int, int, int, int, int, int, int, 
                                    Tuple<string, string, double>>(2, 4, 6, 8, 10, 12, 14, 
                                    Tuple.Create("\n3. Nested Tuples - Testing ", 
                                                 "Tuples for $", 10.00));
            Console.WriteLine("{0}{1}{2}.", myNestedTuple.Rest.Item1, myNestedTuple.Rest.Item2, 
                                            myNestedTuple.Rest.Item3);
        }

        // Ex 4
        static private void TupleInMethod1()
        {
            TupleSamples ts = new TupleSamples();
            ts.SetTupleMethod(new Tuple<string, string, int>("Reynald Adolphe", 
                                                             ".NET Programming", 2017));
        }

        // Ex 5
        private static void TupleInMethod2()
        {
            var person = TupleSamples.GetTupleMethod();
            Console.WriteLine("\n5. Tuples in methods II - Person:{0}, Title:{1}, Year:{2}.", 
                              person.Item1, person.Item2, person.Item3);
        }

        // C# 7 - Ex 6
        // Comming soon...

    }

    class TupleSamples
    {
        // Ex 4
        public void SetTupleMethod(Tuple<string, string, int> tuplePerson)
        {
            var person = tuplePerson;
            Console.WriteLine("\n4. Tuples in methods I - Person:{0}, Title:{1}, Year:{2}.",
            person.Item1, person.Item2, person.Item3);
        }

        // Ex 5
        public static Tuple<string, string, int> GetTupleMethod()
        {
            // Create a 3-tuple and return it  
            var person = new Tuple<string, string, int>(
            "Reynald Adolphe", "Test Driven Development in C#", 2016);
            return person;
        }

        // Ex 6 - C# 7 Tuple
        // Comming soon...
    }
}
