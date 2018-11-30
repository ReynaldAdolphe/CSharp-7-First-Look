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
            Comedian comedian = new Comedian("Reynald", "Adolphe");
            var (firstName, lastName) = comedian;
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
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

        public void Deconstruct(out string firstName, out string lastName) {
            firstName = FirstName;
            lastName = LastName;
        }
    }
}
