using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Entities
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new QuackNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a rubber Duck and I love bubble baths!"); 
        }
    }
}
