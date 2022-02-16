# Spector
Specification Pattern

It's a specification pattern that is used to encapsulate piece of domain knowledge into single unit. So that It's re-usable and easily testable.

### Simple Usage
Considering the following example:
```cs
public class User
{
    public void User(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public string Name { get; set; }
    public int Age { get; set; }
}

public class IsAdultUserSpec : ISpector<User>
{
    public bool IsSatisfiedBy(User user)
    {
        return user.Age >= 18;
    }
}
```

The usage would be as follows:
```cs
var user = new UserModel("John", 20);
var isAdultUserSpec = new IsAdultUserSpec();
isAdultUser.IsSatisfiedBy(user)
```