using StudiesOnDesignPatterns.Patterns.Observer.Interfaces;
using StudiesOnDesignPatterns.Patterns.Observer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Observer.Entities
{
    public class ThirdPartyDevice : IDisplayElement
    {
        private IDisplayElement _displayElement;

        public ThirdPartyDevice(IDisplayElement displayElement)
        {
            _displayElement = displayElement;
        }
        public void Display()
        {
            Console.Write($"Posted from My Unknown Device: ");
            _displayElement.Display();
        }


    }
}
