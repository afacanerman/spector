namespace Develoopers.Spector
{
    public static class SpectorOperationExtensions
    {
        public static ISpector<T> Or<T>(this ISpector<T> self, ISpector<T> other) =>
            new OrSpectorComposition<T>(self, other);
        
        public static ISpector<T> And<T>(this ISpector<T> self, ISpector<T> other) =>
            new AndSpectorComposition<T>(self, other);
        
        public static ISpector<T> Not<T>(this ISpector<T> self) =>
            new NotSpectorComposition<T>(self);
    }
}