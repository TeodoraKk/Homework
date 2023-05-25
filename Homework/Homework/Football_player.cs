using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Football_player:Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nNumber: {Number}\nAge: {Age}\nHeight: {Height}";
        }
    }
}
