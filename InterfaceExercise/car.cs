using System;
namespace InterfaceExercise
{
    public class Car: IVehicle, ICompany
    {
        public string Logo { get; set; }
        public string Radio { get; set; }
        public int NumOfWheels { get; set; }
        public bool HasSeats { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }

        public int NumOfDoors { get; set; } = 4;
        public string TypeOfCar { get; set; } = "sudean";
        int IVehicle.NumOfWheels { get; set; }
        bool IVehicle.HasSeats {  get; set; }
        string IVehicle.Make {  get; set; }
        string IVehicle.Color { get; set; }
     
        void IVehicle.drive()
        {
            throw new NotImplementedException();
        }

        void IVehicle.honks()
        {
            throw new NotImplementedException();
        }

        void IVehicle.RunsOnGas()
        {
            throw new NotImplementedException();
        }
    }
}

