namespace Develoopers.Spector
{
    public class FalseSpec<T> : ISpector<T>
    {
        public bool IsSatisfiedBy(T obj) => false;
    }
}