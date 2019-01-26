using System;

namespace Algorithms
{
    public static class SearchAlgorithm
    {
        // LinearSearchAlgorithm O(n)
        public static void LinearSearch(int[] Numbers, int numberToSeach)
        {
            int numberOfTry = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                numberOfTry = numberOfTry + 1;
                if (Numbers[i] == numberToSeach)
                {
                    Console.WriteLine("Number is found " + numberToSeach);
                    Console.WriteLine("Using Linear Search Algorithm find after number of try " + numberOfTry);
                    break;
                }
            }

        }

        

    }
}
