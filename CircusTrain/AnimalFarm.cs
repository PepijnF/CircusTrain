using System;
using System.Collections.Generic;

namespace CircusTrain
{
    public class AnimalFarm
    {
        public static List<Animal> GetAnimals(int numberOfAnimals)
        {
            List<Animal> animals = new List<Animal>();
            Random random = new Random();
            for (int i = 0; i < numberOfAnimals; i++)
            {
                animals.Add(new Animal((Animal.SizeEnum)random.Next(0,2), (Animal.FoodPreferenceEnum)random.Next(0,2)));
            }

            return animals;
        }

        public static List<Animal> GetAnimals(int carnivores, int herbivores)
        {
            List<Animal> animals = new List<Animal>();
            Random random = new Random();

            for (int i = 0; i < carnivores; i++)
            {
                animals.Add(new Animal((Animal.SizeEnum)random.Next(0, 2), Animal.FoodPreferenceEnum.Carnivore));
            }

            for (int i = 0; i < herbivores; i++)
            {
                animals.Add(new Animal((Animal.SizeEnum)random.Next(0,2), Animal.FoodPreferenceEnum.Herbivore));
            }

            return animals;
        }
    }
}