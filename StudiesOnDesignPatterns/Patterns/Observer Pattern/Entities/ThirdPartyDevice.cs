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
        List<IDisplayElement> listOfServicesOnDevice = new List<IDisplayElement>();

        public ThirdPartyDevice(IDisplayElement displayElement)
        {
            listOfServicesOnDevice.Add(displayElement);
        }

        public void AddServiceToDeviceList(IDisplayElement displayElement)
        {
            listOfServicesOnDevice.Add(displayElement);
        }

        public void RemoveServiceFromDeviceList(IDisplayElement displayElement)
        {
            listOfServicesOnDevice.Remove(displayElement);
        }

        public void Display()
        {
            Console.Write("Posted from My Unknown Device: ");

            foreach (IDisplayElement element in listOfServicesOnDevice)
            {
                element.Display();
            }

        }


    }
}
