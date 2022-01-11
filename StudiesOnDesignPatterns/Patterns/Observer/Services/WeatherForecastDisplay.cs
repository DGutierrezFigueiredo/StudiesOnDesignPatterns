using StudiesOnDesignPatterns.Patterns.Observer.Entities;
using StudiesOnDesignPatterns.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Observer.Services
{
    public class WeatherForecastDisplay : IObserver
    {
        private WeatherData _weatherData = new WeatherData();
        private string _weatherForecast { get; set; }

        public void GetWeatherForecast()
        {
            Console.WriteLine($"Temperature for today is {_weatherData.Temperature}°. {_weatherForecast}"); 
        }

        public void SetWeatherForecast()
        {
            if(_weatherData.Temperature > 30) _weatherForecast = "Good day to go to the beach";
            _weatherForecast = "You might consider taking a coat with you";
        }

        public void Update()
        {
            this.SetWeatherForecast();
        }
    }
}
