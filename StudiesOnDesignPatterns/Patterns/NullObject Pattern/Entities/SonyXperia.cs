using StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Interfaces;
using System;

namespace StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Infrastructure
{
    internal class SonyXperia : IMobile
    {
        public void TurnDeviceOff()
        {
            Console.WriteLine("\nSony Xperia Turned OFF!");
        }

        public void TurnDeviceOn()
        {
            Console.WriteLine("\nSony Xperia Turned ON!");
        }
    }
}