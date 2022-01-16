using StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Entities
{
    public class DarkRoast : Beverage
    {
        public override decimal Cost()
        {
            return (decimal)1.00;
        }

        public override string GetDescription()
        {
            return "Dark Roast";
        }
    }
}
