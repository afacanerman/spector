# Spector
Specification Pattern

It's a specification pattern that is used to encapsulate piece of domain knowledge into single unit. So that It's re-usable and easily testable.

### Nuget
https://www.nuget.org/packages/Develoopers.Spector

```bash
dotnet add package Develoopers.Spector --version 1.0.0
```

### Simple Usage
Consider the following example:
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
    public bool IsSatisfiedBy(User user) => user.Age >= 18;
}

public class IsValidUserSpec : ISpector<User>
{
    public bool IsSatisfiedBy(User obj) => !string.IsNullOrEmpty(obj.Name);
}
```

The usage is as following:
```cs

// Simple Usage
var user = new UserModel("John", 20);
var adultUserSpec = new IsAdultUserSpec();
adultUserSpec.IsSatisfiedBy(user)


// And Composition
var adultUserSpec = new IsAdultUserSpec();
var validUserSpec = new IsValidUserSpec();
        
var andCompositeSpec = isValidUserSpec.And(isAdultUserSpec);

// Or Composition
var adultUserSpec = new IsAdultUserSpec();
var validUserSpec = new IsValidUserSpec();
        
var orCompositeSpec = isValidUserSpec.Or(isAdultUserSpec);

// Not Composition
var adultUserSpec = new IsAdultUserSpec();
adultUserSpec.Not().IsSatisfiedBy(user)


// Generic Spec Usage
var adultUserSpec = new Spec<User>(x => x.Age >= 18);
adultUserSpec.IsSatisfiedBy(user);

```
