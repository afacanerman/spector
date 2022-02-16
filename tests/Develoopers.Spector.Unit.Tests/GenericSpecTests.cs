using Develoopers.Spector.Unit.Tests.TestHelpers;
using FluentAssertions;
using Xunit;

namespace Develoopers.Spector.Unit.Tests;

public class GenericSpecTests
{
    [Fact]
    public void Should_Return_True_When_Spec_IsSatisfied()
    {
        var isFreeSpec = new Spec<Subscription>(x => x.Price == 0);
        var result = isFreeSpec.IsSatisfiedBy(new Subscription(0));
        result.Should().BeTrue();
    }
    
    [Fact]
    public void Should_Return_False_When_Spec_Is_Not_Satisfied()
    {
        var isFreeSpec = new Spec<Subscription>(x => x.Price == 0);
        var result = isFreeSpec.IsSatisfiedBy(new Subscription(1));
        result.Should().BeFalse();
    }
}