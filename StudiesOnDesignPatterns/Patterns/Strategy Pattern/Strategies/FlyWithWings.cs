using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Strategies
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Watch me soar, into the skies, I'm as free as a bird should be");
        }
    }
}
