using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Omnivore : Animals
    {
        public override (TypeOfFood, double) Food()
        {
            double herbal = Mass * 0.2;
            double meat = Distance * 0.01;
            if (herbal < meat)
            {
                return (TypeOfFood.Herbal, herbal);
            }
            else
                return (TypeOfFood.Meat, meat);
        }
    }
}
