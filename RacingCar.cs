using System;
using System.Collections.Generic;
using System.Text;

namespace adapterPattern
{
    public class RacingCar
    {
        public int normalTopSpeed = 100;
        public int carYear = 2016;
        public int carFuelCapacity = 50;
        public string carMake = "Ford";
        public string carModel = "GT MK II";

        public int getTopSpeedRacingMode()
        {
            return normalTopSpeed + 50;
        }

        public int getTopSpeedNormalMode()
        {
            return normalTopSpeed;
        }

        public int getCarFuelCapacity()
        {
            return carFuelCapacity;
        }

        public string getMake()
        {
            return carMake;
        }

        public string getModel()
        {
            return carModel;
        }

        public int getYear()
        {
            return carYear;
        }
    }
}
