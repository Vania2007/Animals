using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animals> animals = new List<Animals>()
            {
                new Predator(){ ID = 1,Name = "Wolf", Distance = 200, Mass = 20},
                new Predator(){ ID = 419, Name = "Raccoon", Distance = 20, Mass = 50},
                new Herbivorous(){ID = 2348, Name = "Cow", Distance = 150, Mass = 250},
                new Omnivore(){ID = 17638, Name = "Bear", Distance = 30, Mass = 500}
            };
            //a - не виходить
            var selectedList = from u in animals orderby u descending select u;
            foreach (var animal in animals)
            {
                var food = animal.Food();
                Console.WriteLine($"{animal.ID} {animal.Name}, Eats {food.Item2} kg of {food.Item1}");

            }
            Console.WriteLine("   ");
            //b
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{animals[i].Name}");
            }
            Console.WriteLine("   ");
            //c
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Id: {animals[animals.Count - i].ID}");
            }
            //d
            StreamReader sr = new StreamReader("input.txt");
            string[] s = sr.ReadLine().Split(',');
            sr.Close();
        }
    }
}
