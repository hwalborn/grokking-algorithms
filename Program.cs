using System;
using grokking_algorithms.ChapterFour;
using grokking_algorithms.ChapterOne;
using grokking_algorithms.ChapterTwo;
using grokking_algorithms.ChapterSix;

namespace grokking_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // BinarySearch.DoSearch();
            // SelectionSort.Solution();
            // QuickSort.Solution();
            Console.WriteLine(BreadthFirst.Solution("thom"));
        }
    }
}
