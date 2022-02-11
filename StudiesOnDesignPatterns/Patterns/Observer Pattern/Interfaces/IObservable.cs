using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesOnDesignPatterns.Patterns.Observer.Interfaces
{
    public interface IObservable
    {
        public void SubscribeObserver(IObserver observer);
        public void UnsubscribeObserver(IObserver observer);
        public void NotifyObservers();
    }
}
