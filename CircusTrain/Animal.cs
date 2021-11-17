using System.Drawing;

namespace CircusTrain
{
    public class Animal
    {
        public FoodPreferenceEnum FoodPreference { get; }
        public int Size { get; }
        public bool isPlaced = false;


        public Animal(SizeEnum sizeEnum, FoodPreferenceEnum foodPreference)
        {
            switch (sizeEnum)
            {
                case SizeEnum.Small:
                    Size = 1;
                    break;
                case SizeEnum.Medium:
                    Size = 3;
                    break;
                case SizeEnum.Large:
                    Size = 5;
                    break;
            }

            FoodPreference = foodPreference;
        }
        public enum SizeEnum
        {
            Small,
            Medium,
            Large
        }
        public enum FoodPreferenceEnum
        {
            Herbivore,
            Carnivore
        };
        
    }
}