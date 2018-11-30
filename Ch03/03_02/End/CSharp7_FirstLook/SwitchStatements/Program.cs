using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Performer p = new Performer();
            Actor a = new Actor("Eddie Murphy", 54, "male", 
                                "Coming to America", 2017);
            Musician m = new Musician("Jen", 25, "female", "singing", 
                                      "Pop");

            // Switch Statement 
            m = null;
            switch (m)
            {
                case Performer performer when (performer.Age == 33):
                   Console.WriteLine($"The performer {performer.Name}");
                    break;
                case Musician musician when (musician.Age == 25):
                    Console.WriteLine($"The performer {musician.Name}");
                    break;
                case Musician musician:
                    Console.WriteLine("The Musician is unknown");
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(m));
            }
        }
    }

    #region Classes
    // Performer class      
    class Performer
    {
        public string Name { get; set; }
        public Int16 Age { get; set; }
        public string Gender { get; set; }
    }

    // Actor class      
    class Actor : Performer
    {
        public string BestMovie { get; set; }
        public Int16 Year { get; set; }

        public Actor(string name, Int16 age, string gender, string bestMovie, Int16 year)
        {
            Name = name;
            Age = age;
            Gender = gender;
            BestMovie = bestMovie;
            Year = year;
        }
    }
    // Musician class      
    class Musician : Performer
    {
        private string Interest;
        private string Format;
        public Musician(string name, Int16 age, string gender, string interest, string format)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Interest = interest;
            Format = format;
        }
    }
    #endregion

}
