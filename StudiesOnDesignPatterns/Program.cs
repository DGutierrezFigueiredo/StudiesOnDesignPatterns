using StudiesOnDesignPatterns.Patterns.Strategy_Pattern;
using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Entities;
using System;

namespace StudiesOnDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Mallard Duck test");

            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();

            Console.WriteLine();

            Console.Write("Rubber Duck test");

            Duck rubber = new RubberDuck();
            rubber.PerformFly();
            rubber.PerformQuack();

            Console.ReadKey();
            //The different patterns are stored in the 'Patterns' folder
        }
    }
}
