using System;
using System.Collections.Generic;

namespace CircusTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = AnimalFarm.GetAnimals(5, 15);

            var animalSuperVisor = new AnimalSupervisor(animals);
            var train = animalSuperVisor.GetTrain();
            Console.WriteLine(train);
        }
    }
}