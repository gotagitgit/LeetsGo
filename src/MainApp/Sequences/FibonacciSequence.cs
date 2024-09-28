namespace MainApp.Sequences;
internal class FibonacciSequence
{
    public static void Run()
    {
        var result = CalculateUsingIteration(6);

        Console.WriteLine($"The result is {result}");
    }

    public static int CalculateUsingIteration(int n)
    {
        int a = 0, b = 1, temp;

        for (int i = 0; i < n; i++)
        {
            temp = a;
            a = b;
            b = temp + b;
        }

        return a;
    }
}
