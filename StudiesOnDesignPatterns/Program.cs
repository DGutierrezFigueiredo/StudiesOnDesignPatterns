using StudiesOnDesignPatterns.Patterns.Strategy_Pattern;
using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Entities;
using System;

namespace StudiesOnDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();

            Console.ReadKey();
            //The different patterns are stored in the 'Patterns' folder
        }
    }
}
