using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.PizzaIngredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public  IClam CreateClam()
        {
            return new FrozenClam();
        }

        public  IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public  IPepperoni CreatePepperoni()
        {
            return new ShreddedPepperoni();
        }

        public  ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public  List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie> { new RedOnion(), new ShiitakeMushroom(), new SunDriedTomato() };
        }
    }
}
