using StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Entities;
using StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Infrastructure
{
    public class MobileRepository : IMobileRepository
    {
        public IMobile GetMobileByName(string mobileName)
        {
            IMobile mobile = NullMobile.Instance;

            switch (mobileName)
            {
                case ("sony"):
                    mobile = new SonyXperia();
                    break;
                case ("samsung"):
                    mobile = new SamsungGalaxy();
                    break;
            }

            return mobile;
        }


    }
}

