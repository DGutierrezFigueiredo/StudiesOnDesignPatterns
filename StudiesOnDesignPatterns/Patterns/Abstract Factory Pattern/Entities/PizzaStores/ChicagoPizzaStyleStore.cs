using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.Pizzas;
using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Enums;
using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.PizzaStores
{
    public class ChicagoPizzaStyleStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaFlavor pizzaName)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory _chicagoPizzaIngredientFactory = new ChicagoPizzaIngredientFactory();

            switch (pizzaName)
            {
                case PizzaFlavor.Cheese:
                    pizza = new CheesePizza(_chicagoPizzaIngredientFactory);
                    pizza.SetPizzaName("Cheese Pizza Chicago Style");
                    break;
                case PizzaFlavor.Clam:
                    pizza = new ClamPizza(_chicagoPizzaIngredientFactory);
                    pizza.SetPizzaName("Clam Pizza Chicago Style");
                    break;
                case PizzaFlavor.Pepperoni:
                    pizza = new PepperoniPizza(_chicagoPizzaIngredientFactory);
                    pizza.SetPizzaName("Pepperoni Pizza Chicago Style");
                    break;
                case PizzaFlavor.Vegetarian:
                    pizza = new VegetarianPizza(_chicagoPizzaIngredientFactory);
                    pizza.SetPizzaName("Vegetarian Pizza Chicago Style");
                    break;
                default:
                    Console.WriteLine("Invalid Pizza Flavor");
                    break;
            }
            return pizza;
        }
    }
}
