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
                new Predator(){ID = 156, Name = "Wolf", Distance = 200, Mass = 20},
                new Predator(){ID = 297, Name = "Raccoon", Distance = 20, Mass = 50},
                new Herbivorous(){ID = 357, Name = "Cow", Distance = 150, Mass = 250},
                new Omnivore(){ID = 976, Name = "Bear", Distance = 30, Mass = 500}
            };
            string nameFile = "input.txt";
            // A
            animals.Sort();

            foreach (var animal in animals)
            {
                var food = animal.Food();
                Console.WriteLine($"{animal.Name}, Eats {food.Item2} kg of {food.Item1}");
            }
            Console.WriteLine(" ");
            // B
            foreach (var a in animals.Take(3))
            {

                Console.WriteLine(a.Name);
            }
            Console.WriteLine(" ");
            // C
            foreach (var a in animals.TakeLast(3))
            {
                Console.WriteLine(a.ID);
            }
            Console.WriteLine(" ");
            // D
            ReadInfo(nameFile);
        }

        public static void ReadInfo(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<Animals> animals = new List<Animals>();
            while (true)
            {
                string? line = sr.ReadLine();
                if (line == null) break;
                string[] N = line.Split(' ');

                try
                {
                    Animals animal;

                    if (N[3] == "Predator") animal = new Predator();
                    else if (N[3] == "Herbivorous") animal = new Herbivorous();
                    else if (N[3] == "Omnivore") animal = new Omnivore();
                    else
                    {
                        Console.WriteLine("Reading error");
                        continue;
                    }

                    animal.ID = Convert.ToInt32(N[0]);
                    animal.Name = N[1];
                    animal.Mass = Convert.ToDouble(N[2]);
                    animal.Distance = Convert.ToDouble(N[3]);

                    animals.Add(animal);
                }
                catch (Exception)
                {
                    Console.WriteLine("Reading error");
                    continue;
                }
            }
            sr.Close();
        }
    } 
}