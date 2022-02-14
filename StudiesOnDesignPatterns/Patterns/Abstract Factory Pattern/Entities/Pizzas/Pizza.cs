using StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.PizzaIngredients;
using StudiesOnDesignPatterns.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Abstract_Factory_Pattern.Entities.Pizzas
{
    public abstract class Pizza
    {
        private string _name { get; set; }
        public IDough dough;
        public ISauce sauce;
        public List<IVeggie> veggies;
        public ICheese cheese;
        public IPepperoni pepperoni;
        public IClam clam;
                
        public abstract void PreparePizza();
        public virtual void BakePizza()
        {
            Console.WriteLine("Bake pizza for 25 minutes at 350 degrees °C");
        }
        public virtual void CutPizza()
        {
            Console.WriteLine("Cut pizza in 8 diagonal slices\n");
        }
        public void BoxPizza()
        {
            Console.WriteLine("Put pizza in official franchise pizza box");
        }
        internal void SetPizzaName(string name)
        {
            _name = name;
        }
        public string GetPizzaName()
        {
            return _name;
        }


    }
}
