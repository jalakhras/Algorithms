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
        //BinarySearch
        public static void BinarySearch(int[] Numbers, int numberToSeach)
        {
            bool isFound = false;
            int low = 0;
            int hight = Numbers.Length - 1;
            int mid = 0;
            int numberOfTry = 0;
            while (!isFound)
            {
                mid = low + ((hight - low) / 2);

                if (low > hight)
                {
                    Console.WriteLine("Number not found ");
                    break;
                }
                numberOfTry = numberOfTry + 1;
                if (Numbers[mid] == numberToSeach)
                {
                    Console.WriteLine("Number is found " + numberToSeach);
                    Console.WriteLine("Using binary Search Algorithm find after number of try " + numberOfTry);
                    break;
                }
                if (Numbers[mid] < numberToSeach)
                {
                    low = mid + 1;
                }
                if (Numbers[mid] > numberToSeach)
                {
                    hight = mid - 1;
                }
            }
        }
        //InterpolationSearch
        public static void InterpolationSearch(int[] Numbers, int numberToSeach)
        {
            bool isFound = false;
            int low = 0;
            int hight = Numbers.Length - 1;
            int mid = 0;
            int numberOfTry = 0;
            while (!isFound)
            {
                if (low > hight)
                {
                    Console.WriteLine("Number not found ");
                    break;
                }
                mid = low + ((hight - low) / (Numbers[hight] - Numbers[low]))
                    * (numberToSeach - Numbers[low]);
                numberOfTry = numberOfTry + 1;
                if (Numbers[mid] == numberToSeach)
                {
                    Console.WriteLine("Number is found " + numberToSeach);
                    Console.WriteLine("Using binary Interpolation Search find after number of try " + numberOfTry);
                    break;
                }
                if (Numbers[mid] < numberToSeach)
                {
                    low = mid + 1;
                }
                if (Numbers[mid] > numberToSeach)
                {
                    hight = mid - 1;
                }
            }

        }

    }
}
