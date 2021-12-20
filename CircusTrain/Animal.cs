using System.Drawing;

namespace CircusTrain
{
    public class Animal
    {
        public FoodPreferenceEnum FoodPreference { get; }
        public int Size
        {
            get { return (int)SizeE; }

        }
        public bool isPlaced = false;
        public SizeEnum SizeE = SizeEnum.Small;


        public Animal(SizeEnum sizeEnum, FoodPreferenceEnum foodPreference)
        {
            SizeE = sizeEnum;
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
            Small = 1,
            Medium = 3,
            Large = 5
        }
        public enum FoodPreferenceEnum
        {
            Herbivore,
            Carnivore
        };
        
    }
}