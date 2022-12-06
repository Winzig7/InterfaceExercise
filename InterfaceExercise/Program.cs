using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
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
            Car myFirstCar = new Car { Make = "Jeep", Year = "2004", Model = "Grand Cherokee", hasTrunk = true };
            Motorcycle myFirstMotor = new Motorcycle { Model = "Something", Make = "Harley", Year = "2000", hasSideCar = false };
            Truck myFirstTruck = new Truck { Make = "??", Model = "??", Year = "2022", hasTrunk = true };
            List<IVehicle> Vehicles = new List<IVehicle>();
            Vehicles.Add(myFirstMotor);
            Vehicles.Add(myFirstCar);
            Vehicles.Add(myFirstTruck);

            foreach (IVehicle vehicle in Vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make} Model: {vehicle.Model} Year: {vehicle.Year}");
                Console.WriteLine();
                vehicle.Drive();
            }
            
          }
    }
}
