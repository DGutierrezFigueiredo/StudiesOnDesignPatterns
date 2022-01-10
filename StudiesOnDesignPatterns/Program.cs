using StudiesOnDesignPatterns.Patterns.Strategy_Pattern;
using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Entities;
using System;

namespace StudiesOnDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadKey();
            //The different patterns are stored in the 'Patterns' folder
        }
    }
}
