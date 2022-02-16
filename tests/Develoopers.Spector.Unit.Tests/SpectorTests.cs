using Develoopers.Spector.Unit.Tests.TestHelpers;
using FluentAssertions;
using Xunit;

namespace Develoopers.Spector.Unit.Tests;

public class SpectorTests
{
    [Fact]
    public void IsSatisfiedBy_Should_Return_True_When_Subscription_Price_Is_Zero()
    {
        var subscription = new Subscription(0);
        var sut = new IsFreeSpec();
        sut.IsSatisfiedBy(subscription).Should().BeTrue();
    }
    
    [Fact]
    public void IsSatisfiedBy_Should_Return_False_When_Subscription_Price_Is_not_zero()
    {
        var subscription = new Subscription(10);
        var sut = new IsFreeSpec();
        sut.IsSatisfiedBy(subscription).Should().BeFalse();
    }
}