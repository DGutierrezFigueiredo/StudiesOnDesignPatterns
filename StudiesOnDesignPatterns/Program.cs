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
            WeatherMonitoringStation weatherStation = new WeatherMonitoringStation();
            WeatherData weatherData = new WeatherData(weatherStation);
            WeatherForecastDisplay forecastDisplay = new WeatherForecastDisplay(weatherData);

            weatherStation.SubscribeObserver(weatherData);
            //weatherData.SubscribeObserver(forecastDisplay);

            weatherStation.SetWeatherConditions();

            forecastDisplay.GetWeatherForecast();

            weatherStation.SetWeatherConditions();

            forecastDisplay.GetWeatherForecast();

            Console.ReadKey();
            //The different patterns are stored in the 'Patterns' folder
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
