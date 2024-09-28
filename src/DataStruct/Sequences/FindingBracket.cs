namespace DataStruct.Sequences;

public class FindingBracket
{
    private readonly Dictionary<char, char> _brackets = new Dictionary<char, char>
    {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' },
    };

    public bool IsBracketMatch(string brackets)
    {
        if (string.IsNullOrEmpty(brackets))
            return false;

        var bracketsLength = brackets.Length;

        if (bracketsLength % 2 != 0)
            return false;
        
        var bracketStack = new Stack<char>();

        for (var i = 0; i < brackets.Length; i++)
        {
            var bracket = brackets[i];  

            if (_brackets.ContainsKey(bracket))
            {
                bracketStack.Push(bracket);
                continue;
            }

            var topStackBracket = bracketStack.Peek();

            var closingBracket = _brackets[topStackBracket];

            if (bracket == closingBracket)
                bracketStack.Pop();
            else
                return false;
        }

        return true;
    }
}
