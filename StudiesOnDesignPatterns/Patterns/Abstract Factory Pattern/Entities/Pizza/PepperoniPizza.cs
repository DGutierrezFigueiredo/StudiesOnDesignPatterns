using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.Pizza
{
    class PepperoniPizza : Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void PreparePizza()
        {
            Console.WriteLine("Preparing a " + GetPizzaName());
            dough = _pizzaIngredientFactory.CreateDough();
            sauce = _pizzaIngredientFactory.CreateSauce();
            pepperoni = _pizzaIngredientFactory.CreatePepperoni();

        }
    }
}
