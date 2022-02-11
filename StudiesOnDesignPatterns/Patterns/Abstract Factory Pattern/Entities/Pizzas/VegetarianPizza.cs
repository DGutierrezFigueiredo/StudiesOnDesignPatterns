using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Factories;
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

        }
    }
}
