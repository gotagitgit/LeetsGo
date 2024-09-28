using DataStruct.Sequences;
using FluentAssertions;

namespace DataStructTests.Sequences;
public class SubstituteTextTests
{
    [Theory]
    [InlineData("internationalization", "i12iz4n", true)]
    [InlineData("apple", "4e", true)]
    [InlineData("apple", "a4e", false)]
    [InlineData("apple", "a4", false)]
    [InlineData("", "a2", false)]
    [InlineData("apple", "", false)]
    public void Should_substituteText(string text, string sub, bool expected)
    {
        var substituteText = new SubstituteText();

        var result = substituteText.CanSubstitute(text, sub);

        result.Should().Be(expected);
    }
}
