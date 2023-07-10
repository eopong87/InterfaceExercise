using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int NumOfWheels { get; set; }
		public bool HasSeats { get; set; }
		public string Make { get; set; }
		public string Color { get; set; }

		public void drive();
		public void honks();
		public void RunsOnGas();

	}
}

