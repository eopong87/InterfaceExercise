using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {


            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany- done

            //Create 3 classes called Car , Truck , & SUV - done

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; } - done
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var MyCar = new Car();
            {
                MyCar.Color = "red";
                MyCar.HasSeats = true;
                MyCar.NumOfDoors = 4;
            }

            var MyTruck = new Truck();
            {
                MyTruck.Logo = "chevy";
                MyTruck.SunRoof = false;
                MyTruck.Radio = true;

            }
            var MySuv = new SUV();

            {
                MySuv.Make = "sianna";
                MySuv.HasAHorn = true;
                MySuv.DrivesFast = false;
            }
            List<IVehicle> MyVehiclelist = new List<IVehicle>();
            MyVehiclelist.Add(MyCar);
            MyVehiclelist.Add(MySuv);
            MyVehiclelist.Add(MyTruck);

            foreach (var item in MyVehiclelist)
            {
                Console.WriteLine(item.honks);
                Console.WriteLine(item.HasSeats);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.NumOfWheels);
                Console.WriteLine(item.Color);
                Console.WriteLine(item.RunsOnGas);

            }

        }
    }
}

