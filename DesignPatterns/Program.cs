using System;

namespace DesignPatterns
{
    // Main program to demonstrate the Observer Pattern
    class Program
    {
        static void Main(string[] args)
        {
            // Create a WeatherStation instance
            WeatherStation weatherStation = new WeatherStation();

            // Create observers
            PhoneDisplay phoneDisplay = new PhoneDisplay();
            WindowDisplay windowDisplay = new WindowDisplay();

            // Attach observers to the WeatherStation
            weatherStation.Attach(phoneDisplay);
            weatherStation.Attach(windowDisplay);

            // Simulate temperature updates
            weatherStation.SetTemperature(25); // Both displays receive the update
            // Output:
            // Weather Station: Temperature updated to 25°C.
            // Phone Display: Updated temperature is 25°C.
            // Window Display: Updated temperature is 25°C.

            weatherStation.SetTemperature(30); // Both displays receive the new update
            // Output:
            // Weather Station: Temperature updated to 30°C.
            // Phone Display: Updated temperature is 30°C.
            // Window Display: Updated temperature is 30°C.

            // Detach the PhoneDisplay
            weatherStation.Detach(phoneDisplay);

            // Update temperature again, only WindowDisplay will receive the update
            weatherStation.SetTemperature(20);
            // Output:
            // Weather Station: Temperature updated to 20°C.
            // Window Display: Updated temperature is 20°C.
        }
    }
}
