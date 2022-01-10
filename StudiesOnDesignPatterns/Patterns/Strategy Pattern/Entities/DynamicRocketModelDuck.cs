using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Entities
{
    class DynamicRocketModelDuck : Duck
    {
        public DynamicRocketModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new QuackRealDeal();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a dynamic Duck, I can change my fly pattern while doing it!");
        }
    }
}
