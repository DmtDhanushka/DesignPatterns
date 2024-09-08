using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    // Subject Interface
    public interface ISubject
    {
        void Attach(IObserver observer);   // Subscribe an observer
        void Detach(IObserver observer);   // Unsubscribe an observer
        void Notify();                     // Notify all observers
    }

    // Concrete Subject Class
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int temperature;

        // Attach an observer
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        // Detach an observer
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        // Notify all observers
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }

        // Method to simulate temperature change and notify observers
        public void SetTemperature(int temp)
        {
            Console.WriteLine($"Weather Station: Temperature updated to {temp}°C.");
            temperature = temp;
            Notify();  // Notify all observers about the change
        }
    }

    // Observer Interface
    public interface IObserver
    {
        void Update(int temperature);  // Update method to be called by subject
    }

    // Concrete Observer Class 1
    public class PhoneDisplay : IObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine($"Phone Display: Updated temperature is {temperature}°C.");
        }
    }

    // Concrete Observer Class 2
    public class WindowDisplay : IObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine($"Window Display: Updated temperature is {temperature}°C.");
        }
    }

    

}
