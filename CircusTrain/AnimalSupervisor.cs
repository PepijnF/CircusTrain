using System.Collections.Generic;

namespace CircusTrain
{
    public class AnimalSupervisor
    {
        private List<Animal> _carnivores = new List<Animal>();
        private List<Animal> _herbivores = new List<Animal>();
        private Train _train = new Train();

        public AnimalSupervisor(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                if (animal.FoodPreference == Animal.FoodPreferenceEnum.Carnivore)
                {
                    _carnivores.Add(animal);
                }
                else
                {
                    _herbivores.Add(animal);
                }
            } 
        }

        private void FillCarnivores()
        {
            foreach (var carnivore in _carnivores)
            {
                var wagon = new Wagon();
                wagon.AddAnimal(carnivore);
                _train.Wagons.Add(wagon);
            }
        }

        private void FillHerbivores()
        {
            foreach (var wagon in _train.Wagons)
            {
                foreach (var herbivore in _herbivores)
                {
                    if (wagon.SizeCarnivore() < herbivore.Size && !herbivore.isPlaced)
                    {
                        if (wagon.AddAnimal(herbivore)) herbivore.isPlaced = true;
                    } 
                }

            }

            var tempWagon = new Wagon();
            foreach (var herbivore in _herbivores)
            {
                if (!tempWagon.AddAnimal(herbivore))
                {
                    _train.Wagons.Add(tempWagon);
                    tempWagon = new Wagon();
                }
            }
        }

        public Train GetTrain()
        {
            FillCarnivores();
            FillHerbivores();
            return _train;
        }
    }
}