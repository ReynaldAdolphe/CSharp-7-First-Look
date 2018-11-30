using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Out Variables
            string firstName;
            string lastName;

            CreateName(out firstName, out lastName);
            Console.WriteLine($"What's up, {firstName} {lastName}!");
        }

        private static void CreateName(out string firstName, out string lastName)
        {
            firstName = "Reynald";
            lastName = "Adolphe";
        }
    }

}
