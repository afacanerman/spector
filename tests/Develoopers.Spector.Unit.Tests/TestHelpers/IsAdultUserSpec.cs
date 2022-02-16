namespace Develoopers.Spector.Unit.Tests.TestHelpers;

public class IsAdultUserSpec : ISpector<User>
{
    public bool IsSatisfiedBy(User obj) => obj.Age > 18;
}

public class IsValidUserSpec : ISpector<User>
{
    public bool IsSatisfiedBy(User obj) => !string.IsNullOrEmpty(obj.Name);
}