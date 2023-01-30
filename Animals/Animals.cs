using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Animals
{
    public abstract class Animals: IComparable<Animals>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Distance { get; set; }

        public int CompareTo(Animals? other)
        {
            if (other == null) return 1;
            int res = Food().Item2.CompareTo(other.Food().Item2);
            return res == 0 ?  Name.CompareTo(other.Name) : res;
        }

        public abstract (TypeOfFood, double) Food();
    }
}