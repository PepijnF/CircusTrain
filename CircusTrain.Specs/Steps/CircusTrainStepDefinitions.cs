using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace CircusTrain.Specs.Steps
{
    [Binding]
    public sealed class CircusTrainStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private int _carnivores;
        private int _herbivores;
        private int _numberOfAnimals = 0;
        private AnimalSupervisor _animalSupervisor;
        private List<Animal> _animals;

        public CircusTrainStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"there are (.*) carnivores")]
        public void GivenThereAreCarnivores(string carnivores)
        {
            _carnivores = Convert.ToInt32(carnivores);
        }

        [Given(@"(.*) herbivores")]
        public void GivenHerbivores(string herbivores)
        {
            _herbivores = Convert.ToInt32(herbivores);
        }

        [Then(@"the train gets filled up")]
        public void ThenTheTrainGetsFilledUp()
        {
            _animalSupervisor = new AnimalSupervisor(AnimalFarm.GetAnimals(_carnivores, _herbivores));
        }

        [Then(@"the train goes on it's way without problems")]
        public void ThenTheTrainGoesOnItsWayWithoutProblems()
        {
            bool noProblems = true;
            var train = _animalSupervisor.GetTrain();
            foreach (var wagon in train.Wagons)
            {
                var animals = wagon.GetAnimals();
                if (animals[0].FoodPreference == Animal.FoodPreferenceEnum.Carnivore)
                {
                    bool first = true;
                    foreach (var animal in animals)
                    {
                        if (!first)
                        {
                            noProblems = animal.Size > animals[0].Size;
                        }

                        first = false;
                    }
                }
            }
            Assert.True(noProblems);
        }

        [Given(@"there are a total of (.*) animals")]
        public void GivenThereAreATotalOfAnimals(string animals)
        {
            _numberOfAnimals = Convert.ToInt32(animals);
        }

        [When(@"the supervisor gets to the farm")]
        public void WhenTheSupervisorGetsToTheFarm()
        {
            if (_numberOfAnimals != 0)
            {
                _animals = AnimalFarm.GetAnimals(_numberOfAnimals);
            }
            else
            {
                _animals = AnimalFarm.GetAnimals(_carnivores, _herbivores);
            }
        }
    }
}