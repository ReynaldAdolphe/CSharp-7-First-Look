using System;

namespace Deconstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO - Deconstruction Demo
            (string authorName, string bookTitle, long pubYear) = GetNewCS7_Tuple();

            Console.WriteLine("Author: {0} \nBook: {1} Year: {2}\n", 
                authorName, bookTitle, pubYear);
        }


        static public (string name, string title, long year) GetNewCS7_Tuple()
        {
            string name = "Reynald Adolphe";
            string title = ".NET Programming";
            long year = 2017;

            // Tuple literal - Returns a tuple type of three values  
            return (name, title, year);
        }
    }
}
