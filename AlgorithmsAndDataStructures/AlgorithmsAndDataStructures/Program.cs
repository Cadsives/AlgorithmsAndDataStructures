using AlgorithmsAndDataStructures.Algorithms.Sorts.BubbleSort.BubbleSort1;
using System;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformBubbleSortDemo1();
            Console.ReadLine();
        }

        static void PerformBubbleSortDemo1()
        {
            int[] unsortedArray = new int[] { 99, 66, 33, 2, 1 };
            BubbleSort bubbleSort = new BubbleSort(unsortedArray);
        }
    }
}
