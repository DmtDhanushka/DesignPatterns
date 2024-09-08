using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    using System;

    // Product Interface
    public interface IVehicle
    {
        void Drive();
    }

    // Concrete Product Classes
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car!");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a bike!");
        }
    }

    // Factory Class
    public class VehicleFactory
    {
        // Factory method to create a vehicle
        public IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                default:
                    throw new ArgumentException("Unknown vehicle type.");
            }
        }
    }



}
