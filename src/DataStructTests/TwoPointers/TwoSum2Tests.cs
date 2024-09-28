using DataStruct.TwoPointers;
using FluentAssertions;

namespace DataStructTests.TwoPointers;

public class TwoSum2Tests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
    [InlineData(new int[] { 2, 3, 4 }, 6, new int[] { 1, 3 })]
    [InlineData(new int[] { -1, 0 }, -1, new int[] { 1, 2 })]
    [InlineData(new int[] { 0, 0, 3, 4 }, 0, new int[] { 1, 2 })]
    [InlineData(new int[] { 0, 0 }, 0, new int[] { 1, 2 })]
    [InlineData(new int[] { -1, 0 }, -1, new int[] { 1, 2 })]
    public void Should_process_two_sum_2(int[] numbers, int target, int[] expected)
    {
        var sut = new TwoSum2();

        var result = sut.TwoSum(numbers, target);

        result.Should().ContainInOrder(expected);
    }
}