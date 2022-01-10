using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Strategies
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Dead as a log. No wings, I go nowhere");
        }
    }
}
