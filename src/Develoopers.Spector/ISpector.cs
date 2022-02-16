namespace Develoopers.Spector
{
    public interface ISpector<in T>
    {
        bool IsSatisfiedBy(T obj);
    }
}