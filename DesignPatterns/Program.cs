using System;

namespace DesignPatterns
{
    // Main program to demonstrate the Factory Pattern
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of VehicleFactory
            VehicleFactory vehicleFactory = new VehicleFactory();

            // Request a "Car" from the factory
            IVehicle car = vehicleFactory.GetVehicle("car");
            car.Drive(); // Output: Driving a car!

            // Request a "Bike" from the factory
            IVehicle bike = vehicleFactory.GetVehicle("bike");
            bike.Drive(); // Output: Riding a bike!

            // Example of an invalid type
            try
            {
                IVehicle unknown = vehicleFactory.GetVehicle("plane");
                unknown.Drive(); // This line won't execute due to the exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Output: Unknown vehicle type.
            }
        }
    }
}
