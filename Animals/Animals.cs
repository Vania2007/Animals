using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animals
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Distance { get; set; }
        public abstract (TypeOfFood, double) Food();
    }
}