using System.Collections.Generic;

namespace CircusTrain
{
    public class Train
    {
        public List<Wagon> Wagons = new List<Wagon>();

        public void UpdateWagon(Wagon wagon)
        {
            Wagons[Wagons.FindIndex(w => w.Id == wagon.Id)] = wagon;
        }
    }
}