using OopsConcepts.Interfaces;

namespace OopsConcepts.Classes
{
    public class Car : IVehicle, IFourWheeler
    {
        public void Drive()
        {
            Console.WriteLine("Driving");
        }

        public void FuelUp()
        {
            Console.WriteLine("Fueling");
        }

        public void GetTyrePressure()
        {
            Console.WriteLine("Giving Tyre Pressure");
        }
    }
}
