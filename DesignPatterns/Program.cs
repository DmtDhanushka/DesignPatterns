using DesignPatterns;


// Usage Example
class Program
{
    static void Main(string[] args)
    {
        // Create a subject (Weather Station)
        WeatherStation weatherStation = new WeatherStation();

        // Create observers (Phone Display, Window Display)
        PhoneDisplay phoneDisplay = new PhoneDisplay();
        WindowDisplay windowDisplay = new WindowDisplay();

        // Attach observers to the subject
        weatherStation.Attach(phoneDisplay);
        weatherStation.Attach(windowDisplay);

        // Change the temperature, which will notify all observers
        weatherStation.SetTemperature(25);  // Output: Phone Display: Updated temperature is 25°C. Window Display: Updated temperature is 25°C.
        weatherStation.SetTemperature(30);  // Output: Phone Display: Updated temperature is 30°C. Window Display: Updated temperature is 30°C.

        // Detach an observer (Phone Display)
        weatherStation.Detach(phoneDisplay);
        weatherStation.SetTemperature(35);  // Output: Window Display: Updated temperature is 35°C.
    }
}