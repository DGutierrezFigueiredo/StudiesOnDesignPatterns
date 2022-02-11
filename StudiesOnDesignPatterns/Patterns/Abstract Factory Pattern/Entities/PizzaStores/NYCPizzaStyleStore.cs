using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.Pizzas;
using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.PizzaStores
{
    public class NYCPizzaStyleStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaFlavors pizzaName)
        {
            return null;
        }
    }
}
