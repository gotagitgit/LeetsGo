using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.SlidingWindow;

public class LongestSubstring
{
    public int LengthOfLongestSubstring(string s)
    {
        int size = s.Length;
        int right = 0;
        int left = 0;
        int maxLength = 0;
        var queue = new Queue();        

        while (right < size)
        {
            var rightString = s[right];

            Debug.WriteLine($"{s[left ..(right + 1)]}");

            if (!queue.Contains(rightString))
            {               
                queue.Enqueue(rightString);
                right++;

                var subString = s[left ..right];

                maxLength = Math.Max(maxLength, subString.Length);
            }
            else
            {  
                _ = queue.Dequeue();
                left++;
            }
        }

        return maxLength;
    } 
}
