using System;

namespace Develoopers.Spector
{
    public class Spec<T> : ISpector<T>
    {
        private readonly Func<T, bool> _predicate;

        public Spec(Func<T, bool> predicate)
        {
            _predicate = predicate;
        }

        public bool IsSatisfiedBy(T obj) => _predicate(obj);
    }
}