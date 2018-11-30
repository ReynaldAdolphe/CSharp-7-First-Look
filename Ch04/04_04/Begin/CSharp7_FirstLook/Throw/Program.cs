using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    class Program
    {
        //TODO: Throw Expressions

        static private string _name;

        static public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        static void Main(string[] args)
        {
            Name = null;

            if (Name == null)
                throw new ArgumentNullException(paramName: nameof(Name),
                    message: "New name must not be null");

            Console.WriteLine($"Name = {Name}");
        }
    }
}
