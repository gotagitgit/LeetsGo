namespace DataStruct.Sequences;

public class SubstituteText
{
    public bool CanSubstitute(string text, string substitute)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(substitute))
            return false;

        var queue = new Queue<char>(text);

        var parseQueue = GetSubstituteQueue(substitute);

        while (parseQueue.TryDequeue(out var subQueue))
        {
            if (int.TryParse(subQueue, out var number))
            {
                if (queue.Count <= number)
                    return false;

                for (int i = 0; i < number; i++)
                {
                    if (!queue.TryDequeue(out var _))
                        return false;
                }
            }
            else
            {
                if (queue.TryPeek(out var queueFirst))
                {
                    if (queueFirst.ToString() == subQueue)
                        _ = queue.Dequeue();
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }

    private static Queue<string> GetSubstituteQueue(string substitute)
    {
        var parseQueue = new Queue<string>();

        var numText = "";

        for (var i = 0; i < substitute.Length; i++)
        {
            var sub = substitute[i];

            if (int.TryParse(sub.ToString(), out var num))
            {
                numText += num;
            }
            else
            {
                if (!string.IsNullOrEmpty(numText))
                {
                    parseQueue.Enqueue(numText);
                    
                    numText = string.Empty;
                }

                parseQueue.Enqueue(sub.ToString());               
            }
        }

        if (!string.IsNullOrEmpty(numText))
        {
            parseQueue.Enqueue(numText);

            numText = string.Empty;
        }

        return parseQueue;
    }
}
