﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBFM
{
    class Program
    {
        #region Previously in C# 6
        static private string name = "Jerry Seinfeld";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        static void Main(string[] args)
        {
            // TODO: C# 7 Expression Bodied Function Members
            Person p = new Person(name);
            p.Age = 62;
            Console.WriteLine($"Name: {p.Name} is {p.Age}");
        }
    }

    class Person
    {

        #region Classic Constructor

        public Person(string name)
        {
            Name = name;
        }

        #endregion

        #region Classic Full Properties

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        #endregion

        #region Classic Desctructor

        ~Person()
        {
            Console.WriteLine("Destructor was called!");
        }

        #endregion
    }
}
