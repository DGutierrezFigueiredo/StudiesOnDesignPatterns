using StudiesOnDesignPatterns.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Observer.Entities
{
    public class WeatherMonitoringStation : IObservable
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        List<IObserver> listOfObservers = new List<IObserver>();

        public void NotifyObservers()
        {
            foreach (IObserver observer in listOfObservers)
            {
                observer.Update();
            }
        }

        public void SetWeatherConditions()
        {
            Random rng = new Random(50);
            Random rng2 = new Random(100);

            Temperature = rng.Next();
            Humidity = rng2.Next();
            Pressure = rng2.Next();
            NotifyObservers();
        }

        public void SubscribeObserver(IObserver observer)
        {
            listOfObservers.Add(observer);
        }

        public void UnsubscribeObserver(IObserver observer)
        {
            listOfObservers.Remove(observer);
        }
    }
}
