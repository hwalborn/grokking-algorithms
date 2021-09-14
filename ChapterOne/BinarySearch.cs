using System;
using System.Collections.Generic;
using System.Linq;

namespace grokking_algorithms.ChapterOne
{
    public class BinarySearch
    {
        public static int? RunSearch(List<int> arr, int item)
        {
            var low = 0;
            var high = arr.Count();
            while (low < high)
            {
                var mid = (int)Math.Floor((decimal)(low + high / 2));
                if (mid >= arr.Count || mid < 0)
                {
                    return null;
                }
                var guess = arr[mid];
                if (guess == item)
                {
                    return mid;
                }
                if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid - 1;
                }
            }
            return null; 
        }

        public static void DoSearch()
        {
            var myList = new List<int>() { 1, 3, 5, 7, 8 };
            Console.WriteLine(RunSearch(myList, 1));
            Console.WriteLine(RunSearch(myList, 10));
        }
    }
}