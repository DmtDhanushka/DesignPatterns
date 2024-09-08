using DesignPatterns;

// Usage Example
class Program
{
    static void Main(string[] args)
    {
        VehicleFactory factory = new VehicleFactory();

        // Creating a car
        IVehicle vehicle1 = factory.GetVehicle("car");
        vehicle1.Drive();  // Output: Driving a car!

        // Creating a bike
        IVehicle vehicle2 = factory.GetVehicle("bike");
        vehicle2.Drive();  // Output: Riding a bike!
    }
}