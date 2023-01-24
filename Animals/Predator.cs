using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Predator : Animals
    {

        public override (TypeOfFood, double) Food()
        {
            return (TypeOfFood.Meat, Distance * 0.01);
        }
    }
}
