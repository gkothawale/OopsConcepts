namespace OopsConcepts.Classes
{
    public abstract class AClassVehicle
    {
        public abstract void FuelUp();
        public abstract void Service();

        public virtual void Drive()
        {
            Console.WriteLine("Driving");
        }

    }
}
