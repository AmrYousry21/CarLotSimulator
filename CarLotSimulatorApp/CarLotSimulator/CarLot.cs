using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        private List<Car> CarList;

        public static int numberOfCars = 0;

        public List<Car> CarsList
        {
            get { return CarList; }
            set { CarList = value; }
        }

    }
}
