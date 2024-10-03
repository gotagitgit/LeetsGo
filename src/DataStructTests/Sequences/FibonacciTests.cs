using DataStruct.Sequences;
using FluentAssertions;

namespace DataStructTests.Sequences;

public class FibonacciTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(6, 8)]
    public void Should_return_fibonacci(int number, int expected)
    {
        var fib = new Fibonacci();

        var result = fib.Fib(number);

        result.Should().Be(expected);   

    }

}
