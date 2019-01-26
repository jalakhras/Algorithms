﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
  public static class SortAlgorithm
    {
        //Big-o O(o^2)
        public static void  BubbleSort(int[] Numbers)
        {
            int n = Numbers.Length;
            int temp = 0; 
            for (int i = 0; i< n; i++) // n-Time
            {
                for (int j =1; j<(n-i); j++)
                {
                    if(Numbers[j-1] >Numbers[j]) //n Time
                    {
                        temp = Numbers[j - 1];
                        Numbers[j - 1] = Numbers[j];
                        Numbers[j] = temp;
                    }
                }
            }
        }
    }
}
