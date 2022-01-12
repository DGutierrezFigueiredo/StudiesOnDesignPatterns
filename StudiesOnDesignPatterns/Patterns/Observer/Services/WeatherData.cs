using StudiesOnDesignPatterns.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Observer.Entities
{
    public class WeatherData : IObservable, IObserver , IWeatherData
    {
        IWeatherMonitoringStation _weatherMonitoringStation;

        public WeatherData(IWeatherMonitoringStation weatherMonitoringStation)
        {
            _weatherMonitoringStation = weatherMonitoringStation;
        }
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

        public void SubscribeObserver(IObserver observer)
        {
            listOfObservers.Add(observer);
        }

        public void UnsubscribeObserver(IObserver observer)
        {
            listOfObservers.Remove(observer);
        }

        public void Update()
        {
            Temperature = _weatherMonitoringStation.Temperature;
            Humidity = _weatherMonitoringStation.Humidity;
            Pressure = _weatherMonitoringStation.Pressure;
            NotifyObservers();
        }
    }
}
