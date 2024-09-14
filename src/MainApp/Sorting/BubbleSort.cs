namespace MainApp.Sorting;

internal class BubbleSort
{
   
    public static void Run()
    {
        int[] array = [23, 56, 4, 32, 67, 78, 1];

        for (int j = 0; j <= array.Length - 2; j++)
        {
            for (int i = 0; i <= array.Length - 2; i++)
            {
                if (array[i] > array[i + 1])
                    (array[i + 1], array[i]) = (array[i], array[i + 1]);

                // using extension
                //array.Swap(i);
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]} ");
        }
    }    
}

internal static class ArrayExtensions
{
    public static void Swap(this int[] array, int i)
    {
        if (array[i] > array[i + 1])
            (array[i + 1], array[i]) = (array[i], array[i + 1]);
    }
}
