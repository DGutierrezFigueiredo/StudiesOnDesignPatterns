using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.Pizzas
{
    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void PreparePizza()
        {
            Console.WriteLine("Preparing a " + GetPizzaName());
            cheese = _pizzaIngredientFactory.CreateCheese();
            dough = _pizzaIngredientFactory.CreateDough();
            sauce = _pizzaIngredientFactory.CreateSauce();

        }
    }
}
