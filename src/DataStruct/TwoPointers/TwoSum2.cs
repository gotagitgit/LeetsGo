namespace DataStruct.TwoPointers;

public class TwoSum2
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var index1 = 0;

        var index2 = numbers.Length - 1;        

        var sum = numbers.Sum();

        int[] indices = [index1, index2];

        while (sum != target)
        {
            sum = numbers[index1] + numbers[index2];

            indices = [index1, index2];

            if (sum > target)
                index2--;

            if (sum < target)
                index1++;
        }

        indices = [index1 + 1, index2 + 1];

        return indices;
    }
}
