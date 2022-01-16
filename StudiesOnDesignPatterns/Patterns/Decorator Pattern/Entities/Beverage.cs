using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Decorator_Pattern.Interfaces
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";
        public abstract string GetDescription();
               
        public abstract decimal Cost();
        
    }
}
