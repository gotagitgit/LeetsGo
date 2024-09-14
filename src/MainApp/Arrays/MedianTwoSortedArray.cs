namespace MainApp.Arrays;

internal class MedianTwoSortedArray
{
    public static void Run()
    {
        int[] nums1 = [1, 2];

        int[] nums2 = [];

        var median = FindMedianSortedArrays(nums1, nums2 );

        Console.WriteLine($"The median is {median}");

    }

    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> numbers = [.. nums1, .. nums2];

        if (numbers.Count == 0)
            return 0d;

        if (numbers.Count == 1)
            return numbers[0];

        var quotient = numbers.Count / 2;

        var excess = numbers.Count % 2;

        var sortedList = numbers.OrderBy(x => x).ToList();

        var index = quotient - 1;        

        var sumOfMiddleNumbers = (sortedList[index] + sortedList[index + 1]);

        var median = (double)decimal.Divide(sumOfMiddleNumbers, 2);

        if (excess > 0)        
            median = sortedList[index + 1];

        return median;
    }
}
