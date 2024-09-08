using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    // Product class with several attributes
    public class Computer
    {
        public string CPU { get; private set; }
        public string GPU { get; private set; }
        public int RAM { get; private set; }
        public int Storage { get; private set; }
        public bool HasWiFi { get; private set; }
        public bool HasBluetooth { get; private set; }

        // Private constructor
        private Computer(ComputerBuilder builder)
        {
            CPU = builder.CPU;
            GPU = builder.GPU;
            RAM = builder.RAM;
            Storage = builder.Storage;
            HasWiFi = builder.HasWiFi;
            HasBluetooth = builder.HasBluetooth;
        }

        // Builder Class
        public class ComputerBuilder
        {
            // Required parameters
            public string CPU { get; private set; }
            public string GPU { get; private set; }
            public int RAM { get; private set; }
            public int Storage { get; private set; }

            // Optional parameters
            public bool HasWiFi { get; private set; }
            public bool HasBluetooth { get; private set; }

            // Constructor with mandatory attributes
            public ComputerBuilder(string cpu, string gpu, int ram, int storage)
            {
                CPU = cpu;
                GPU = gpu;
                RAM = ram;
                Storage = storage;
            }

            // Methods for setting optional attributes
            public ComputerBuilder AddWiFi(bool hasWiFi)
            {
                HasWiFi = hasWiFi;
                return this;
            }

            public ComputerBuilder AddBluetooth(bool hasBluetooth)
            {
                HasBluetooth = hasBluetooth;
                return this;
            }

            // Build method to return a fully constructed Computer object
            public Computer Build()
            {
                return new Computer(this);
            }
        }

        // Override ToString to display computer configuration
        public override string ToString()
        {
            return $"Computer [CPU={CPU}, GPU={GPU}, RAM={RAM}GB, Storage={Storage}GB, WiFi={HasWiFi}, Bluetooth={HasBluetooth}]";
        }
    }


}
