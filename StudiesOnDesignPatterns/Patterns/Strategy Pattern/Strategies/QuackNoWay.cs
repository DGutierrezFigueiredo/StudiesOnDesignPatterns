using StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Strategy_Pattern.Strategies
{
    public class QuackNoWay : IQuackBehavior

    {
        public void Quack()
        {
            Console.WriteLine("****Silence*****");
        }
    }
}
