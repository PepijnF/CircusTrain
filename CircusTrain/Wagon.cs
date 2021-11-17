using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrain
{
    public class Wagon
    {
        public Guid Id { get; }
        private List<Animal> _animals = new List<Animal>();

        private int _points
        {
            get
            {
                return _animals.Sum(a => a.Size);
            }
        }

        public Wagon()
        {
            Id = Guid.NewGuid();
        }

        public int SizeCarnivore()
        {
            return _animals[0].Size;
        }
        
        public bool AddAnimal(Animal animal)
        {
            if (_points + animal.Size > 10) return false;
            _animals.Add(animal);
            return true;
        }

        public List<Animal> GetAnimals()
        {
            return _animals;
        }
    }
}