using StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Entities
{
    public class SamsungGalaxy : IMobile
    {
        public void TurnDeviceOff()
        {
            Console.WriteLine("\nSamsung Galaxy Turned OFF!");
        }

        public void TurnDeviceOn()
        {
            Console.WriteLine("\nSamsung Galaxy Turned ON!");
        }
    }
}
