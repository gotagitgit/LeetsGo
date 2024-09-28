using DataStruct.Sequences;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructTests.Sequences;

public class FindignBracketTests
{
    [Theory]
    [InlineData("(){}[]", true)]
    [InlineData("({[]})", true)]
    [InlineData("()", true)]
    [InlineData("(}[]})", false)]
    [InlineData("(", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void Test_bracket_properly_closed(string bracket, bool expected)
    {
        var findingBracket = new FindingBracket();

        var result = findingBracket.IsBracketMatch(bracket);

        result.Should().Be(expected);
    }
}
