using System;
using System.Collections.Generic;
using System.Linq;

namespace grokking_algorithms.ChapterFour
{
    public class QuickSort
    {
        public static int Sum(List<int> arr)
        {
            if (arr.Count == 1)
            {
                return arr[0];
            }
            else
            {
                return arr[0] + Sum(arr.GetRange(1, arr.Count - 1));
            }
        }

        public static List<int> Implement(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }
            else if (arr.Count == 2)
            {
                if (arr[1] < arr[0])
                {
                    arr.Reverse();
                }
                return arr;
            }

            // find the elements smaller than the pivot and larger than the pivot
            var pivot = arr[0];

            var lessThan = arr.Where(num => num < pivot).ToList();
            var greaterThan = arr.Where(num => num > pivot).ToList();
            var newArr = Implement(lessThan);
            newArr.Add(pivot);
            newArr.AddRange(Implement(greaterThan));
            return newArr;
        }

        public static void Solution()
        {
            var test = new List<int> {1,2,3};
            var huh = new List<int> { 33, 15, 10};
            var sorted = Implement(huh);
            Console.WriteLine(String.Join(", ", sorted));
            test.Reverse();
            Console.WriteLine(String.Join(", ", test));
            Console.WriteLine(Sum(new List<int>() {1,2,3,4,5}));
        }
    }
}