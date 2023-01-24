using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Herbivorous : Animals
    {
        public override (TypeOfFood, double) Food()
        {
            return (TypeOfFood.Herbal, Mass * 0.2);
        }
    }
}
