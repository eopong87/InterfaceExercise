using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string Logo { get; set; }
        public bool Radio { get; set; }
        public int NumOfWheels { get; set; }
        public bool HasSeats { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }

        public bool HasFlatBed { get; set; } = true;
        public bool SunRoof { get; set; } = true;
        string ICompany.Radio { get; set; }

        public void drive()
        {
            Console.WriteLine();
        }

        public void honks()
        {
            Console.WriteLine();
        }

        public void RunsOnGas()
        {
            Console.WriteLine();
        }
    }








}