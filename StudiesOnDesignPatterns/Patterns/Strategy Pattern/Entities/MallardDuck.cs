using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Interfaces;
using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Entities
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new QuackRealDeal();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard duck!");
        }
    }
}
