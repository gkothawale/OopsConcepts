using OopsConcepts.Interfaces;

namespace OopsConcepts.Classes
{
    public class Car : IVehicle, IFourWheeler
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void FuelUp()
        {
            throw new NotImplementedException();
        }

        public void GetTyrePressure()
        {
            throw new NotImplementedException();
        }
    }
}
