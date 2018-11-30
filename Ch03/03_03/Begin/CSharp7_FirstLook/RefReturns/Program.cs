using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRef1();
            TestRef2();
        }

        #region TestRef2
        static void TestRef2()
        {
           // TODO
        }

        public ref string FindActor(int index, string[] names)
        {

            if (names.Length > 0)
                return ref names[index]; // return the storage location, not the value    
            throw new IndexOutOfRangeException($"{nameof(index)} not found.");

        }
        #endregion

        #region TestRef1
        static void TestRef1()
        {
            long total = 0;
            AddByRef(15, 10, ref total);
            Console.WriteLine(total);
            Console.ReadKey();
        }

        static void AddByRef(long a, long b, ref long total)
        {
            total = a + b;
        }
        #endregion
    }
}
