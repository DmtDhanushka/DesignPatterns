using System;

namespace DesignPatterns
{
    // Main program to demonstrate the Builder Pattern
    class Program
    {
        static void Main(string[] args)
        {
            // Building a Computer with required components and optional WiFi and Bluetooth
            Computer gamingPC = new Computer.ComputerBuilder("Intel i9", "NVIDIA RTX 3080", 32, 1024)
                .AddWiFi(true)
                .AddBluetooth(true)
                .Build();

            // Display the configured gaming PC
            Console.WriteLine(gamingPC);
            // Output: Computer [CPU=Intel i9, GPU=NVIDIA RTX 3080, RAM=32GB, Storage=1024GB, WiFi=True, Bluetooth=True]

            // Building a basic Computer without optional WiFi or Bluetooth
            Computer officePC = new Computer.ComputerBuilder("Intel i5", "Intel Integrated", 8, 256)
                .Build();

            // Display the configured office PC
            Console.WriteLine(officePC);
            // Output: Computer [CPU=Intel i5, GPU=Intel Integrated, RAM=8GB, Storage=256GB, WiFi=False, Bluetooth=False]
        }
    }
}
