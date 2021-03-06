using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.Pizzas;
using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Enums;

namespace StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.PizzaStores
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaFlavor pizzaName)
        {
            return CreatePizza(pizzaName);
        }
        protected abstract Pizza CreatePizza(PizzaFlavor pizzaName);

    }
}
