using System;

namespace adapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            getCarInfo();

            void getCarInfo()
            {
                CarAdapter carAdapter = new CarAdapter();
                Console.WriteLine(" Car Info: \n");
                Console.WriteLine(" Car Fuel Cap: {0} \n Car Full Name: {1} \n Car Max Speed: {2} \n", carAdapter.getCarFuelCap(), carAdapter.getfullCarname(), carAdapter.getMaxSpeed());
                Console.WriteLine("\n\n Press enter to display info again");
                Console.ReadLine();
                getCarInfo();
            }
        }
    }
}
