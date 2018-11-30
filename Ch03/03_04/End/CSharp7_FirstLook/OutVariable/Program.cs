using System;

namespace OutVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Out Variables
            //string firstName;
            //string lastName;

            CreateName(out var firstName, out var lastName);
            Console.WriteLine($"What's up, {firstName} {lastName}!");
        }

        private static void CreateName(out string firstName, 
                                       out string lastName)
        {
            firstName = "Reynald";
            lastName = "Adolphe";
        }
    }

}
