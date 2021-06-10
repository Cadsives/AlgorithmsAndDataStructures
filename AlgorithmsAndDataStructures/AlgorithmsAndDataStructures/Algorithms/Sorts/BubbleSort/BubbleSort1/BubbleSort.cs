using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms.Sorts.BubbleSort.BubbleSort1
{
    class BubbleSort
    {
        public BubbleSort(int[] unsortedSet)
        {
            PerformBubbleSort(unsortedSet);
        }

        public void PerformBubbleSort(int[] unsortedSet)
        {
            int temp;

            for (int j = 0; j <= unsortedSet.Length - 2; j++)
            {
                for (int i = 0; i <= unsortedSet.Length - 2; i++)
                {
                    if(unsortedSet[i] > unsortedSet[i + 1])
                    {
                        temp = unsortedSet[i + 1];
                        unsortedSet[i + 1] = unsortedSet[i];
                        unsortedSet[i] = temp;
                        
                    }
                }
            }
            Console.WriteLine("Sorted: ");
            foreach (int p in unsortedSet)
                Console.Write(p + " ");
            Console.Read();
        } 
    }
}
