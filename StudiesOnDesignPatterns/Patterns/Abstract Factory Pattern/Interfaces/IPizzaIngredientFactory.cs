using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.PizzaIngredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Factories
{
    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough();
        public ICheese CreateCheese();
        public ISauce CreateSauce();
        public List<IVeggie> CreateVeggies();
        public IPepperoni CreatePepperoni();
        public IClam CreateClam();


    }
}
