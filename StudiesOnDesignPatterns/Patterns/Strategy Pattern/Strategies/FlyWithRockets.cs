using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Strategies
{
    class FlyWithRockets : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can now go far and beyond! My rockets take me where no duck's ever been before!");        }
    }
}
