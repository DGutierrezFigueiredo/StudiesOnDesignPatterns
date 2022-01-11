using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Observer.Interfaces
{
    public interface IObservable
    {
        //SubscribeObserver(Observer o)
        public void SubscribeObserver(IObserver observer);
        //UnsubscribeObserver(Observer o)
        public void UnsubscribeObserver(IObserver observer);
        //NotifyObservers()
        public void NotifyObservers();
    }
}
