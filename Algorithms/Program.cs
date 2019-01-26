using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
