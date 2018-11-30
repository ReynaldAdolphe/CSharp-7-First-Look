using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO
        }
    }

    public class Comedian
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Comedian(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
