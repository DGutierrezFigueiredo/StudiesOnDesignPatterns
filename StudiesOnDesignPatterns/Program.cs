using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.Pizzas;
using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.PizzaStores;
using StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Entities;
using StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Interfaces;
using StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Infrastructure;
using StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Interfaces;
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

            PizzaStore nycPizzaStore = new NYCPizzaStyleStore();
            Pizza clamPizza = nycPizzaStore.OrderPizza(Patterns.Abstract_Factory_Pattern.Enums.PizzaFlavor.Clam);
            clamPizza.PreparePizza();
            clamPizza.BakePizza();
            clamPizza.BoxPizza();
            clamPizza.CutPizza();

            PizzaStore chicagoPizzaStore = new ChicagoPizzaStyleStore();
            Pizza clamPizza2 = chicagoPizzaStore.OrderPizza(Patterns.Abstract_Factory_Pattern.Enums.PizzaFlavor.Clam);
            clamPizza2.PreparePizza();
            clamPizza2.BakePizza();
            clamPizza2.BoxPizza();
            clamPizza2.CutPizza();

            Console.ReadKey();

        }

        private static void DecoratorPattern()
        {
            Beverage beverage1 = new DarkRoast();

            Console.WriteLine(beverage1.GetDescription() + " R$" + string.Format("{0:N}", beverage1.Cost()));

            beverage1 = new Moccha(beverage1);
            beverage1 = new Chocolate(beverage1);

            Console.WriteLine(beverage1.GetDescription() + " R$" + string.Format("{0:N}", beverage1.Cost()));

            beverage1 = new Cinnamon(beverage1);

            Console.WriteLine(beverage1.GetDescription() + " R$" + string.Format("{0:N}", beverage1.Cost()));
        }

        private static void NullObjectPattern()
        {
            MobileRepository mobileRepository = new MobileRepository();
            IMobile mobile = mobileRepository.GetMobileByName("sony");
            mobile.TurnDeviceOff();
            mobile.TurnDeviceOn();

            mobile = mobileRepository.GetMobileByName("Xiaomi");
            mobile.TurnDeviceOn();
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
            unknownDevice.AddServiceToDeviceList(forecastDisplay);

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
