using StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Entities
{
    class HouseBlend : Beverage
    {
        public string description = "House Blend";

        public override decimal Cost()
        {
            return (decimal)1.99;
        }

        public override string GetDescription()
        {
            return description;
        }
    }
}
