﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev12
{
    internal class Person
    {
        private string name;
        private string surname;
        private DateTime birthDate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public void Information()
        {
            Console.WriteLine($"İsim: {name}\nSoyisim: {surname}\nDoğum Tarihi: {birthDate}");
        }
    }
}
