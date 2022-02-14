using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Factories;
using StudiesOnDesignPatterns.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.Pizzas
{
    public class VegetarianPizza : Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;

        public VegetarianPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void PreparePizza()
        {
            Console.WriteLine("Preparing a " + GetPizzaName());
            dough = _pizzaIngredientFactory.CreateDough();
            sauce = _pizzaIngredientFactory.CreateSauce();
            veggies = _pizzaIngredientFactory.CreateVeggies();
            Console.Write($"Preparing {CamelCaseSplitter.SplitCamelCase(dough.GetType().Name)}, " +
                              $"spreading {CamelCaseSplitter.SplitCamelCase(sauce.GetType().Name)}, " +
                              $"topping it with ");
            for (int i = 0; i < veggies.Count; i++)
            {
                if(i == veggies.Count - 1)
                {
                    Console.WriteLine($"and {CamelCaseSplitter.SplitCamelCase(veggies[i].GetType().Name)}  ");
                }
                else
                {
                    Console.Write($"{CamelCaseSplitter.SplitCamelCase(veggies[i].GetType().Name)}, ");
                }
                
            }

        }
    }
}
