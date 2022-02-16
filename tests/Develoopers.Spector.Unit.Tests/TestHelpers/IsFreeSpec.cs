namespace Develoopers.Spector.Unit.Tests.TestHelpers;

public class IsFreeSpec : ISpector<Subscription>
{
    public bool IsSatisfiedBy(Subscription obj) => obj.Price == 0;
}