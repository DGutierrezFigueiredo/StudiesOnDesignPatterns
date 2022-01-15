using StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Interfaces;

namespace StudiesOnDesignPatterns.Patterns.NullObject_Pattern.Infrastructure
{
    public interface IMobileRepository
    {
        public IMobile GetMobileByName(string mobileName);
    }
}