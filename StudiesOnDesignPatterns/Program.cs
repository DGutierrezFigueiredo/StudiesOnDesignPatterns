using StudiesOnDesignPatterns.Patterns.Observer.Entities;
using StudiesOnDesignPatterns.Patterns.Observer.Services;
using StudiesOnDesignPatterns.Patterns.Strategy_Pattern;
using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Entities;
using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Strategies;
using System;

namespace StudiesOnDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //The different patterns are stored in the 'Patterns' folder

            ObserverPattern();

            Console.ReadKey();

        }

        private static void ObserverPattern()
        {
            WeatherMonitoringStation weatherStation = new WeatherMonitoringStation();
            WeatherData weatherData = new WeatherData(weatherStation);
            WeatherForecastDisplay forecastDisplay = new WeatherForecastDisplay(weatherData);
            WeatherCurrentConditions weatherCurrentConditions = new WeatherCurrentConditions(weatherData);

            weatherStation.SetWeatherConditions();

            forecastDisplay.Display();

            weatherStation.SetWeatherConditions();

            ThirdPartyDevice unknownDevice = new ThirdPartyDevice(weatherCurrentConditions);

            unknownDevice.Display();
        }

        
        private static void StrategyPattern()
        {
            Console.WriteLine("Mallard Duck test");

            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
            mallard.Swim();
            mallard.Display();

            Console.WriteLine();

            Console.WriteLine("Rubber Duck test");

            Duck rubber = new RubberDuck();
            rubber.PerformFly();
            rubber.PerformQuack();
            rubber.Swim();
            rubber.Display();

            Console.WriteLine();

            Console.WriteLine("Dynamic Rocket Duck test");

            Duck rocketDuck = new DynamicRocketModelDuck();
            rocketDuck.PerformFly();
            rocketDuck.PerformQuack();
            rocketDuck.SetFlyBehavior(new FlyWithRockets());
            rocketDuck.PerformFly();
            rocketDuck.Swim();
            rocketDuck.Display();
        }
    }
}
