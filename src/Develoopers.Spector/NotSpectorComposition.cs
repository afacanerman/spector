namespace Develoopers.Spector
{
    public class NotSpectorComposition<T> : ISpector<T>
    {
        private readonly ISpector<T> _operand;

        public NotSpectorComposition(ISpector<T> operand)
        {
            _operand = operand ?? new FalseSpec<T>();
        }

        public bool IsSatisfiedBy(T obj) => !_operand.IsSatisfiedBy(obj);
    }
}