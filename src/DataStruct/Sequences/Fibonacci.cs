using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.Sequences;

public class Fibonacci
{
    readonly Dictionary<int, int> _memo = [];

    public int Fib(int num)
    {
        if (_memo.TryGetValue(num, out var value))
            return value;

        int result;

        if (num <= 2)
            result = 1;
        else
            result = Fib(num - 1) + Fib(num - 2);

        _memo[num] = result;

        return result;
    }
}
