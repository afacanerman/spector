namespace Develoopers.Spector
{
    public class AndSpectorComposition<T> : ISpector<T>
    {
        private readonly ISpector<T> _operandA;
        private readonly ISpector<T> _operandB;

        public AndSpectorComposition(ISpector<T> operandA, ISpector<T> operandB)
        {
            _operandA = operandA ?? new FalseSpec<T>();
            _operandB = operandB ?? new FalseSpec<T>();
        }

        public bool IsSatisfiedBy(T obj) =>
            _operandA.IsSatisfiedBy(obj) && _operandB.IsSatisfiedBy(obj);
    }
}