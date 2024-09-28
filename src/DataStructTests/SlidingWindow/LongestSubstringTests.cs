using DataStruct.SlidingWindow;
using FluentAssertions;

namespace DataStructTests.SlidingWindow;

public class LongestSubstringTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineDataAttribute("", 0)]
    [InlineDataAttribute(" ", 1)]
    [InlineDataAttribute("1 23 ", 4)]
    [InlineDataAttribute("a", 1)]
    [InlineDataAttribute("ab", 2)]
    [InlineDataAttribute("abc", 3)]
    [InlineDataAttribute(" a ", 2)]
    [InlineDataAttribute("cdd", 2)]
    public void Should_get_length_of_longest_substring(string s, int expected)
    {
        var sut = new LongestSubstring();

        var result = sut.LengthOfLongestSubstring(s);

        result.Should().Be(expected);
    }
}
