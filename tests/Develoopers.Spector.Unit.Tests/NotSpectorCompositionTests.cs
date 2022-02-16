using Develoopers.Spector.Unit.Tests.TestHelpers;
using FluentAssertions;
using Xunit;

namespace Develoopers.Spector.Unit.Tests;

public class NotSpectorCompositionTests
{
    [Fact]
    public void Should_Return_False_When_Given_Spec_Is_True()
    {
        var isAdultUserSpec = new IsAdultUserSpec();
       
        var result = isAdultUserSpec.Not();
        
        result.IsSatisfiedBy(new User(20, "John")).Should().BeFalse();
    }
    
    [Fact]
    public void Should_Return_True_When_Given_Spec_Is_False()
    {
        var isAdultUserSpec = new IsAdultUserSpec();
       
        var result = isAdultUserSpec.Not();
        
        result.IsSatisfiedBy(new User(2, "John")).Should().BeTrue();
    }
}