using Develoopers.Spector.Unit.Tests.TestHelpers;
using FluentAssertions;
using Xunit;

namespace Develoopers.Spector.Unit.Tests;

public class AndSpectorCompositionTests
{
    [Fact]
    public void Should_Return_True_When_Both_Operands_Are_True()
    {
        var isAdultUserSpec = new IsAdultUserSpec();
        var isValidUserSpec = new IsValidUserSpec();
        
        var result = isValidUserSpec.And(isAdultUserSpec);
        
        result.IsSatisfiedBy(new User(19, "John")).Should().BeTrue();
    }

    [Fact]
    public void Should_Return_False_When_Both_Operands_Are_False()
    {
        var isAdultUserSpec = new IsAdultUserSpec();
        var isValidUserSpec = new IsValidUserSpec();
        
        var result = isValidUserSpec.And(isAdultUserSpec);
        
        result.IsSatisfiedBy(new User(1, "")).Should().BeFalse();
    }


    [Fact]
    public void Should_Return_False_When_One_Operand_Is_False()
    {
        var isAdultUserSpec = new IsAdultUserSpec();
        var isValidUserSpec = new IsValidUserSpec();
        
        var result = isValidUserSpec.And(isAdultUserSpec);
        
        result.IsSatisfiedBy(new User(20, "")).Should().BeFalse();
    }

    [Fact]
    public void Should_Return_False_When_One_Operand_Is_Null()
    {
        var isValidUserSpec = new IsValidUserSpec();
        
        var result = isValidUserSpec.And(null);
        
        result.IsSatisfiedBy(new User(20, "erman")).Should().BeFalse();
    }
}

