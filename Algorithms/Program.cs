using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Search Algorithm
            Console.WriteLine("----------Search Algorithm------------ ");
            // generate int array 
            int size = 1000000;
            int[] Numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Numbers[i] = i + 1;
            }
            // sort Arrey 
            Array.Sort(Numbers);
            SearchAlgorithm.LinearSearch(Numbers, 99822);
            Console.WriteLine();
            SearchAlgorithm.BinarySearch(Numbers, 99822);
            Console.WriteLine();
            SearchAlgorithm.InterpolationSearch(Numbers, 99822);
            #endregion

            #region  Sort Algorithm
            Console.WriteLine("----------Sort Algorithm------------ ");
            int[] ArrayToSort = new int[] { 100, 20, 90, 30, 80, 40, 70, 50, 10, 60 };
            Console.WriteLine("Before Bubble Sorting ");
            foreach (int num in ArrayToSort)
            {
                Console.Write(num + "\t");
            }
            Console.WriteLine();
            SortAlgorithm.BubbleSort(ArrayToSort);
            Console.WriteLine("After Bubble Sorting ");
            foreach (int num in ArrayToSort)
            {
                Console.Write(num + "\t");
            }
            #endregion
        }
    }
}
