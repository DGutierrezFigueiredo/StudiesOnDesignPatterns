using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Strategy_Pattern
{
    public abstract class Duck
    {
        internal IFlyBehavior _flyBehavior;
        internal IQuackBehavior _quackBehavior;

        
        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("We all float in here, Georgie");
        }

        public abstract void Display();
        
    }
}
