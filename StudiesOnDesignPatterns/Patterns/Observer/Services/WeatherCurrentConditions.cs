using StudiesOnDesignPatterns.Patterns.Observer.Entities;
using StudiesOnDesignPatterns.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Observer.Services
{
    public class WeatherCurrentConditions : IObserver , IDisplayElement
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }

        IWeatherData _weatherData;
        public WeatherCurrentConditions(IWeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.SubscribeObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Temperature todays is {Temperature}° and the humidity is of {Humidity}%.");
        }

        public void Update()
        {
            Temperature = _weatherData.Temperature;
            Humidity = _weatherData.Humidity;
        }
    }
}
