using Develoopers.Spector.Unit.Tests.TestHelpers;
using FluentAssertions;
using Xunit;

namespace Develoopers.Spector.Unit.Tests;

public class OrSpectorCompositionTests
{
    [Theory]
    [InlineData(20, "")]
    [InlineData(20, null)]
    [InlineData(1, "John")]
    public void Should_Return_True_When_One_Of_The_Operands_Is_True(int age, string name)
    {
        var isAdultUserSpec = new IsAdultUserSpec();
        var userHasAValidNameSpec = new IsValidUserSpec();
        
        var result = userHasAValidNameSpec.Or(isAdultUserSpec);
        
        result.IsSatisfiedBy(new User(age, name)).Should().BeTrue();
    }

    [Fact]
    public void Should_Return_False_When_Both_Operands_Are_False()
    {
        var isAdultUserSpec = new IsAdultUserSpec();
        var userHasAValidNameSpec = new IsValidUserSpec();
        
        var result = userHasAValidNameSpec.Or(isAdultUserSpec);
        
        result.IsSatisfiedBy(new User(1, "")).Should().BeFalse();
    }
}