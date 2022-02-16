namespace Develoopers.Spector.Unit.Tests.TestHelpers;

public class User
{
    public User(int age, string? name)
    {
        Age = age;
        Name = name;
    }

    public int Age { get; }
    public string? Name { get; }
}