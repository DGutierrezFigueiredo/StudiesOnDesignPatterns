using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Infrastructure;
using StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Infrastructure.Tests
{
    [TestClass()]
    public class MobileRepositoryTests
    {
        [TestMethod()]
        public void GetMobileByNameTest()
        {
            MobileRepository mobileRepository = new MobileRepository();
            IMobile mobile = mobileRepository.GetMobileByName("sony");
            IMobile mobile2 = mobileRepository.GetMobileByName("Xiaomi");

            mobile.TurnDeviceOn();
            mobile2.TurnDeviceOn();

            Assert.IsNotNull(mobile2);
            Assert.IsTrue(mobile != mobile2);
            
        }
    }
}