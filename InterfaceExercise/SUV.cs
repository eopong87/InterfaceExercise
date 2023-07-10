using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string Logo { get; set; }
        public string Radio { get; set; }
        public int NumOfWheels { get; set; }
        public bool HasSeats { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }

        public bool DrivesFast { get; set; } = true;


        public bool HasAHorn { get; set; } = true;

        void IVehicle.drive()
        {
            Console.WriteLine();
        }

        void IVehicle.honks()
        {
            Console.WriteLine(); 
        }

        void IVehicle.RunsOnGas()
        {
            Console.WriteLine(); 
        }
    }
}
      

















