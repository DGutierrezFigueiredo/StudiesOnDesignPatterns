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
    public class NYCPizzaStyleStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaFlavors pizzaName)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory _nycPizzaIngredientFactory = new NYCPizzaIngredientFactory();

            switch (pizzaName)
            {
                case PizzaFlavors.Cheese:
                    pizza = new CheesePizza(_nycPizzaIngredientFactory);
                    pizza.SetPizzaName("Cheese Pizza NYC Style");
                    break;
                case PizzaFlavors.Clam:
                    pizza = new ClamPizza(_nycPizzaIngredientFactory);
                    pizza.SetPizzaName("Clam Pizza NYC Style");
                    break;
                case PizzaFlavors.Pepperoni:
                    pizza = new PepperoniPizza(_nycPizzaIngredientFactory);
                    pizza.SetPizzaName("Pepperoni Pizza NYC Style");
                    break;
                case PizzaFlavors.Vegetarian:
                    pizza = new VegetarianPizza(_nycPizzaIngredientFactory);
                    pizza.SetPizzaName("Vegetarian Pizza NYC Style");
                    break;
                default:
                    Console.WriteLine("Invalid Pizza Flavor");
                    break;
            }
            return pizza;

        }
    }
}
