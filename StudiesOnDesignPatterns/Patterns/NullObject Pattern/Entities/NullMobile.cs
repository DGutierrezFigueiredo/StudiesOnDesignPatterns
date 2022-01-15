using StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Entities
{
    public class NullMobile : IMobile
    {
        private static NullMobile _instance;

        public NullMobile()
        {

        }

        //singleton
        public static NullMobile Instance
        {
            get
            {
                if(_instance == null)
                {
                    return new NullMobile();
                }

                return _instance;
            }
                        
        }

        public void TurnDeviceOff()
        {
            //does nothing
            Console.WriteLine("\nSee? No exception here! But that could be bad... Refer to notes in NullObject class");
        }

        public void TurnDeviceOn()
        {
            //does nothing
            Console.WriteLine("\nSee? No exception here! But that could be bad... Refer to notes in NullObject class");
        }
    }
}
/*
 We have first created a variable of type IMobile and initialized it with an instance of NullMobile. 
 If the mobileName does not match a case in the switch statement, the NullMobile object is returned by 
 the GetMobileByName method. In our main logic, when we try to call methods on this object we will not get 
 any exception and hence the work flow will not break. However, the methods will do nothing.

*The null object pattern helps us to write a clean code avoiding null checks where ever possible.
*Using the null object pattern, the callers do not have to care whether they have a null object or a real object.
*It is not possible to implement null object pattern in every scenario. Sometimes, it is likely to return a null 
reference and perform some null checks.
*In above code sample, we are using an null object implementing an interface. However, we can have a quite similar 
approach with Abstract base class also.
*Null object is often a singleton. However, sometimes we want our object state to vary over instances.
*Null pattern is helpful in situations where we want to return an object of the expected type, yet do nothing.
*It is important to note that unless developers are aware that the null object implementation exists, they may 
still do null checks.
 */
