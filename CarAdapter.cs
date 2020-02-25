using System;
using System.Collections.Generic;
using System.Text;

namespace adapterPattern
{
    public class CarAdapter : CarInterface
    {
        RacingCar racingCar = new RacingCar();
        public double getCarFuelCap()
        {
            return racingCar.getCarFuelCapacity();
        }

        public string getfullCarname()
        {
            return racingCar.getMake() + " " + racingCar.getModel() + " " + racingCar.getYear();
        }

        public int getMaxSpeed()
        {
            return racingCar.getTopSpeedRacingMode();
        }
    }
}
