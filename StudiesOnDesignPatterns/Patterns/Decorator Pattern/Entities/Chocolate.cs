using StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Entities
{
    public class Chocolate : CondimentDecorator
    {
        Beverage _beverage;

        public Chocolate(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override decimal Cost()
        {
            return (decimal)0.40 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Chocolate";
        }
                
    }
}
