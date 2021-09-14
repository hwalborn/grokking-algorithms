using System;
using System.Collections.Generic;
using System.Linq;

namespace grokking_algorithms.ChapterTwo
{
    public class SelectionSort
    {
        private static int FindSmallest(List<int> arr)
        {
            var smallest = arr.First();
            var smallestIndex = 0;
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        public static List<int> RunSort(List<int> arr)
        {
            var newList = new List<int>();
            var lengthToGo = arr.Count;
            for (int i = 0; i < lengthToGo; i++)
            {
                var smallest = FindSmallest(arr);
                newList.Add(arr[smallest]);
                arr.RemoveAt(smallest);
            }
            return newList;
        }

        public static void Solution()
        {
            Console.WriteLine(String.Join(", ", RunSort(new List<int>() {5,3,6,2,10})));
        }
    }
}