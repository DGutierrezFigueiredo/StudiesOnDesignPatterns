using StudiesOnDesignPatterns.Patterns.Observer.Interfaces;

namespace StudiesOnDesignPatterns.Patterns.Observer.Entities
{
    public interface IWeatherData
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        
        public void NotifyObservers();
        

        public void SubscribeObserver(IObserver observer);


        public void UnsubscribeObserver(IObserver observer);


        public void Update();
       
    }
}