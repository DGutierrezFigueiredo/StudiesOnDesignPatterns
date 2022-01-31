using StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Entities
{
    public class Espresso : Beverage
    {
        public override decimal Cost()
        {
            return (decimal)0.85;
        }

        public override string GetDescription()
        {
            return "Expresso";
        }
    }
}
